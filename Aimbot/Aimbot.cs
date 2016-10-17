using System;
using System.Windows.Forms;
using System.Diagnostics;
using MemoryManagerLib;
namespace Aimbot
{
    public partial class Aimbot : Form
    {
        Process[] ProcessList;

        PlayerInfo MainPlayer = new PlayerInfo(0x50F4F4, new int[] { }, new int[] { 0xF8, 0x40, 0x44, 0x34, 0x3C, 0x38 });
        PlayerInfo Enemy;
        MemoryManager Mem;

        public Aimbot()
        {
            InitializeComponent();
        }

        private void processTimer_Tick(object sender, EventArgs e)
        {
            // Display MainPlayer information
            MainPlayer.loadData(Mem);
            MainPlayerHLabel.Text = "Health: " + MainPlayer.health;
            MainPlayerXLabel.Text = "X: " + MainPlayer.data[2];
            MainPlayerYLabel.Text = "Y: " + MainPlayer.data[3];
            MainPlayerZLabel.Text = "Z: " + MainPlayer.data[4];

            // Display Enemy information
            Enemy.loadData(Mem);
            EnemyHLabel.Text = "Health: " + Enemy.health;
            EnemyXLabel.Text = "X: " + Enemy.data[2];
            EnemyYLabel.Text = "Y: " + Enemy.data[3];
            EnemyZLabel.Text = "Z: " + Enemy.data[4];

            // Check for each checkbox and mod accordingly

            // Check if aimbot enabled
            if(aimbotCheckbox.Checked)
            {
                // Check to make sure both are alive
                if (Enemy.health > 0 && MainPlayer.health > 0)
                {
                    float xdif = Enemy.data[2] - MainPlayer.data[2],
                            ydif = Enemy.data[3] - MainPlayer.data[3],
                            zdif = Enemy.data[4] - MainPlayer.data[4];

                    // Calculate the angle needed to change, convert to degrees
                    float yaw =    (float)(Math.Atan2(Enemy.data[3] - MainPlayer.data[3], Enemy.distanceTo(MainPlayer)) * 180 / Math.PI);
                    float pitch = -(float)(Math.Atan2(Enemy.data[2]- MainPlayer.data[2], Enemy.data[4] - MainPlayer.data[4]) * 180 / Math.PI + 180);

                    // Store the calculated values into memory
                    Mem.WriteFloat(MainPlayer.pointerAddress + MainPlayer.offsets[1], pitch);
                    Mem.WriteFloat(MainPlayer.pointerAddress + MainPlayer.offsets[2], yaw);
                }
            }

            // Check if health lock enabled
            if(healthCheckbox.Checked)
            {
                // Make sure that the player is alive when we start
                if(MainPlayer.data[0] > 0)
                {
                    Mem.WriteInt(MainPlayer.pointerAddress + MainPlayer.offsets[0], 1000);
                }
            }
        }
        private void processChoiceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                // Attach to process
                ProcessList[0] = Process.GetProcessById(ProcessList[processChoiceCombo.SelectedIndex].Id);
                Mem = new MemoryManager(ProcessList[0].Id);
                processTimer.Start();

                // Set the method to run when the process is quit
                //ProcessList[0].Exited += process_Exited;

                // Initialize enemy info
                Enemy = new PlayerInfo(ProcessList[0].MainModule.BaseAddress.ToInt32() + 0x10F4F8, new int[] { 0x4 }, new int[] { 0xF8, 0x40, 0x44, 0x34, 0x3c, 0x38 });

                // Find the pointers from their bases/offsets in the program
                MainPlayer.findPointer(Mem);
                Enemy.findPointer(Mem);
            }
            catch(Exception ex) {
                MessageBox.Show("Error attaching to process: " + ex.GetBaseException());
            }
        }

        private void processChoiceCombo_Click(object sender, EventArgs e)
        {
            processChoiceCombo.Items.Clear();
            ProcessList = Process.GetProcesses();

            for(int i = 0; i < ProcessList.Length; i++)
            {
                processChoiceCombo.Items.Add(ProcessList[i].ProcessName + " - " + ProcessList[i].Id);
            }
        }

        private void process_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("Process has closed. Please restart game in order to use functionally");
        }
    }
}