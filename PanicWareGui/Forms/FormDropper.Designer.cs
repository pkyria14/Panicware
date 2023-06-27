namespace PanicWareGui.Forms
{
    partial class FormDropper
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
            this.RunDropperbtn = new FontAwesome.Sharp.IconButton();
            this.HostFilesbtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // RunDropperbtn
            // 
            this.RunDropperbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunDropperbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.RunDropperbtn.IconColor = System.Drawing.Color.Black;
            this.RunDropperbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RunDropperbtn.Location = new System.Drawing.Point(497, 206);
            this.RunDropperbtn.Name = "RunDropperbtn";
            this.RunDropperbtn.Size = new System.Drawing.Size(106, 27);
            this.RunDropperbtn.TabIndex = 0;
            this.RunDropperbtn.Text = "Dropper";
            this.RunDropperbtn.UseVisualStyleBackColor = true;
            this.RunDropperbtn.Click += new System.EventHandler(this.RunDropperbtn_Click);
            // 
            // HostFilesbtn
            // 
            this.HostFilesbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.HostFilesbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.HostFilesbtn.IconColor = System.Drawing.Color.Black;
            this.HostFilesbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HostFilesbtn.Location = new System.Drawing.Point(134, 206);
            this.HostFilesbtn.Name = "HostFilesbtn";
            this.HostFilesbtn.Size = new System.Drawing.Size(112, 27);
            this.HostFilesbtn.TabIndex = 1;
            this.HostFilesbtn.Text = "Host Files";
            this.HostFilesbtn.UseVisualStyleBackColor = true;
            this.HostFilesbtn.Click += new System.EventHandler(this.HostFilesbtn_Click);
            // 
            // FormDropper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HostFilesbtn);
            this.Controls.Add(this.RunDropperbtn);
            this.Name = "FormDropper";
            this.Text = "Dropper";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton RunDropperbtn;
        private FontAwesome.Sharp.IconButton HostFilesbtn;
    }
}