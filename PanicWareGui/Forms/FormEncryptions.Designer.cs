namespace PanicWareGui.Forms
{
    partial class FormEncryptions
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
            System.Windows.Forms.PictureBox cook_encryptions;
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.radioEkko = new System.Windows.Forms.RadioButton();
            this.radioRc4 = new System.Windows.Forms.RadioButton();
            this.radioBase64 = new System.Windows.Forms.RadioButton();
            this.radioAes256 = new System.Windows.Forms.RadioButton();
            this.radioXor = new System.Windows.Forms.RadioButton();
            this.OptionsPanelBottom = new System.Windows.Forms.Panel();
            this.file_to_encrypt_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioElf = new System.Windows.Forms.RadioButton();
            this.radioRaw = new System.Windows.Forms.RadioButton();
            this.radioExe = new System.Windows.Forms.RadioButton();
            this.radioDll = new System.Windows.Forms.RadioButton();
            this.RightPanelForLaterUsage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.btncook = new System.Windows.Forms.Button();
            this.EncryptedOutputBox = new System.Windows.Forms.RichTextBox();
            this.PlaintextInputBox = new System.Windows.Forms.RichTextBox();
            cook_encryptions = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(cook_encryptions)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.OptionsPanelBottom.SuspendLayout();
            this.RightPanelForLaterUsage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.imgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cook_encryptions
            // 
            cook_encryptions.Dock = System.Windows.Forms.DockStyle.Top;
            cook_encryptions.Image = global::PanicWareGui.Properties.Resources.cooking;
            cook_encryptions.Location = new System.Drawing.Point(0, 0);
            cook_encryptions.Name = "cook_encryptions";
            cook_encryptions.Size = new System.Drawing.Size(204, 141);
            cook_encryptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            cook_encryptions.TabIndex = 4;
            cook_encryptions.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.lblOutput);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(918, 100);
            this.panelTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Algorithm";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(729, 58);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(186, 30);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output Format";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(385, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 39);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Encryption";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(83, 13);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(62, 24);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.radioEkko);
            this.panelLeft.Controls.Add(this.radioRc4);
            this.panelLeft.Controls.Add(this.radioBase64);
            this.panelLeft.Controls.Add(this.radioAes256);
            this.panelLeft.Controls.Add(this.radioXor);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(140, 312);
            this.panelLeft.TabIndex = 2;
            // 
            // radioEkko
            // 
            this.radioEkko.AutoSize = true;
            this.radioEkko.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioEkko.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioEkko.ForeColor = System.Drawing.Color.White;
            this.radioEkko.Location = new System.Drawing.Point(0, 100);
            this.radioEkko.Name = "radioEkko";
            this.radioEkko.Size = new System.Drawing.Size(140, 25);
            this.radioEkko.TabIndex = 11;
            this.radioEkko.TabStop = true;
            this.radioEkko.Text = "Ekko";
            this.radioEkko.UseVisualStyleBackColor = true;
            // 
            // radioRc4
            // 
            this.radioRc4.AutoSize = true;
            this.radioRc4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioRc4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioRc4.ForeColor = System.Drawing.Color.White;
            this.radioRc4.Location = new System.Drawing.Point(0, 75);
            this.radioRc4.Name = "radioRc4";
            this.radioRc4.Size = new System.Drawing.Size(140, 25);
            this.radioRc4.TabIndex = 10;
            this.radioRc4.TabStop = true;
            this.radioRc4.Text = "RC4";
            this.radioRc4.UseVisualStyleBackColor = true;
            // 
            // radioBase64
            // 
            this.radioBase64.AutoSize = true;
            this.radioBase64.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBase64.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioBase64.ForeColor = System.Drawing.Color.White;
            this.radioBase64.Location = new System.Drawing.Point(0, 50);
            this.radioBase64.Name = "radioBase64";
            this.radioBase64.Size = new System.Drawing.Size(140, 25);
            this.radioBase64.TabIndex = 7;
            this.radioBase64.TabStop = true;
            this.radioBase64.Text = "Base64";
            this.radioBase64.UseVisualStyleBackColor = true;
            // 
            // radioAes256
            // 
            this.radioAes256.AutoSize = true;
            this.radioAes256.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAes256.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioAes256.ForeColor = System.Drawing.Color.White;
            this.radioAes256.Location = new System.Drawing.Point(0, 25);
            this.radioAes256.Name = "radioAes256";
            this.radioAes256.Size = new System.Drawing.Size(140, 25);
            this.radioAes256.TabIndex = 9;
            this.radioAes256.TabStop = true;
            this.radioAes256.Text = "AES256";
            this.radioAes256.UseVisualStyleBackColor = true;
            // 
            // radioXor
            // 
            this.radioXor.AutoSize = true;
            this.radioXor.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioXor.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioXor.ForeColor = System.Drawing.Color.White;
            this.radioXor.Location = new System.Drawing.Point(0, 0);
            this.radioXor.Name = "radioXor";
            this.radioXor.Size = new System.Drawing.Size(140, 25);
            this.radioXor.TabIndex = 8;
            this.radioXor.TabStop = true;
            this.radioXor.Text = "XOR";
            this.radioXor.UseVisualStyleBackColor = true;
            // 
            // OptionsPanelBottom
            // 
            this.OptionsPanelBottom.Controls.Add(this.file_to_encrypt_button);
            this.OptionsPanelBottom.Controls.Add(this.lblInput);
            this.OptionsPanelBottom.Controls.Add(this.label1);
            this.OptionsPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPanelBottom.Location = new System.Drawing.Point(140, 262);
            this.OptionsPanelBottom.Name = "OptionsPanelBottom";
            this.OptionsPanelBottom.Size = new System.Drawing.Size(630, 150);
            this.OptionsPanelBottom.TabIndex = 4;
            // 
            // file_to_encrypt_button
            // 
            this.file_to_encrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.file_to_encrypt_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file_to_encrypt_button.FlatAppearance.BorderSize = 0;
            this.file_to_encrypt_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_to_encrypt_button.ForeColor = System.Drawing.Color.White;
            this.file_to_encrypt_button.Image = global::PanicWareGui.Properties.Resources.transparent;
            this.file_to_encrypt_button.Location = new System.Drawing.Point(17, 51);
            this.file_to_encrypt_button.Name = "file_to_encrypt_button";
            this.file_to_encrypt_button.Size = new System.Drawing.Size(196, 50);
            this.file_to_encrypt_button.TabIndex = 6;
            this.file_to_encrypt_button.Text = "file to encrypt";
            this.file_to_encrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.file_to_encrypt_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.file_to_encrypt_button.UseVisualStyleBackColor = false;
            this.file_to_encrypt_button.Click += new System.EventHandler(this.btn_file_to_encrypt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // radioElf
            // 
            this.radioElf.AutoSize = true;
            this.radioElf.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioElf.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioElf.ForeColor = System.Drawing.Color.White;
            this.radioElf.Location = new System.Drawing.Point(0, 75);
            this.radioElf.Name = "radioElf";
            this.radioElf.Size = new System.Drawing.Size(148, 25);
            this.radioElf.TabIndex = 12;
            this.radioElf.TabStop = true;
            this.radioElf.Text = "elf";
            this.radioElf.UseVisualStyleBackColor = true;
            // 
            // radioRaw
            // 
            this.radioRaw.AutoSize = true;
            this.radioRaw.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioRaw.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioRaw.ForeColor = System.Drawing.Color.White;
            this.radioRaw.Location = new System.Drawing.Point(0, 0);
            this.radioRaw.Name = "radioRaw";
            this.radioRaw.Size = new System.Drawing.Size(148, 25);
            this.radioRaw.TabIndex = 9;
            this.radioRaw.TabStop = true;
            this.radioRaw.Text = "raw";
            this.radioRaw.UseVisualStyleBackColor = true;
            // 
            // radioExe
            // 
            this.radioExe.AutoSize = true;
            this.radioExe.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioExe.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioExe.ForeColor = System.Drawing.Color.White;
            this.radioExe.Location = new System.Drawing.Point(0, 25);
            this.radioExe.Name = "radioExe";
            this.radioExe.Size = new System.Drawing.Size(148, 25);
            this.radioExe.TabIndex = 8;
            this.radioExe.TabStop = true;
            this.radioExe.Text = "exe";
            this.radioExe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioExe.UseVisualStyleBackColor = true;
            // 
            // radioDll
            // 
            this.radioDll.AutoSize = true;
            this.radioDll.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioDll.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.radioDll.ForeColor = System.Drawing.Color.White;
            this.radioDll.Location = new System.Drawing.Point(0, 50);
            this.radioDll.Name = "radioDll";
            this.radioDll.Size = new System.Drawing.Size(148, 25);
            this.radioDll.TabIndex = 7;
            this.radioDll.TabStop = true;
            this.radioDll.Text = "dll";
            this.radioDll.UseVisualStyleBackColor = true;
            // 
            // RightPanelForLaterUsage
            // 
            this.RightPanelForLaterUsage.Controls.Add(this.radioElf);
            this.RightPanelForLaterUsage.Controls.Add(this.radioDll);
            this.RightPanelForLaterUsage.Controls.Add(this.radioExe);
            this.RightPanelForLaterUsage.Controls.Add(this.radioRaw);
            this.RightPanelForLaterUsage.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanelForLaterUsage.Location = new System.Drawing.Point(770, 100);
            this.RightPanelForLaterUsage.Name = "RightPanelForLaterUsage";
            this.RightPanelForLaterUsage.Size = new System.Drawing.Size(148, 312);
            this.RightPanelForLaterUsage.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.EncryptedOutputBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlaintextInputBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(140, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 162);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // imgPanel
            // 
            this.imgPanel.Controls.Add(this.btncook);
            this.imgPanel.Controls.Add(cook_encryptions);
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPanel.Location = new System.Drawing.Point(213, 3);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(204, 156);
            this.imgPanel.TabIndex = 2;
            // 
            // btncook
            // 
            this.btncook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btncook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncook.FlatAppearance.BorderSize = 0;
            this.btncook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncook.ForeColor = System.Drawing.Color.White;
            this.btncook.Image = global::PanicWareGui.Properties.Resources.transparent;
            this.btncook.Location = new System.Drawing.Point(0, 106);
            this.btncook.Name = "btncook";
            this.btncook.Size = new System.Drawing.Size(204, 50);
            this.btncook.TabIndex = 5;
            this.btncook.Text = "Cook";
            this.btncook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncook.UseVisualStyleBackColor = false;
            this.btncook.Click += new System.EventHandler(this.btncook_Click);
            // 
            // EncryptedOutputBox
            // 
            this.EncryptedOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.EncryptedOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncryptedOutputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedOutputBox.ForeColor = System.Drawing.Color.White;
            this.EncryptedOutputBox.Location = new System.Drawing.Point(423, 3);
            this.EncryptedOutputBox.Name = "EncryptedOutputBox";
            this.EncryptedOutputBox.Size = new System.Drawing.Size(78, 62);
            this.EncryptedOutputBox.TabIndex = 1;
            this.EncryptedOutputBox.Text = "";
            // 
            // PlaintextInputBox
            // 
            this.PlaintextInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PlaintextInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaintextInputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PlaintextInputBox.ForeColor = System.Drawing.Color.White;
            this.PlaintextInputBox.Location = new System.Drawing.Point(3, 3);
            this.PlaintextInputBox.Name = "PlaintextInputBox";
            this.PlaintextInputBox.Size = new System.Drawing.Size(83, 72);
            this.PlaintextInputBox.TabIndex = 0;
            this.PlaintextInputBox.Text = "";
            // 
            // FormEncryptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(918, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OptionsPanelBottom);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.RightPanelForLaterUsage);
            this.Controls.Add(this.panelTop);
            this.Name = "FormEncryptions";
            this.Text = "FormEncryptions";
            ((System.ComponentModel.ISupportInitialize)(cook_encryptions)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.OptionsPanelBottom.ResumeLayout(false);
            this.OptionsPanelBottom.PerformLayout();
            this.RightPanelForLaterUsage.ResumeLayout(false);
            this.RightPanelForLaterUsage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.imgPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel OptionsPanelBottom;
        private System.Windows.Forms.Panel RightPanelForLaterUsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.Button btncook;
        private System.Windows.Forms.Button file_to_encrypt_button;
        private System.Windows.Forms.RadioButton radioAes256;
        private System.Windows.Forms.RadioButton radioXor;
        private System.Windows.Forms.RadioButton radioBase64;
        private System.Windows.Forms.RadioButton radioRc4;
        private System.Windows.Forms.RadioButton radioElf;
        private System.Windows.Forms.RadioButton radioRaw;
        private System.Windows.Forms.RadioButton radioExe;
        private System.Windows.Forms.RadioButton radioDll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioEkko;
        private System.Windows.Forms.RichTextBox EncryptedOutputBox;
        private System.Windows.Forms.RichTextBox PlaintextInputBox;
    }
}