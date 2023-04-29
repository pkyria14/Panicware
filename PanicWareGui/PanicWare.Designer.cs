﻿namespace PanicWareGui
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.UnderLogo = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.buttonLayoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new FontAwesome.Sharp.IconButton();
            this.button5 = new FontAwesome.Sharp.IconButton();
            this.button4 = new FontAwesome.Sharp.IconButton();
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.buttonLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new FontAwesome.Sharp.IconButton();
            this.button2 = new FontAwesome.Sharp.IconButton();
            this.button1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenuRight.SuspendLayout();
            this.buttonLayoutRight.SuspendLayout();
            this.panelMenuLeft.SuspendLayout();
            this.buttonLayoutLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::PanicWareGui.Properties.Resources.transparent;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.UnderLogo);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.panelMenuRight);
            this.panelMenu.Controls.Add(this.panelMenuLeft);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(934, 100);
            this.panelMenu.TabIndex = 1;
            // 
            // UnderLogo
            // 
            this.UnderLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.UnderLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnderLogo.Location = new System.Drawing.Point(437, 60);
            this.UnderLogo.Name = "UnderLogo";
            this.UnderLogo.Size = new System.Drawing.Size(60, 40);
            this.UnderLogo.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(437, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(60, 60);
            this.panelLogo.TabIndex = 3;
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelMenuRight.Controls.Add(this.buttonLayoutRight);
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(497, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(437, 100);
            this.panelMenuRight.TabIndex = 3;
            // 
            // buttonLayoutRight
            // 
            this.buttonLayoutRight.ColumnCount = 3;
            this.buttonLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutRight.Controls.Add(this.button6, 0, 0);
            this.buttonLayoutRight.Controls.Add(this.button5, 0, 0);
            this.buttonLayoutRight.Controls.Add(this.button4, 0, 0);
            this.buttonLayoutRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutRight.Location = new System.Drawing.Point(0, 60);
            this.buttonLayoutRight.Name = "buttonLayoutRight";
            this.buttonLayoutRight.RowCount = 1;
            this.buttonLayoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayoutRight.Size = new System.Drawing.Size(437, 40);
            this.buttonLayoutRight.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.button6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button6.IconSize = 20;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(293, 3);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(141, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Coming Soon";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.button5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button5.IconSize = 20;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(148, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(139, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Stomper";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.button4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button4.IconSize = 20;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(139, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Obfuscator";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelMenuLeft.Controls.Add(this.buttonLayoutLeft);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(437, 100);
            this.panelMenuLeft.TabIndex = 2;
            // 
            // buttonLayoutLeft
            // 
            this.buttonLayoutLeft.ColumnCount = 3;
            this.buttonLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutLeft.Controls.Add(this.button3, 2, 0);
            this.buttonLayoutLeft.Controls.Add(this.button2, 1, 0);
            this.buttonLayoutLeft.Controls.Add(this.button1, 0, 0);
            this.buttonLayoutLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutLeft.Location = new System.Drawing.Point(0, 60);
            this.buttonLayoutLeft.Name = "buttonLayoutLeft";
            this.buttonLayoutLeft.RowCount = 1;
            this.buttonLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonLayoutLeft.Size = new System.Drawing.Size(437, 40);
            this.buttonLayoutLeft.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.button3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button3.IconSize = 20;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(293, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(141, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dropper";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.button2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button2.IconSize = 20;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(148, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(139, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Loader";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.button1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button1.IconSize = 20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encryptions";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PanicWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanicWare";
            this.Text = "PanicWare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelMenuRight.ResumeLayout(false);
            this.buttonLayoutRight.ResumeLayout(false);
            this.panelMenuLeft.ResumeLayout(false);
            this.buttonLayoutLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.Panel panelMenuLeft;
        private FontAwesome.Sharp.IconButton button1;
        private System.Windows.Forms.Panel UnderLogo;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutRight;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutLeft;
        private FontAwesome.Sharp.IconButton button6;
        private FontAwesome.Sharp.IconButton button5;
        private FontAwesome.Sharp.IconButton button4;
        private FontAwesome.Sharp.IconButton button3;
        private FontAwesome.Sharp.IconButton button2;
    }
}
