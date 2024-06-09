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
            this.HostFilesbtn = new System.Windows.Forms.Button();
            this.RunDropperbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostFilesbtn
            // 
            this.HostFilesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HostFilesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostFilesbtn.FlatAppearance.BorderSize = 0;
            this.HostFilesbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostFilesbtn.ForeColor = System.Drawing.Color.White;
            this.HostFilesbtn.Image = global::PanicWareGui.Properties.Resources.transparent;
            this.HostFilesbtn.Location = new System.Drawing.Point(77, 217);
            this.HostFilesbtn.Name = "HostFilesbtn";
            this.HostFilesbtn.Size = new System.Drawing.Size(196, 50);
            this.HostFilesbtn.TabIndex = 7;
            this.HostFilesbtn.Text = "Host Payload";
            this.HostFilesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HostFilesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HostFilesbtn.UseVisualStyleBackColor = false;
            this.HostFilesbtn.Click += new System.EventHandler(this.HostFilesbtn_Click);
            // 
            // RunDropperbtn
            // 
            this.RunDropperbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.RunDropperbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunDropperbtn.FlatAppearance.BorderSize = 0;
            this.RunDropperbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunDropperbtn.ForeColor = System.Drawing.Color.White;
            this.RunDropperbtn.Image = global::PanicWareGui.Properties.Resources.transparent;
            this.RunDropperbtn.Location = new System.Drawing.Point(485, 217);
            this.RunDropperbtn.Name = "RunDropperbtn";
            this.RunDropperbtn.Size = new System.Drawing.Size(196, 50);
            this.RunDropperbtn.TabIndex = 8;
            this.RunDropperbtn.Text = "Dropper";
            this.RunDropperbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunDropperbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RunDropperbtn.UseVisualStyleBackColor = false;
            this.RunDropperbtn.Click += new System.EventHandler(this.RunDropperbtn_Click);
            // 
            // FormDropper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunDropperbtn);
            this.Controls.Add(this.HostFilesbtn);
            this.Name = "FormDropper";
            this.Text = "Dropper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HostFilesbtn;
        private System.Windows.Forms.Button RunDropperbtn;
    }
}