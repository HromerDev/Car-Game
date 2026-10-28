namespace videohra
{
    partial class Form1
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.spawnLocation2 = new System.Windows.Forms.PictureBox();
			this.car = new System.Windows.Forms.PictureBox();
			this.spawnLocation3 = new System.Windows.Forms.PictureBox();
			this.spawnLocation1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.spawnLocation2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spawnLocation3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spawnLocation1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.Update);
			// 
			// buttonUp
			// 
			this.buttonUp.Location = new System.Drawing.Point(647, 156);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(75, 75);
			this.buttonUp.TabIndex = 0;
			this.buttonUp.Text = "UP";
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseDown);
			this.buttonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseUp);
			// 
			// buttonDown
			// 
			this.buttonDown.Location = new System.Drawing.Point(647, 237);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(75, 75);
			this.buttonDown.TabIndex = 1;
			this.buttonDown.Text = "DOWN";
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseDown);
			this.buttonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseUp);
			// 
			// spawnLocation2
			// 
			this.spawnLocation2.Image = global::videohra.Properties.Resources._657506_square_512x5121;
			this.spawnLocation2.Location = new System.Drawing.Point(582, 208);
			this.spawnLocation2.Name = "spawnLocation2";
			this.spawnLocation2.Size = new System.Drawing.Size(50, 50);
			this.spawnLocation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.spawnLocation2.TabIndex = 6;
			this.spawnLocation2.TabStop = false;
			// 
			// car
			// 
			this.car.Image = global::videohra.Properties.Resources.mclaren_750s_driving_dynamic_hero_1920x774px;
			this.car.Location = new System.Drawing.Point(32, 208);
			this.car.Name = "car";
			this.car.Size = new System.Drawing.Size(100, 50);
			this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.car.TabIndex = 2;
			this.car.TabStop = false;
			// 
			// spawnLocation3
			// 
			this.spawnLocation3.Image = global::videohra.Properties.Resources._657506_square_512x5121;
			this.spawnLocation3.Location = new System.Drawing.Point(582, 294);
			this.spawnLocation3.Name = "spawnLocation3";
			this.spawnLocation3.Size = new System.Drawing.Size(50, 50);
			this.spawnLocation3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.spawnLocation3.TabIndex = 7;
			this.spawnLocation3.TabStop = false;
			// 
			// spawnLocation1
			// 
			this.spawnLocation1.Image = global::videohra.Properties.Resources._657506_square_512x5121;
			this.spawnLocation1.Location = new System.Drawing.Point(582, 115);
			this.spawnLocation1.Name = "spawnLocation1";
			this.spawnLocation1.Size = new System.Drawing.Size(50, 50);
			this.spawnLocation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.spawnLocation1.TabIndex = 8;
			this.spawnLocation1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 55);
			this.label1.TabIndex = 9;
			this.label1.Text = "Score: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 461);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.spawnLocation1);
			this.Controls.Add(this.spawnLocation3);
			this.Controls.Add(this.spawnLocation2);
			this.Controls.Add(this.car);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonUp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.spawnLocation2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spawnLocation3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spawnLocation1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox spawnLocation2;
        private System.Windows.Forms.PictureBox spawnLocation3;
        private System.Windows.Forms.PictureBox spawnLocation1;
		private System.Windows.Forms.Label label1;
	}
}

