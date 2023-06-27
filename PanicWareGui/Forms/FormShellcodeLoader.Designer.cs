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
            this.cookbutton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cookbutton
            // 
            this.cookbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cookbutton.IconColor = System.Drawing.Color.Black;
            this.cookbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cookbutton.Location = new System.Drawing.Point(313, 182);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cookbutton);
            this.Name = "FormShellcodeLoader";
            this.Text = "FormShellcodeLoader";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton cookbutton;
    }
}