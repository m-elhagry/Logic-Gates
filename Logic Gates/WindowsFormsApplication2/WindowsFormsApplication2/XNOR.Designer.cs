namespace WindowsFormsApplication2
{
    partial class XNOR
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
            this.ChkB = new System.Windows.Forms.CheckBox();
            this.ChkA = new System.Windows.Forms.CheckBox();
            this.TxtOUT = new System.Windows.Forms.Label();
            this.PicOFF = new System.Windows.Forms.PictureBox();
            this.PicON = new System.Windows.Forms.PictureBox();
            this.PicXOR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicXOR)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkB
            // 
            this.ChkB.AutoSize = true;
            this.ChkB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB.Location = new System.Drawing.Point(12, 101);
            this.ChkB.Name = "ChkB";
            this.ChkB.Size = new System.Drawing.Size(45, 29);
            this.ChkB.TabIndex = 15;
            this.ChkB.Text = "B";
            this.ChkB.UseVisualStyleBackColor = true;
            this.ChkB.CheckedChanged += new System.EventHandler(this.ChkB_CheckedChanged);
            // 
            // ChkA
            // 
            this.ChkA.AutoSize = true;
            this.ChkA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkA.Location = new System.Drawing.Point(12, 25);
            this.ChkA.Name = "ChkA";
            this.ChkA.Size = new System.Drawing.Size(46, 29);
            this.ChkA.TabIndex = 14;
            this.ChkA.Text = "A";
            this.ChkA.UseVisualStyleBackColor = true;
            this.ChkA.CheckedChanged += new System.EventHandler(this.ChkA_CheckedChanged);
            // 
            // TxtOUT
            // 
            this.TxtOUT.AutoSize = true;
            this.TxtOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOUT.Location = new System.Drawing.Point(374, 85);
            this.TxtOUT.Name = "TxtOUT";
            this.TxtOUT.Size = new System.Drawing.Size(0, 25);
            this.TxtOUT.TabIndex = 13;
            // 
            // PicOFF
            // 
            this.PicOFF.Image = global::WindowsFormsApplication2.Properties.Resources._1197103478642310320webmichl_light_bulb_svg_hi;
            this.PicOFF.Location = new System.Drawing.Point(403, 11);
            this.PicOFF.Name = "PicOFF";
            this.PicOFF.Size = new System.Drawing.Size(139, 173);
            this.PicOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOFF.TabIndex = 17;
            this.PicOFF.TabStop = false;
            // 
            // PicON
            // 
            this.PicON.Image = global::WindowsFormsApplication2.Properties.Resources.light_bulb_100_lit_hi;
            this.PicON.Location = new System.Drawing.Point(403, 12);
            this.PicON.Name = "PicON";
            this.PicON.Size = new System.Drawing.Size(139, 173);
            this.PicON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicON.TabIndex = 16;
            this.PicON.TabStop = false;
            // 
            // PicXOR
            // 
            this.PicXOR.Image = global::WindowsFormsApplication2.Properties.Resources.CaptureXOR;
            this.PicXOR.Location = new System.Drawing.Point(12, 12);
            this.PicXOR.Name = "PicXOR";
            this.PicXOR.Size = new System.Drawing.Size(362, 172);
            this.PicXOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicXOR.TabIndex = 12;
            this.PicXOR.TabStop = false;
            // 
            // XNOR
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
            this.Controls.Add(this.PicXOR);
            this.MaximumSize = new System.Drawing.Size(571, 236);
            this.MinimumSize = new System.Drawing.Size(571, 236);
            this.Name = "XNOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XNOR";
            this.Load += new System.EventHandler(this.XNOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicXOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicOFF;
        private System.Windows.Forms.PictureBox PicON;
        private System.Windows.Forms.CheckBox ChkB;
        private System.Windows.Forms.CheckBox ChkA;
        private System.Windows.Forms.Label TxtOUT;
        private System.Windows.Forms.PictureBox PicXOR;

    }
}