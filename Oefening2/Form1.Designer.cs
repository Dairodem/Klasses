namespace Oefening2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChannelUp = new System.Windows.Forms.Button();
            this.btnChannelDown = new System.Windows.Forms.Button();
            this.btnVolDown = new System.Windows.Forms.Button();
            this.btnVolUp = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChannelUp
            // 
            this.btnChannelUp.ForeColor = System.Drawing.Color.Maroon;
            this.btnChannelUp.Location = new System.Drawing.Point(587, 281);
            this.btnChannelUp.Name = "btnChannelUp";
            this.btnChannelUp.Size = new System.Drawing.Size(75, 54);
            this.btnChannelUp.TabIndex = 1;
            this.btnChannelUp.Text = "CH +";
            this.btnChannelUp.UseVisualStyleBackColor = true;
            this.btnChannelUp.Click += new System.EventHandler(this.btnChannelUp_Click);
            // 
            // btnChannelDown
            // 
            this.btnChannelDown.ForeColor = System.Drawing.Color.Maroon;
            this.btnChannelDown.Location = new System.Drawing.Point(668, 281);
            this.btnChannelDown.Name = "btnChannelDown";
            this.btnChannelDown.Size = new System.Drawing.Size(75, 54);
            this.btnChannelDown.TabIndex = 2;
            this.btnChannelDown.Text = "CH -";
            this.btnChannelDown.UseVisualStyleBackColor = true;
            this.btnChannelDown.Click += new System.EventHandler(this.btnChannelDown_Click);
            // 
            // btnVolDown
            // 
            this.btnVolDown.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVolDown.Location = new System.Drawing.Point(668, 350);
            this.btnVolDown.Name = "btnVolDown";
            this.btnVolDown.Size = new System.Drawing.Size(75, 54);
            this.btnVolDown.TabIndex = 4;
            this.btnVolDown.Text = "Vol -";
            this.btnVolDown.UseVisualStyleBackColor = true;
            this.btnVolDown.Click += new System.EventHandler(this.btnVolDown_Click);
            // 
            // btnVolUp
            // 
            this.btnVolUp.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVolUp.Location = new System.Drawing.Point(587, 350);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(75, 54);
            this.btnVolUp.TabIndex = 3;
            this.btnVolUp.Text = "Vol +";
            this.btnVolUp.UseVisualStyleBackColor = true;
            this.btnVolUp.Click += new System.EventHandler(this.btnVolUp_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannel.Location = new System.Drawing.Point(25, 19);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(109, 31);
            this.lblChannel.TabIndex = 5;
            this.lblChannel.Text = "channel";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVol.Location = new System.Drawing.Point(518, 19);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(44, 31);
            this.lblVol.TabIndex = 6;
            this.lblVol.Text = "15";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.btnVolDown);
            this.Controls.Add(this.btnVolUp);
            this.Controls.Add(this.btnChannelDown);
            this.Controls.Add(this.btnChannelUp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChannelUp;
        private System.Windows.Forms.Button btnChannelDown;
        private System.Windows.Forms.Button btnVolDown;
        private System.Windows.Forms.Button btnVolUp;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblVol;
    }
}

