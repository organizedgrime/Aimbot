namespace Aimbot
{
    partial class Aimbot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.aimbotCheckbox = new System.Windows.Forms.CheckBox();
            this.healthCheckbox = new System.Windows.Forms.CheckBox();
            this.ammoCheckbox = new System.Windows.Forms.CheckBox();
            this.processChoiceCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.processTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mainPlayerLabel = new System.Windows.Forms.Label();
            this.mainPlayerXLabel = new System.Windows.Forms.Label();
            this.mainPlayerZLabel = new System.Windows.Forms.Label();
            this.mainPlayerYLabel = new System.Windows.Forms.Label();
            this.enemyYLabel = new System.Windows.Forms.Label();
            this.enemyZLabel = new System.Windows.Forms.Label();
            this.enemyXLabel = new System.Windows.Forms.Label();
            this.enemyLabel = new System.Windows.Forms.Label();
            this.enemyHLabel = new System.Windows.Forms.Label();
            this.mainPlayerHLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjust Settings";
            // 
            // aimbotCheckbox
            // 
            this.aimbotCheckbox.AutoSize = true;
            this.aimbotCheckbox.Location = new System.Drawing.Point(12, 66);
            this.aimbotCheckbox.Name = "aimbotCheckbox";
            this.aimbotCheckbox.Size = new System.Drawing.Size(83, 17);
            this.aimbotCheckbox.TabIndex = 1;
            this.aimbotCheckbox.Text = "Auto Aimbot";
            this.aimbotCheckbox.UseVisualStyleBackColor = true;
            // 
            // healthCheckbox
            // 
            this.healthCheckbox.AutoSize = true;
            this.healthCheckbox.Location = new System.Drawing.Point(12, 90);
            this.healthCheckbox.Name = "healthCheckbox";
            this.healthCheckbox.Size = new System.Drawing.Size(91, 17);
            this.healthCheckbox.TabIndex = 2;
            this.healthCheckbox.Text = "Infinite Health";
            this.healthCheckbox.UseVisualStyleBackColor = true;
            // 
            // ammoCheckbox
            // 
            this.ammoCheckbox.AutoSize = true;
            this.ammoCheckbox.Location = new System.Drawing.Point(12, 114);
            this.ammoCheckbox.Name = "ammoCheckbox";
            this.ammoCheckbox.Size = new System.Drawing.Size(89, 17);
            this.ammoCheckbox.TabIndex = 3;
            this.ammoCheckbox.Text = "Infinite Ammo";
            this.ammoCheckbox.UseVisualStyleBackColor = true;
            this.ammoCheckbox.Visible = false;
            // 
            // processChoiceCombo
            // 
            this.processChoiceCombo.FormattingEnabled = true;
            this.processChoiceCombo.Location = new System.Drawing.Point(12, 25);
            this.processChoiceCombo.Name = "processChoiceCombo";
            this.processChoiceCombo.Size = new System.Drawing.Size(121, 21);
            this.processChoiceCombo.TabIndex = 4;
            this.processChoiceCombo.SelectedIndexChanged += new System.EventHandler(this.processChoiceCombo_SelectedIndexChanged);
            this.processChoiceCombo.Click += new System.EventHandler(this.processChoiceCombo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Process:";
            // 
            // processTimer
            // 
            this.processTimer.Interval = 10;
            this.processTimer.Tick += new System.EventHandler(this.processTimer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Instant Reload";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // mainPlayerLabel
            // 
            this.mainPlayerLabel.AutoSize = true;
            this.mainPlayerLabel.Location = new System.Drawing.Point(150, 9);
            this.mainPlayerLabel.Name = "mainPlayerLabel";
            this.mainPlayerLabel.Size = new System.Drawing.Size(112, 13);
            this.mainPlayerLabel.TabIndex = 7;
            this.mainPlayerLabel.Text = "MainPlayer Properties:";
            // 
            // mainPlayerXLabel
            // 
            this.mainPlayerXLabel.AutoSize = true;
            this.mainPlayerXLabel.Location = new System.Drawing.Point(150, 49);
            this.mainPlayerXLabel.Name = "mainPlayerXLabel";
            this.mainPlayerXLabel.Size = new System.Drawing.Size(20, 13);
            this.mainPlayerXLabel.TabIndex = 8;
            this.mainPlayerXLabel.Text = "X: ";
            // 
            // mainPlayerZLabel
            // 
            this.mainPlayerZLabel.AutoSize = true;
            this.mainPlayerZLabel.Location = new System.Drawing.Point(150, 93);
            this.mainPlayerZLabel.Name = "mainPlayerZLabel";
            this.mainPlayerZLabel.Size = new System.Drawing.Size(20, 13);
            this.mainPlayerZLabel.TabIndex = 9;
            this.mainPlayerZLabel.Text = "Z: ";
            // 
            // mainPlayerYLabel
            // 
            this.mainPlayerYLabel.AutoSize = true;
            this.mainPlayerYLabel.Location = new System.Drawing.Point(150, 72);
            this.mainPlayerYLabel.Name = "mainPlayerYLabel";
            this.mainPlayerYLabel.Size = new System.Drawing.Size(20, 13);
            this.mainPlayerYLabel.TabIndex = 10;
            this.mainPlayerYLabel.Text = "Y: ";
            // 
            // enemyYLabel
            // 
            this.enemyYLabel.AutoSize = true;
            this.enemyYLabel.Location = new System.Drawing.Point(268, 72);
            this.enemyYLabel.Name = "enemyYLabel";
            this.enemyYLabel.Size = new System.Drawing.Size(20, 13);
            this.enemyYLabel.TabIndex = 14;
            this.enemyYLabel.Text = "Y: ";
            // 
            // enemyZLabel
            // 
            this.enemyZLabel.AutoSize = true;
            this.enemyZLabel.Location = new System.Drawing.Point(268, 93);
            this.enemyZLabel.Name = "enemyZLabel";
            this.enemyZLabel.Size = new System.Drawing.Size(20, 13);
            this.enemyZLabel.TabIndex = 13;
            this.enemyZLabel.Text = "Z: ";
            // 
            // enemyXLabel
            // 
            this.enemyXLabel.AutoSize = true;
            this.enemyXLabel.Location = new System.Drawing.Point(268, 49);
            this.enemyXLabel.Name = "enemyXLabel";
            this.enemyXLabel.Size = new System.Drawing.Size(20, 13);
            this.enemyXLabel.TabIndex = 12;
            this.enemyXLabel.Text = "X: ";
            // 
            // enemyLabel
            // 
            this.enemyLabel.AutoSize = true;
            this.enemyLabel.Location = new System.Drawing.Point(268, 9);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(92, 13);
            this.enemyLabel.TabIndex = 11;
            this.enemyLabel.Text = "Enemy Properties:";
            // 
            // enemyHLabel
            // 
            this.enemyHLabel.AutoSize = true;
            this.enemyHLabel.Location = new System.Drawing.Point(268, 28);
            this.enemyHLabel.Name = "enemyHLabel";
            this.enemyHLabel.Size = new System.Drawing.Size(44, 13);
            this.enemyHLabel.TabIndex = 15;
            this.enemyHLabel.Text = "Health: ";
            // 
            // mainPlayerHLabel
            // 
            this.mainPlayerHLabel.AutoSize = true;
            this.mainPlayerHLabel.Location = new System.Drawing.Point(150, 28);
            this.mainPlayerHLabel.Name = "mainPlayerHLabel";
            this.mainPlayerHLabel.Size = new System.Drawing.Size(44, 13);
            this.mainPlayerHLabel.TabIndex = 16;
            this.mainPlayerHLabel.Text = "Health: ";
            // 
            // Aimbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 114);
            this.Controls.Add(this.mainPlayerHLabel);
            this.Controls.Add(this.enemyHLabel);
            this.Controls.Add(this.enemyYLabel);
            this.Controls.Add(this.enemyZLabel);
            this.Controls.Add(this.enemyXLabel);
            this.Controls.Add(this.enemyLabel);
            this.Controls.Add(this.mainPlayerYLabel);
            this.Controls.Add(this.mainPlayerZLabel);
            this.Controls.Add(this.mainPlayerXLabel);
            this.Controls.Add(this.mainPlayerLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.processChoiceCombo);
            this.Controls.Add(this.ammoCheckbox);
            this.Controls.Add(this.healthCheckbox);
            this.Controls.Add(this.aimbotCheckbox);
            this.Controls.Add(this.label1);
            this.Name = "Aimbot";
            this.Text = "AssaultCube Aimbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox aimbotCheckbox;
        private System.Windows.Forms.CheckBox healthCheckbox;
        private System.Windows.Forms.CheckBox ammoCheckbox;
        private System.Windows.Forms.ComboBox processChoiceCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer processTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label mainPlayerLabel;
        private System.Windows.Forms.Label mainPlayerXLabel;
        private System.Windows.Forms.Label mainPlayerZLabel;
        private System.Windows.Forms.Label mainPlayerYLabel;
        private System.Windows.Forms.Label enemyYLabel;
        private System.Windows.Forms.Label enemyZLabel;
        private System.Windows.Forms.Label enemyXLabel;
        private System.Windows.Forms.Label enemyLabel;
        private System.Windows.Forms.Label enemyHLabel;
        private System.Windows.Forms.Label mainPlayerHLabel;
    }
}

