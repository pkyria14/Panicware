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
            System.Windows.Forms.CheckedListBox checkboxEncryptions;
            System.Windows.Forms.PictureBox cook_encryptions;
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.OptionsPanelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanelForLaterUsage = new System.Windows.Forms.Panel();
            this.EncryptedOutputBox = new System.Windows.Forms.RichTextBox();
            this.PlaintextInputBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.btncook = new System.Windows.Forms.Button();
            checkboxEncryptions = new System.Windows.Forms.CheckedListBox();
            cook_encryptions = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(cook_encryptions)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.OptionsPanelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.imgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxEncryptions
            // 
            checkboxEncryptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            checkboxEncryptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            checkboxEncryptions.Cursor = System.Windows.Forms.Cursors.Arrow;
            checkboxEncryptions.Dock = System.Windows.Forms.DockStyle.Left;
            checkboxEncryptions.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkboxEncryptions.ForeColor = System.Drawing.Color.White;
            checkboxEncryptions.FormattingEnabled = true;
            checkboxEncryptions.Items.AddRange(new object[] {
            "Base64",
            "XOR",
            "AES256",
            "RC4"});
            checkboxEncryptions.Location = new System.Drawing.Point(0, 0);
            checkboxEncryptions.Name = "checkboxEncryptions";
            checkboxEncryptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            checkboxEncryptions.Size = new System.Drawing.Size(120, 312);
            checkboxEncryptions.TabIndex = 0;
            // 
            // cook_encryptions
            // 
            cook_encryptions.Image = global::PanicWareGui.Properties.Resources.cooking;
            cook_encryptions.Location = new System.Drawing.Point(0, 0);
            cook_encryptions.Name = "cook_encryptions";
            cook_encryptions.Size = new System.Drawing.Size(192, 100);
            cook_encryptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            cook_encryptions.TabIndex = 4;
            cook_encryptions.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblOutput);
            this.panelTop.Controls.Add(this.lblInput);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(918, 100);
            this.panelTop.TabIndex = 0;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(632, 73);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 24);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(237, 73);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(62, 24);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input";
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
            // panelLeft
            // 
            this.panelLeft.Controls.Add(checkboxEncryptions);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(165, 312);
            this.panelLeft.TabIndex = 2;
            // 
            // OptionsPanelBottom
            // 
            this.OptionsPanelBottom.Controls.Add(this.label1);
            this.OptionsPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPanelBottom.Location = new System.Drawing.Point(165, 262);
            this.OptionsPanelBottom.Name = "OptionsPanelBottom";
            this.OptionsPanelBottom.Size = new System.Drawing.Size(605, 150);
            this.OptionsPanelBottom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // RightPanelForLaterUsage
            // 
            this.RightPanelForLaterUsage.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanelForLaterUsage.Location = new System.Drawing.Point(770, 100);
            this.RightPanelForLaterUsage.Name = "RightPanelForLaterUsage";
            this.RightPanelForLaterUsage.Size = new System.Drawing.Size(148, 312);
            this.RightPanelForLaterUsage.TabIndex = 5;
            // 
            // EncryptedOutputBox
            // 
            this.EncryptedOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.EncryptedOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncryptedOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptedOutputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedOutputBox.ForeColor = System.Drawing.Color.White;
            this.EncryptedOutputBox.Location = new System.Drawing.Point(405, 3);
            this.EncryptedOutputBox.Name = "EncryptedOutputBox";
            this.EncryptedOutputBox.Size = new System.Drawing.Size(197, 156);
            this.EncryptedOutputBox.TabIndex = 1;
            this.EncryptedOutputBox.Text = "";
            // 
            // PlaintextInputBox
            // 
            this.PlaintextInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PlaintextInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaintextInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaintextInputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PlaintextInputBox.ForeColor = System.Drawing.Color.White;
            this.PlaintextInputBox.Location = new System.Drawing.Point(3, 3);
            this.PlaintextInputBox.Name = "PlaintextInputBox";
            this.PlaintextInputBox.Size = new System.Drawing.Size(195, 156);
            this.PlaintextInputBox.TabIndex = 0;
            this.PlaintextInputBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.PlaintextInputBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EncryptedOutputBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(165, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 162);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // imgPanel
            // 
            this.imgPanel.Controls.Add(this.btncook);
            this.imgPanel.Controls.Add(cook_encryptions);
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPanel.Location = new System.Drawing.Point(204, 3);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(195, 156);
            this.imgPanel.TabIndex = 2;
            // 
            // btncook
            // 
            this.btncook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncook.Location = new System.Drawing.Point(0, 106);
            this.btncook.Name = "btncook";
            this.btncook.Size = new System.Drawing.Size(195, 50);
            this.btncook.TabIndex = 5;
            this.btncook.Text = "Cook";
            this.btncook.UseVisualStyleBackColor = true;
            this.btncook.Click += new System.EventHandler(this.btncook_Click);
            // 
            // FormEncryptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
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
            this.OptionsPanelBottom.ResumeLayout(false);
            this.OptionsPanelBottom.PerformLayout();
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
        private System.Windows.Forms.RichTextBox EncryptedOutputBox;
        private System.Windows.Forms.RichTextBox PlaintextInputBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btncook;
    }
}