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
            this.MainPlayerLabel = new System.Windows.Forms.Label();
            this.MainPlayerXLabel = new System.Windows.Forms.Label();
            this.MainPlayerZLabel = new System.Windows.Forms.Label();
            this.MainPlayerYLabel = new System.Windows.Forms.Label();
            this.EnemyYLabel = new System.Windows.Forms.Label();
            this.EnemyZLabel = new System.Windows.Forms.Label();
            this.EnemyXLabel = new System.Windows.Forms.Label();
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.EnemyHLabel = new System.Windows.Forms.Label();
            this.MainPlayerHLabel = new System.Windows.Forms.Label();
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
            // MainPlayerLabel
            // 
            this.MainPlayerLabel.AutoSize = true;
            this.MainPlayerLabel.Location = new System.Drawing.Point(150, 9);
            this.MainPlayerLabel.Name = "MainPlayerLabel";
            this.MainPlayerLabel.Size = new System.Drawing.Size(112, 13);
            this.MainPlayerLabel.TabIndex = 7;
            this.MainPlayerLabel.Text = "MainPlayer Properties:";
            // 
            // MainPlayerXLabel
            // 
            this.MainPlayerXLabel.AutoSize = true;
            this.MainPlayerXLabel.Location = new System.Drawing.Point(150, 49);
            this.MainPlayerXLabel.Name = "MainPlayerXLabel";
            this.MainPlayerXLabel.Size = new System.Drawing.Size(20, 13);
            this.MainPlayerXLabel.TabIndex = 8;
            this.MainPlayerXLabel.Text = "X: ";
            // 
            // MainPlayerZLabel
            // 
            this.MainPlayerZLabel.AutoSize = true;
            this.MainPlayerZLabel.Location = new System.Drawing.Point(150, 93);
            this.MainPlayerZLabel.Name = "MainPlayerZLabel";
            this.MainPlayerZLabel.Size = new System.Drawing.Size(20, 13);
            this.MainPlayerZLabel.TabIndex = 9;
            this.MainPlayerZLabel.Text = "Z: ";
            // 
            // MainPlayerYLabel
            // 
            this.MainPlayerYLabel.AutoSize = true;
            this.MainPlayerYLabel.Location = new System.Drawing.Point(150, 72);
            this.MainPlayerYLabel.Name = "MainPlayerYLabel";
            this.MainPlayerYLabel.Size = new System.Drawing.Size(20, 13);
            this.MainPlayerYLabel.TabIndex = 10;
            this.MainPlayerYLabel.Text = "Y: ";
            // 
            // EnemyYLabel
            // 
            this.EnemyYLabel.AutoSize = true;
            this.EnemyYLabel.Location = new System.Drawing.Point(268, 72);
            this.EnemyYLabel.Name = "EnemyYLabel";
            this.EnemyYLabel.Size = new System.Drawing.Size(20, 13);
            this.EnemyYLabel.TabIndex = 14;
            this.EnemyYLabel.Text = "Y: ";
            // 
            // EnemyZLabel
            // 
            this.EnemyZLabel.AutoSize = true;
            this.EnemyZLabel.Location = new System.Drawing.Point(268, 93);
            this.EnemyZLabel.Name = "EnemyZLabel";
            this.EnemyZLabel.Size = new System.Drawing.Size(20, 13);
            this.EnemyZLabel.TabIndex = 13;
            this.EnemyZLabel.Text = "Z: ";
            // 
            // EnemyXLabel
            // 
            this.EnemyXLabel.AutoSize = true;
            this.EnemyXLabel.Location = new System.Drawing.Point(268, 49);
            this.EnemyXLabel.Name = "EnemyXLabel";
            this.EnemyXLabel.Size = new System.Drawing.Size(20, 13);
            this.EnemyXLabel.TabIndex = 12;
            this.EnemyXLabel.Text = "X: ";
            // 
            // EnemyLabel
            // 
            this.EnemyLabel.AutoSize = true;
            this.EnemyLabel.Location = new System.Drawing.Point(268, 9);
            this.EnemyLabel.Name = "EnemyLabel";
            this.EnemyLabel.Size = new System.Drawing.Size(92, 13);
            this.EnemyLabel.TabIndex = 11;
            this.EnemyLabel.Text = "Enemy Properties:";
            // 
            // EnemyHLabel
            // 
            this.EnemyHLabel.AutoSize = true;
            this.EnemyHLabel.Location = new System.Drawing.Point(268, 28);
            this.EnemyHLabel.Name = "EnemyHLabel";
            this.EnemyHLabel.Size = new System.Drawing.Size(44, 13);
            this.EnemyHLabel.TabIndex = 15;
            this.EnemyHLabel.Text = "Health: ";
            // 
            // MainPlayerHLabel
            // 
            this.MainPlayerHLabel.AutoSize = true;
            this.MainPlayerHLabel.Location = new System.Drawing.Point(150, 28);
            this.MainPlayerHLabel.Name = "MainPlayerHLabel";
            this.MainPlayerHLabel.Size = new System.Drawing.Size(44, 13);
            this.MainPlayerHLabel.TabIndex = 16;
            this.MainPlayerHLabel.Text = "Health: ";
            // 
            // Aimbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 158);
            this.Controls.Add(this.MainPlayerHLabel);
            this.Controls.Add(this.EnemyHLabel);
            this.Controls.Add(this.EnemyYLabel);
            this.Controls.Add(this.EnemyZLabel);
            this.Controls.Add(this.EnemyXLabel);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.MainPlayerYLabel);
            this.Controls.Add(this.MainPlayerZLabel);
            this.Controls.Add(this.MainPlayerXLabel);
            this.Controls.Add(this.MainPlayerLabel);
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
        private System.Windows.Forms.Label MainPlayerLabel;
        private System.Windows.Forms.Label MainPlayerXLabel;
        private System.Windows.Forms.Label MainPlayerZLabel;
        private System.Windows.Forms.Label MainPlayerYLabel;
        private System.Windows.Forms.Label EnemyYLabel;
        private System.Windows.Forms.Label EnemyZLabel;
        private System.Windows.Forms.Label EnemyXLabel;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.Label EnemyHLabel;
        private System.Windows.Forms.Label MainPlayerHLabel;
    }
}

