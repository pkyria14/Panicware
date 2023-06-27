namespace PanicWareGui
{
    partial class PanicWare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanicWare));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.UnderLogo = new System.Windows.Forms.Panel();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.buttonLayoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.buttonLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.MoreButton = new FontAwesome.Sharp.IconButton();
            this.StomperButton = new FontAwesome.Sharp.IconButton();
            this.ObfuscatorButton = new FontAwesome.Sharp.IconButton();
            this.DropperButton = new FontAwesome.Sharp.IconButton();
            this.LoaderButton = new FontAwesome.Sharp.IconButton();
            this.encryptionButton = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuRight.SuspendLayout();
            this.buttonLayoutRight.SuspendLayout();
            this.panelMenuLeft.SuspendLayout();
            this.buttonLayoutLeft.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.UnderLogo);
            this.panelMenu.Controls.Add(this.panelMenuRight);
            this.panelMenu.Controls.Add(this.panelMenuLeft);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(934, 100);
            this.panelMenu.TabIndex = 1;
            // 
            // UnderLogo
            // 
            this.UnderLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnderLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.UnderLogo.Location = new System.Drawing.Point(437, 60);
            this.UnderLogo.Name = "UnderLogo";
            this.UnderLogo.Size = new System.Drawing.Size(60, 40);
            this.UnderLogo.TabIndex = 3;
            this.UnderLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelMenuRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelMenuRight.Controls.Add(this.buttonLayoutRight);
            this.panelMenuRight.Location = new System.Drawing.Point(497, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(437, 100);
            this.panelMenuRight.TabIndex = 3;
            this.panelMenuRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonLayoutRight
            // 
            this.buttonLayoutRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonLayoutRight.ColumnCount = 3;
            this.buttonLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutRight.Controls.Add(this.MoreButton, 0, 0);
            this.buttonLayoutRight.Controls.Add(this.StomperButton, 0, 0);
            this.buttonLayoutRight.Controls.Add(this.ObfuscatorButton, 0, 0);
            this.buttonLayoutRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutRight.Location = new System.Drawing.Point(0, 60);
            this.buttonLayoutRight.Name = "buttonLayoutRight";
            this.buttonLayoutRight.RowCount = 1;
            this.buttonLayoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayoutRight.Size = new System.Drawing.Size(437, 40);
            this.buttonLayoutRight.TabIndex = 1;
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelMenuLeft.Controls.Add(this.buttonLayoutLeft);
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(437, 100);
            this.panelMenuLeft.TabIndex = 2;
            this.panelMenuLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonLayoutLeft
            // 
            this.buttonLayoutLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonLayoutLeft.ColumnCount = 3;
            this.buttonLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutLeft.Controls.Add(this.DropperButton, 2, 0);
            this.buttonLayoutLeft.Controls.Add(this.LoaderButton, 1, 0);
            this.buttonLayoutLeft.Controls.Add(this.encryptionButton, 0, 0);
            this.buttonLayoutLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutLeft.Location = new System.Drawing.Point(0, 60);
            this.buttonLayoutLeft.Name = "buttonLayoutLeft";
            this.buttonLayoutLeft.RowCount = 1;
            this.buttonLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.buttonLayoutLeft.Size = new System.Drawing.Size(437, 40);
            this.buttonLayoutLeft.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(934, 60);
            this.panelLogo.TabIndex = 3;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(934, 10);
            this.panelShadow.TabIndex = 2;
            this.panelShadow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // MoreButton
            // 
            this.MoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MoreButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MoreButton.FlatAppearance.BorderSize = 0;
            this.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreButton.ForeColor = System.Drawing.Color.White;
            this.MoreButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.MoreButton.IconColor = System.Drawing.Color.White;
            this.MoreButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MoreButton.IconSize = 20;
            this.MoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoreButton.Location = new System.Drawing.Point(293, 3);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MoreButton.Size = new System.Drawing.Size(141, 34);
            this.MoreButton.TabIndex = 5;
            this.MoreButton.Text = "More";
            this.MoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoreButton.UseVisualStyleBackColor = false;
            this.MoreButton.Click += new System.EventHandler(this.btnmore_click);
            // 
            // StomperButton
            // 
            this.StomperButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.StomperButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StomperButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.StomperButton.FlatAppearance.BorderSize = 0;
            this.StomperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StomperButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StomperButton.ForeColor = System.Drawing.Color.White;
            this.StomperButton.IconChar = FontAwesome.Sharp.IconChar.ShoePrints;
            this.StomperButton.IconColor = System.Drawing.Color.White;
            this.StomperButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StomperButton.IconSize = 20;
            this.StomperButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StomperButton.Location = new System.Drawing.Point(148, 3);
            this.StomperButton.Name = "StomperButton";
            this.StomperButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StomperButton.Size = new System.Drawing.Size(139, 34);
            this.StomperButton.TabIndex = 4;
            this.StomperButton.Text = "Stomper";
            this.StomperButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StomperButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StomperButton.UseVisualStyleBackColor = false;
            this.StomperButton.Click += new System.EventHandler(this.btnstomper_click);
            // 
            // ObfuscatorButton
            // 
            this.ObfuscatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ObfuscatorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObfuscatorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ObfuscatorButton.FlatAppearance.BorderSize = 0;
            this.ObfuscatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObfuscatorButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObfuscatorButton.ForeColor = System.Drawing.Color.White;
            this.ObfuscatorButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ObfuscatorButton.IconColor = System.Drawing.Color.White;
            this.ObfuscatorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ObfuscatorButton.IconSize = 20;
            this.ObfuscatorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ObfuscatorButton.Location = new System.Drawing.Point(3, 3);
            this.ObfuscatorButton.Name = "ObfuscatorButton";
            this.ObfuscatorButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ObfuscatorButton.Size = new System.Drawing.Size(139, 34);
            this.ObfuscatorButton.TabIndex = 3;
            this.ObfuscatorButton.Text = "Obfuscator";
            this.ObfuscatorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ObfuscatorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ObfuscatorButton.UseVisualStyleBackColor = false;
            this.ObfuscatorButton.Click += new System.EventHandler(this.btnobfuscator_click);
            // 
            // DropperButton
            // 
            this.DropperButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.DropperButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropperButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.DropperButton.FlatAppearance.BorderSize = 0;
            this.DropperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropperButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropperButton.ForeColor = System.Drawing.Color.White;
            this.DropperButton.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.DropperButton.IconColor = System.Drawing.Color.White;
            this.DropperButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DropperButton.IconSize = 20;
            this.DropperButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropperButton.Location = new System.Drawing.Point(293, 3);
            this.DropperButton.Name = "DropperButton";
            this.DropperButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DropperButton.Size = new System.Drawing.Size(141, 34);
            this.DropperButton.TabIndex = 4;
            this.DropperButton.Text = "Dropper";
            this.DropperButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropperButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DropperButton.UseVisualStyleBackColor = false;
            this.DropperButton.Click += new System.EventHandler(this.btndropper_click);
            // 
            // LoaderButton
            // 
            this.LoaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.LoaderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.LoaderButton.FlatAppearance.BorderSize = 0;
            this.LoaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaderButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaderButton.ForeColor = System.Drawing.Color.White;
            this.LoaderButton.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.LoaderButton.IconColor = System.Drawing.Color.White;
            this.LoaderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoaderButton.IconSize = 20;
            this.LoaderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoaderButton.Location = new System.Drawing.Point(148, 3);
            this.LoaderButton.Name = "LoaderButton";
            this.LoaderButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LoaderButton.Size = new System.Drawing.Size(139, 34);
            this.LoaderButton.TabIndex = 3;
            this.LoaderButton.Text = "Loader";
            this.LoaderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoaderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoaderButton.UseVisualStyleBackColor = false;
            this.LoaderButton.Click += new System.EventHandler(this.btnshellcodeloader_click);
            // 
            // encryptionButton
            // 
            this.encryptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.encryptionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.encryptionButton.FlatAppearance.BorderSize = 0;
            this.encryptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptionButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionButton.ForeColor = System.Drawing.Color.White;
            this.encryptionButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.encryptionButton.IconColor = System.Drawing.Color.White;
            this.encryptionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.encryptionButton.IconSize = 20;
            this.encryptionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptionButton.Location = new System.Drawing.Point(3, 3);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.encryptionButton.Size = new System.Drawing.Size(139, 34);
            this.encryptionButton.TabIndex = 2;
            this.encryptionButton.Text = "Encryption";
            this.encryptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.encryptionButton.UseVisualStyleBackColor = false;
            this.encryptionButton.Click += new System.EventHandler(this.btnencryptions_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(437, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(421, 26);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(95, 33);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelDesktop.Controls.Add(this.lblTitleChildForm);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(934, 451);
            this.panelDesktop.TabIndex = 3;
            // 
            // PanicWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanicWare";
            this.Text = "PanicWare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuRight.ResumeLayout(false);
            this.buttonLayoutRight.ResumeLayout(false);
            this.panelMenuLeft.ResumeLayout(false);
            this.buttonLayoutLeft.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.Panel panelMenuLeft;
        private FontAwesome.Sharp.IconButton encryptionButton;
        private System.Windows.Forms.Panel UnderLogo;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutRight;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutLeft;
        private FontAwesome.Sharp.IconButton MoreButton;
        private FontAwesome.Sharp.IconButton StomperButton;
        private FontAwesome.Sharp.IconButton ObfuscatorButton;
        private FontAwesome.Sharp.IconButton DropperButton;
        private FontAwesome.Sharp.IconButton LoaderButton;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

