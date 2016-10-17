using System;
using System.Windows.Forms;
using System.Diagnostics;
using MemoryManagerLib;
using System.Text.RegularExpressions;

namespace Aimbot
{
    public partial class Aimbot : Form
    {
        //
        //Process[] ProcessList;
        Process selectedProcess;

        PlayerInfo mainPlayer = new PlayerInfo(0x50F4F4, new int[] { }, new int[] { 0xF8, 0x40, 0x44, 0x34, 0x3C, 0x38 });
        PlayerInfo enemy;
        MemoryManager mem;

        public Aimbot()
        {
            InitializeComponent();
        }

        private void processTimer_Tick(object sender, EventArgs e)
        {
            // Display mainPlayer information
            mainPlayer.loadData(mem);
            mainPlayerHLabel.Text = "Health: " + mainPlayer.health;
            mainPlayerXLabel.Text = "X: " + mainPlayer.data[2];
            mainPlayerYLabel.Text = "Y: " + mainPlayer.data[3];
            mainPlayerZLabel.Text = "Z: " + mainPlayer.data[4];

            // Display enemy information
            enemy.loadData(mem);
            enemyHLabel.Text = "Health: " + enemy.health;
            enemyXLabel.Text = "X: " + enemy.data[2];
            enemyYLabel.Text = "Y: " + enemy.data[3];
            enemyZLabel.Text = "Z: " + enemy.data[4];

            // Check for each checkbox and mod accordingly

            // Check if aimbot enabled
            if(aimbotCheckbox.Checked)
            {
                // Check to make sure both are alive
                if (enemy.health > 0 && mainPlayer.health > 0)
                {
                    float xdif = enemy.data[2] - mainPlayer.data[2],
                            ydif = enemy.data[3] - mainPlayer.data[3],
                            zdif = enemy.data[4] - mainPlayer.data[4];

                    // Calculate the angle needed to change, convert to degrees
                    float yaw =    (float)(Math.Atan2(enemy.data[3] - mainPlayer.data[3], enemy.distanceTo(mainPlayer)) * 180 / Math.PI);
                    float pitch = -(float)(Math.Atan2(enemy.data[2]- mainPlayer.data[2], enemy.data[4] - mainPlayer.data[4]) * 180 / Math.PI + 180);

                    // Store the calculated values into memory
                    mem.WriteFloat(mainPlayer.pointerAddress + mainPlayer.offsets[1], pitch);
                    mem.WriteFloat(mainPlayer.pointerAddress + mainPlayer.offsets[2], yaw);
                }
            }

            // Check if health lock enabled
            if(healthCheckbox.Checked)
            {
                // Make sure that the player is alive when we start
                if(mainPlayer.data[0] > 0)
                {
                    mem.WriteInt(mainPlayer.pointerAddress + mainPlayer.offsets[0], 1000);
                }
            }
        }
        private void processChoiceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Find the id of the selected process
                int pID;
                int.TryParse(Regex.Match(processChoiceCombo.Text, @"\d+$").Value, out pID);

                // Set the selected process to the one of the id found
                selectedProcess = Process.GetProcessById(pID);

                // Create a new MemoryManager for the process
                mem = new MemoryManager(selectedProcess.Id);

                // Start the process timer
                processTimer.Start();

                // Initialize enemy info
                enemy = new PlayerInfo(selectedProcess.MainModule.BaseAddress.ToInt32() + 0x10F4F8, new int[] { 0x4 }, new int[] { 0xF8, 0x40, 0x44, 0x34, 0x3c, 0x38 });

                // Find the pointers from their bases/offsets in the program
                mainPlayer.findPointer(mem);
                enemy.findPointer(mem);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error attaching to process: " + ex.GetBaseException());
            }
        }

        private void processChoiceCombo_Click(object sender, EventArgs e)
        {
            processChoiceCombo.Items.Clear();

            foreach(Process process in Process.GetProcesses())
            {
                processChoiceCombo.Items.Add(process.ProcessName + " - " + process.Id);
            }
        }
    }
}