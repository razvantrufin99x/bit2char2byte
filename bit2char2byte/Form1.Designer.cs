namespace bit2char2byte
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
            this.bytecontrol1 = new bit2char2byte.bytecontrol();
            this.SuspendLayout();
            // 
            // bytecontrol1
            // 
            this.bytecontrol1.BackColor = System.Drawing.Color.White;
            this.bytecontrol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytecontrol1.Location = new System.Drawing.Point(12, 9);
            this.bytecontrol1.Name = "bytecontrol1";
            this.bytecontrol1.Size = new System.Drawing.Size(451, 41);
            this.bytecontrol1.TabIndex = 0;
            this.bytecontrol1.Load += new System.EventHandler(this.bytecontrol1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 62);
            this.Controls.Add(this.bytecontrol1);
            this.Name = "Form1";
            this.Text = "ascii code 2 char ascii byte";
            this.ResumeLayout(false);

        }

        #endregion

        private bytecontrol bytecontrol1;
    }
}

