﻿namespace AMSExplorer
{
    partial class ConfigureTelemetry
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeleteConfig = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            this.labelTelemetryUI = new System.Windows.Forms.Label();
            this.comboBoxLevelChannel = new System.Windows.Forms.ComboBox();
            this.comboBoxLevelSE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTableURL = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPreview = new System.Windows.Forms.Label();
            this.labelProcessorVersion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(273, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 27);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(151, 15);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(115, 27);
            this.buttonOk.TabIndex = 17;
            this.buttonOk.Text = "Configure";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonDeleteConfig);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Location = new System.Drawing.Point(-2, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 55);
            this.panel1.TabIndex = 66;
            // 
            // buttonDeleteConfig
            // 
            this.buttonDeleteConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteConfig.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonDeleteConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteConfig.Location = new System.Drawing.Point(14, 15);
            this.buttonDeleteConfig.Name = "buttonDeleteConfig";
            this.buttonDeleteConfig.Size = new System.Drawing.Size(115, 27);
            this.buttonDeleteConfig.TabIndex = 18;
            this.buttonDeleteConfig.Text = "Delete config";
            this.buttonDeleteConfig.UseVisualStyleBackColor = true;
            this.buttonDeleteConfig.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(42, 76);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(196, 15);
            this.label33.TabIndex = 70;
            this.label33.Text = "Storage account to store the tables :";
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(43, 94);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(292, 23);
            this.comboBoxStorage.TabIndex = 69;
            // 
            // labelTelemetryUI
            // 
            this.labelTelemetryUI.AutoSize = true;
            this.labelTelemetryUI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelemetryUI.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTelemetryUI.Location = new System.Drawing.Point(12, 9);
            this.labelTelemetryUI.Name = "labelTelemetryUI";
            this.labelTelemetryUI.Size = new System.Drawing.Size(165, 20);
            this.labelTelemetryUI.TabIndex = 75;
            this.labelTelemetryUI.Text = "New Telemetry Settings";
            // 
            // comboBoxLevelChannel
            // 
            this.comboBoxLevelChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevelChannel.FormattingEnabled = true;
            this.comboBoxLevelChannel.Location = new System.Drawing.Point(218, 163);
            this.comboBoxLevelChannel.Name = "comboBoxLevelChannel";
            this.comboBoxLevelChannel.Size = new System.Drawing.Size(117, 23);
            this.comboBoxLevelChannel.TabIndex = 77;
            // 
            // comboBoxLevelSE
            // 
            this.comboBoxLevelSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevelSE.FormattingEnabled = true;
            this.comboBoxLevelSE.Location = new System.Drawing.Point(218, 199);
            this.comboBoxLevelSE.Name = "comboBoxLevelSE";
            this.comboBoxLevelSE.Size = new System.Drawing.Size(117, 23);
            this.comboBoxLevelSE.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Details level";
            // 
            // textBoxTableURL
            // 
            this.textBoxTableURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTableURL.Location = new System.Drawing.Point(45, 94);
            this.textBoxTableURL.Name = "textBoxTableURL";
            this.textBoxTableURL.ReadOnly = true;
            this.textBoxTableURL.Size = new System.Drawing.Size(292, 23);
            this.textBoxTableURL.TabIndex = 80;
            this.textBoxTableURL.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Channels :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "Streaming endpoints :";
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(128)))), ((int)(((byte)(171)))));
            this.labelPreview.Location = new System.Drawing.Point(280, 9);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(108, 20);
            this.labelPreview.TabIndex = 83;
            this.labelPreview.Text = "Private Preview";
            this.labelPreview.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelProcessorVersion
            // 
            this.labelProcessorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessorVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(128)))), ((int)(((byte)(171)))));
            this.labelProcessorVersion.Location = new System.Drawing.Point(218, 34);
            this.labelProcessorVersion.Name = "labelProcessorVersion";
            this.labelProcessorVersion.Size = new System.Drawing.Size(168, 34);
            this.labelProcessorVersion.TabIndex = 84;
            this.labelProcessorVersion.Text = "For selected customers only";
            this.labelProcessorVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConfigureTelemetry
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(400, 328);
            this.Controls.Add(this.labelProcessorVersion);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLevelSE);
            this.Controls.Add(this.comboBoxLevelChannel);
            this.Controls.Add(this.labelTelemetryUI);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.comboBoxStorage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTableURL);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ConfigureTelemetry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Telemetry";
            this.Load += new System.EventHandler(this.ConfigureTelemetry_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBoxStorage;
        private System.Windows.Forms.Label labelTelemetryUI;
        private System.Windows.Forms.ComboBox comboBoxLevelChannel;
        private System.Windows.Forms.ComboBox comboBoxLevelSE;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonDeleteConfig;
        private System.Windows.Forms.TextBox textBoxTableURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Label labelProcessorVersion;
    }
}