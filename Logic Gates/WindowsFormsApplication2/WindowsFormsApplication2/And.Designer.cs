namespace WindowsFormsApplication2
{
    partial class And
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
            this.TxtOUT = new System.Windows.Forms.Label();
            this.ChkA = new System.Windows.Forms.CheckBox();
            this.ChkB = new System.Windows.Forms.CheckBox();
            this.PicOFF = new System.Windows.Forms.PictureBox();
            this.PicON = new System.Windows.Forms.PictureBox();
            this.PicAND = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAND)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOUT
            // 
            this.TxtOUT.AutoSize = true;
            this.TxtOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOUT.Location = new System.Drawing.Point(374, 85);
            this.TxtOUT.Name = "TxtOUT";
            this.TxtOUT.Size = new System.Drawing.Size(0, 25);
            this.TxtOUT.TabIndex = 1;
            // 
            // ChkA
            // 
            this.ChkA.AutoSize = true;
            this.ChkA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkA.Location = new System.Drawing.Point(12, 23);
            this.ChkA.Name = "ChkA";
            this.ChkA.Size = new System.Drawing.Size(46, 29);
            this.ChkA.TabIndex = 2;
            this.ChkA.Text = "A";
            this.ChkA.UseVisualStyleBackColor = true;
            this.ChkA.CheckedChanged += new System.EventHandler(this.ChkA_CheckedChanged);
            // 
            // ChkB
            // 
            this.ChkB.AutoSize = true;
            this.ChkB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB.Location = new System.Drawing.Point(12, 101);
            this.ChkB.Name = "ChkB";
            this.ChkB.Size = new System.Drawing.Size(45, 29);
            this.ChkB.TabIndex = 3;
            this.ChkB.Text = "B";
            this.ChkB.UseVisualStyleBackColor = true;
            this.ChkB.CheckedChanged += new System.EventHandler(this.ChkB_CheckedChanged);
            // 
            // PicOFF
            // 
            this.PicOFF.Image = global::WindowsFormsApplication2.Properties.Resources._1197103478642310320webmichl_light_bulb_svg_hi;
            this.PicOFF.Location = new System.Drawing.Point(403, 11);
            this.PicOFF.Name = "PicOFF";
            this.PicOFF.Size = new System.Drawing.Size(139, 173);
            this.PicOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOFF.TabIndex = 5;
            this.PicOFF.TabStop = false;
            // 
            // PicON
            // 
            this.PicON.Image = global::WindowsFormsApplication2.Properties.Resources.light_bulb_100_lit_hi;
            this.PicON.Location = new System.Drawing.Point(403, 12);
            this.PicON.Name = "PicON";
            this.PicON.Size = new System.Drawing.Size(139, 173);
            this.PicON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicON.TabIndex = 4;
            this.PicON.TabStop = false;
            // 
            // PicAND
            // 
            this.PicAND.Image = global::WindowsFormsApplication2.Properties.Resources.Capturenew;
            this.PicAND.Location = new System.Drawing.Point(12, 12);
            this.PicAND.Name = "PicAND";
            this.PicAND.Size = new System.Drawing.Size(362, 172);
            this.PicAND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAND.TabIndex = 0;
            this.PicAND.TabStop = false;
            // 
            // And
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 197);
            this.Controls.Add(this.PicOFF);
            this.Controls.Add(this.PicON);
            this.Controls.Add(this.ChkB);
            this.Controls.Add(this.ChkA);
            this.Controls.Add(this.TxtOUT);
            this.Controls.Add(this.PicAND);
            this.MaximumSize = new System.Drawing.Size(571, 236);
            this.MinimumSize = new System.Drawing.Size(571, 236);
            this.Name = "And";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "And";
            this.Load += new System.EventHandler(this.And_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicAND;
        private System.Windows.Forms.Label TxtOUT;
        private System.Windows.Forms.CheckBox ChkA;
        private System.Windows.Forms.CheckBox ChkB;
        private System.Windows.Forms.PictureBox PicON;
        private System.Windows.Forms.PictureBox PicOFF;
    }
}