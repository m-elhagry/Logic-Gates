namespace WindowsFormsApplication2
{
    partial class LogicGates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogicGates));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnAND = new System.Windows.Forms.Button();
            this.BtnOR = new System.Windows.Forms.Button();
            this.BtnXOR = new System.Windows.Forms.Button();
            this.BtnNOT = new System.Windows.Forms.Button();
            this.BtnXNOR = new System.Windows.Forms.Button();
            this.BtnNOR = new System.Windows.Forms.Button();
            this.BtnNAND = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Kyo-Tux-Delikate-Info.ico");
            this.imageList1.Images.SetKeyName(1, "logout-icon-181922.png");
            // 
            // BtnAND
            // 
            this.BtnAND.BackColor = System.Drawing.Color.Maroon;
            this.BtnAND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAND.ForeColor = System.Drawing.Color.Black;
            this.BtnAND.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAND.ImageIndex = 0;
            this.BtnAND.Location = new System.Drawing.Point(39, 27);
            this.BtnAND.Name = "BtnAND";
            this.BtnAND.Size = new System.Drawing.Size(204, 160);
            this.BtnAND.TabIndex = 2;
            this.BtnAND.Text = "AND";
            this.BtnAND.UseVisualStyleBackColor = false;
            this.BtnAND.Click += new System.EventHandler(this.BtnAND_Click);
            // 
            // BtnOR
            // 
            this.BtnOR.BackColor = System.Drawing.Color.Maroon;
            this.BtnOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOR.ForeColor = System.Drawing.Color.Black;
            this.BtnOR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOR.ImageIndex = 0;
            this.BtnOR.Location = new System.Drawing.Point(279, 27);
            this.BtnOR.Name = "BtnOR";
            this.BtnOR.Size = new System.Drawing.Size(204, 160);
            this.BtnOR.TabIndex = 3;
            this.BtnOR.Text = "OR";
            this.BtnOR.UseVisualStyleBackColor = false;
            this.BtnOR.Click += new System.EventHandler(this.BtnOR_Click);
            // 
            // BtnXOR
            // 
            this.BtnXOR.BackColor = System.Drawing.Color.Maroon;
            this.BtnXOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXOR.ForeColor = System.Drawing.Color.Black;
            this.BtnXOR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXOR.ImageIndex = 0;
            this.BtnXOR.Location = new System.Drawing.Point(505, 27);
            this.BtnXOR.Name = "BtnXOR";
            this.BtnXOR.Size = new System.Drawing.Size(204, 160);
            this.BtnXOR.TabIndex = 4;
            this.BtnXOR.Text = "XOR";
            this.BtnXOR.UseVisualStyleBackColor = false;
            this.BtnXOR.Click += new System.EventHandler(this.BtnXOR_Click);
            // 
            // BtnNOT
            // 
            this.BtnNOT.BackColor = System.Drawing.Color.Maroon;
            this.BtnNOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNOT.ForeColor = System.Drawing.Color.Black;
            this.BtnNOT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNOT.ImageIndex = 0;
            this.BtnNOT.Location = new System.Drawing.Point(733, 27);
            this.BtnNOT.Name = "BtnNOT";
            this.BtnNOT.Size = new System.Drawing.Size(204, 160);
            this.BtnNOT.TabIndex = 5;
            this.BtnNOT.Text = "NOT";
            this.BtnNOT.UseVisualStyleBackColor = false;
            this.BtnNOT.Click += new System.EventHandler(this.BtnNOT_Click);
            // 
            // BtnXNOR
            // 
            this.BtnXNOR.BackColor = System.Drawing.Color.Maroon;
            this.BtnXNOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXNOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXNOR.ForeColor = System.Drawing.Color.Black;
            this.BtnXNOR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXNOR.ImageIndex = 0;
            this.BtnXNOR.Location = new System.Drawing.Point(505, 213);
            this.BtnXNOR.Name = "BtnXNOR";
            this.BtnXNOR.Size = new System.Drawing.Size(204, 160);
            this.BtnXNOR.TabIndex = 8;
            this.BtnXNOR.Text = "XNOR";
            this.BtnXNOR.UseVisualStyleBackColor = false;
            this.BtnXNOR.Click += new System.EventHandler(this.BtnXNOR_Click);
            // 
            // BtnNOR
            // 
            this.BtnNOR.BackColor = System.Drawing.Color.Maroon;
            this.BtnNOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNOR.ForeColor = System.Drawing.Color.Black;
            this.BtnNOR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNOR.ImageIndex = 0;
            this.BtnNOR.Location = new System.Drawing.Point(279, 213);
            this.BtnNOR.Name = "BtnNOR";
            this.BtnNOR.Size = new System.Drawing.Size(204, 160);
            this.BtnNOR.TabIndex = 7;
            this.BtnNOR.Text = "NOR";
            this.BtnNOR.UseVisualStyleBackColor = false;
            this.BtnNOR.Click += new System.EventHandler(this.BtnNOR_Click);
            // 
            // BtnNAND
            // 
            this.BtnNAND.BackColor = System.Drawing.Color.Maroon;
            this.BtnNAND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNAND.ForeColor = System.Drawing.Color.Black;
            this.BtnNAND.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNAND.ImageIndex = 0;
            this.BtnNAND.Location = new System.Drawing.Point(39, 213);
            this.BtnNAND.Name = "BtnNAND";
            this.BtnNAND.Size = new System.Drawing.Size(204, 160);
            this.BtnNAND.TabIndex = 6;
            this.BtnNAND.Text = "NAND";
            this.BtnNAND.UseVisualStyleBackColor = false;
            this.BtnNAND.Click += new System.EventHandler(this.BtnNAND_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.ImageIndex = 1;
            this.BtnExit.ImageList = this.imageList1;
            this.BtnExit.Location = new System.Drawing.Point(774, 312);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(135, 45);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.White;
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbout.ImageIndex = 0;
            this.BtnAbout.ImageList = this.imageList1;
            this.BtnAbout.Location = new System.Drawing.Point(774, 236);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(135, 45);
            this.BtnAbout.TabIndex = 0;
            this.BtnAbout.Text = "About";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // LogicGates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(973, 397);
            this.Controls.Add(this.BtnXNOR);
            this.Controls.Add(this.BtnNOR);
            this.Controls.Add(this.BtnNAND);
            this.Controls.Add(this.BtnNOT);
            this.Controls.Add(this.BtnXOR);
            this.Controls.Add(this.BtnOR);
            this.Controls.Add(this.BtnAND);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAbout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "LogicGates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logic Gates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAND;
        private System.Windows.Forms.Button BtnOR;
        private System.Windows.Forms.Button BtnXOR;
        private System.Windows.Forms.Button BtnNOT;
        private System.Windows.Forms.Button BtnXNOR;
        private System.Windows.Forms.Button BtnNOR;
        private System.Windows.Forms.Button BtnNAND;
    }
}