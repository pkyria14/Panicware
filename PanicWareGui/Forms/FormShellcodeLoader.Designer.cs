namespace PanicWareGui.Forms
{
    partial class FormShellcodeLoader
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cookbutton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // cookbutton
            // 
            this.cookbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cookbutton.IconColor = System.Drawing.Color.Black;
            this.cookbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cookbutton.Location = new System.Drawing.Point(291, 193);
            this.cookbutton.Name = "cookbutton";
            this.cookbutton.Size = new System.Drawing.Size(75, 23);
            this.cookbutton.TabIndex = 1;
            this.cookbutton.Text = "cookbutton";
            this.cookbutton.UseVisualStyleBackColor = true;
            this.cookbutton.Click += new System.EventHandler(this.cookbutton_Click);
            // 
            // FormShellcodeLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cookbutton);
            this.Controls.Add(this.panel1);
            this.Name = "FormShellcodeLoader";
            this.Text = "FormShellcodeLoader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton cookbutton;
    }
}