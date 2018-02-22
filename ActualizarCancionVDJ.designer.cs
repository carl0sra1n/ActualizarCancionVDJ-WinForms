namespace ActualizarCancion
{
    partial class ActualizarCancionVDJ
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
            this.PathLabel = new System.Windows.Forms.Label();
            this.FolderInput = new System.Windows.Forms.TextBox();
            this.MonitoringInput = new System.Windows.Forms.CheckBox();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.FileFilterInput = new System.Windows.Forms.TextBox();
            this.FileFilterLabel = new System.Windows.Forms.Label();
            this.ChangeLogList = new System.Windows.Forms.ListBox();
            this.NotificationsGroup = new System.Windows.Forms.GroupBox();
            this.SubfoldersInput = new System.Windows.Forms.CheckBox();
            this.SizeInput = new System.Windows.Forms.CheckBox();
            this.SecurityInput = new System.Windows.Forms.CheckBox();
            this.LastWriteInput = new System.Windows.Forms.CheckBox();
            this.LastAccessInput = new System.Windows.Forms.CheckBox();
            this.FileNameInput = new System.Windows.Forms.CheckBox();
            this.DirectoryNameInput = new System.Windows.Forms.CheckBox();
            this.CreationTimeInput = new System.Windows.Forms.CheckBox();
            this.AttributesInput = new System.Windows.Forms.CheckBox();
            this.BlackWaspLink = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlGroup.SuspendLayout();
            this.NotificationsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(6, 25);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(103, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "&Ruta de VDJ History";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // FolderInput
            // 
            this.FolderInput.Location = new System.Drawing.Point(6, 41);
            this.FolderInput.Name = "FolderInput";
            this.FolderInput.Size = new System.Drawing.Size(144, 20);
            this.FolderInput.TabIndex = 1;
            this.FolderInput.TextChanged += new System.EventHandler(this.FolderInput_TextChanged);
            // 
            // MonitoringInput
            // 
            this.MonitoringInput.AutoSize = true;
            this.MonitoringInput.Location = new System.Drawing.Point(6, 126);
            this.MonitoringInput.Name = "MonitoringInput";
            this.MonitoringInput.Size = new System.Drawing.Size(95, 17);
            this.MonitoringInput.TabIndex = 4;
            this.MonitoringInput.Text = "Iniciar &Servicio";
            this.MonitoringInput.UseVisualStyleBackColor = true;
            this.MonitoringInput.CheckedChanged += new System.EventHandler(this.MonitoringInput_CheckedChanged);
            // 
            // ControlGroup
            // 
            this.ControlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlGroup.Controls.Add(this.FileFilterInput);
            this.ControlGroup.Controls.Add(this.FileFilterLabel);
            this.ControlGroup.Controls.Add(this.PathLabel);
            this.ControlGroup.Controls.Add(this.FolderInput);
            this.ControlGroup.Controls.Add(this.MonitoringInput);
            this.ControlGroup.Location = new System.Drawing.Point(378, 12);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(162, 149);
            this.ControlGroup.TabIndex = 0;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "Parametros";
            this.ControlGroup.Enter += new System.EventHandler(this.ControlGroup_Enter);
            // 
            // FileFilterInput
            // 
            this.FileFilterInput.Enabled = false;
            this.FileFilterInput.Location = new System.Drawing.Point(6, 89);
            this.FileFilterInput.Name = "FileFilterInput";
            this.FileFilterInput.ReadOnly = true;
            this.FileFilterInput.Size = new System.Drawing.Size(144, 20);
            this.FileFilterInput.TabIndex = 3;
            this.FileFilterInput.Text = "*.*";
            // 
            // FileFilterLabel
            // 
            this.FileFilterLabel.AutoSize = true;
            this.FileFilterLabel.Location = new System.Drawing.Point(6, 73);
            this.FileFilterLabel.Name = "FileFilterLabel";
            this.FileFilterLabel.Size = new System.Drawing.Size(105, 13);
            this.FileFilterLabel.TabIndex = 2;
            this.FileFilterLabel.Text = "&Filtros (deshabilitado)";
            // 
            // ChangeLogList
            // 
            this.ChangeLogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLogList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangeLogList.FormattingEnabled = true;
            this.ChangeLogList.IntegralHeight = false;
            this.ChangeLogList.Location = new System.Drawing.Point(12, 85);
            this.ChangeLogList.Name = "ChangeLogList";
            this.ChangeLogList.Size = new System.Drawing.Size(360, 327);
            this.ChangeLogList.TabIndex = 3;
            // 
            // NotificationsGroup
            // 
            this.NotificationsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationsGroup.Controls.Add(this.SubfoldersInput);
            this.NotificationsGroup.Controls.Add(this.SizeInput);
            this.NotificationsGroup.Controls.Add(this.SecurityInput);
            this.NotificationsGroup.Controls.Add(this.LastWriteInput);
            this.NotificationsGroup.Controls.Add(this.LastAccessInput);
            this.NotificationsGroup.Controls.Add(this.FileNameInput);
            this.NotificationsGroup.Controls.Add(this.DirectoryNameInput);
            this.NotificationsGroup.Controls.Add(this.CreationTimeInput);
            this.NotificationsGroup.Controls.Add(this.AttributesInput);
            this.NotificationsGroup.Location = new System.Drawing.Point(378, 167);
            this.NotificationsGroup.Name = "NotificationsGroup";
            this.NotificationsGroup.Size = new System.Drawing.Size(162, 229);
            this.NotificationsGroup.TabIndex = 1;
            this.NotificationsGroup.TabStop = false;
            this.NotificationsGroup.Text = "Parametros Ad. (deshab.)";
            this.NotificationsGroup.Enter += new System.EventHandler(this.NotificationsGroup_Enter);
            // 
            // SubfoldersInput
            // 
            this.SubfoldersInput.AutoSize = true;
            this.SubfoldersInput.Enabled = false;
            this.SubfoldersInput.Location = new System.Drawing.Point(6, 203);
            this.SubfoldersInput.Name = "SubfoldersInput";
            this.SubfoldersInput.Size = new System.Drawing.Size(69, 17);
            this.SubfoldersInput.TabIndex = 8;
            this.SubfoldersInput.Text = "&Duracion";
            this.SubfoldersInput.UseVisualStyleBackColor = true;
            // 
            // SizeInput
            // 
            this.SizeInput.AutoSize = true;
            this.SizeInput.Checked = true;
            this.SizeInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SizeInput.Enabled = false;
            this.SizeInput.Location = new System.Drawing.Point(6, 180);
            this.SizeInput.Name = "SizeInput";
            this.SizeInput.Size = new System.Drawing.Size(47, 17);
            this.SizeInput.TabIndex = 7;
            this.SizeInput.Text = "&Tipo";
            this.SizeInput.UseVisualStyleBackColor = true;
            // 
            // SecurityInput
            // 
            this.SecurityInput.AutoSize = true;
            this.SecurityInput.Checked = true;
            this.SecurityInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecurityInput.Enabled = false;
            this.SecurityInput.Location = new System.Drawing.Point(6, 157);
            this.SecurityInput.Name = "SecurityInput";
            this.SecurityInput.Size = new System.Drawing.Size(61, 17);
            this.SecurityInput.TabIndex = 6;
            this.SecurityInput.Text = "&Genero";
            this.SecurityInput.UseVisualStyleBackColor = true;
            // 
            // LastWriteInput
            // 
            this.LastWriteInput.AutoSize = true;
            this.LastWriteInput.Checked = true;
            this.LastWriteInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastWriteInput.Enabled = false;
            this.LastWriteInput.Location = new System.Drawing.Point(6, 134);
            this.LastWriteInput.Name = "LastWriteInput";
            this.LastWriteInput.Size = new System.Drawing.Size(67, 17);
            this.LastWriteInput.TabIndex = 5;
            this.LastWriteInput.Text = "Formato &";
            this.LastWriteInput.UseVisualStyleBackColor = true;
            // 
            // LastAccessInput
            // 
            this.LastAccessInput.AutoSize = true;
            this.LastAccessInput.Checked = true;
            this.LastAccessInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastAccessInput.Enabled = false;
            this.LastAccessInput.Location = new System.Drawing.Point(6, 111);
            this.LastAccessInput.Name = "LastAccessInput";
            this.LastAccessInput.Size = new System.Drawing.Size(47, 17);
            this.LastAccessInput.TabIndex = 4;
            this.LastAccessInput.Text = "&Anio";
            this.LastAccessInput.UseVisualStyleBackColor = true;
            // 
            // FileNameInput
            // 
            this.FileNameInput.AutoSize = true;
            this.FileNameInput.Checked = true;
            this.FileNameInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FileNameInput.Enabled = false;
            this.FileNameInput.Location = new System.Drawing.Point(6, 88);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(100, 17);
            this.FileNameInput.TabIndex = 3;
            this.FileNameInput.Text = "Tipo &de &archivo";
            this.FileNameInput.UseVisualStyleBackColor = true;
            // 
            // DirectoryNameInput
            // 
            this.DirectoryNameInput.AutoSize = true;
            this.DirectoryNameInput.Checked = true;
            this.DirectoryNameInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DirectoryNameInput.Enabled = false;
            this.DirectoryNameInput.Location = new System.Drawing.Point(6, 65);
            this.DirectoryNameInput.Name = "DirectoryNameInput";
            this.DirectoryNameInput.Size = new System.Drawing.Size(55, 17);
            this.DirectoryNameInput.TabIndex = 2;
            this.DirectoryNameInput.Text = "&Album";
            this.DirectoryNameInput.UseVisualStyleBackColor = true;
            // 
            // CreationTimeInput
            // 
            this.CreationTimeInput.AutoSize = true;
            this.CreationTimeInput.Checked = true;
            this.CreationTimeInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreationTimeInput.Enabled = false;
            this.CreationTimeInput.Location = new System.Drawing.Point(6, 42);
            this.CreationTimeInput.Name = "CreationTimeInput";
            this.CreationTimeInput.Size = new System.Drawing.Size(52, 17);
            this.CreationTimeInput.TabIndex = 1;
            this.CreationTimeInput.Text = "&Titulo";
            this.CreationTimeInput.UseVisualStyleBackColor = true;
            // 
            // AttributesInput
            // 
            this.AttributesInput.AutoSize = true;
            this.AttributesInput.Checked = true;
            this.AttributesInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttributesInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.AttributesInput.Enabled = false;
            this.AttributesInput.Location = new System.Drawing.Point(6, 19);
            this.AttributesInput.Name = "AttributesInput";
            this.AttributesInput.Size = new System.Drawing.Size(55, 17);
            this.AttributesInput.TabIndex = 0;
            this.AttributesInput.Text = "&Artista";
            this.AttributesInput.UseVisualStyleBackColor = true;
            // 
            // BlackWaspLink
            // 
            this.BlackWaspLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackWaspLink.AutoSize = true;
            this.BlackWaspLink.Location = new System.Drawing.Point(389, 399);
            this.BlackWaspLink.Name = "BlackWaspLink";
            this.BlackWaspLink.Size = new System.Drawing.Size(111, 13);
            this.BlackWaspLink.TabIndex = 2;
            this.BlackWaspLink.TabStop = true;
            this.BlackWaspLink.Text = "http://neteando.club/";
            this.BlackWaspLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlackWaspLink_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del DJ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Canciones enviadas:";
            // 
            // ActualizarCancionVDJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BlackWaspLink);
            this.Controls.Add(this.NotificationsGroup);
            this.Controls.Add(this.ChangeLogList);
            this.Controls.Add(this.ControlGroup);
            this.MinimumSize = new System.Drawing.Size(568, 459);
            this.Name = "ActualizarCancionVDJ";
            this.Text = "Actualizador de Cancion";
            this.Load += new System.EventHandler(this.ActualizarCancionVDJ_Load);
            this.ControlGroup.ResumeLayout(false);
            this.ControlGroup.PerformLayout();
            this.NotificationsGroup.ResumeLayout(false);
            this.NotificationsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox FolderInput;
        private System.Windows.Forms.CheckBox MonitoringInput;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.ListBox ChangeLogList;
        private System.Windows.Forms.TextBox FileFilterInput;
        private System.Windows.Forms.Label FileFilterLabel;
        private System.Windows.Forms.GroupBox NotificationsGroup;
        private System.Windows.Forms.CheckBox SizeInput;
        private System.Windows.Forms.CheckBox SecurityInput;
        private System.Windows.Forms.CheckBox LastWriteInput;
        private System.Windows.Forms.CheckBox LastAccessInput;
        private System.Windows.Forms.CheckBox FileNameInput;
        private System.Windows.Forms.CheckBox DirectoryNameInput;
        private System.Windows.Forms.CheckBox CreationTimeInput;
        private System.Windows.Forms.CheckBox AttributesInput;
        private System.Windows.Forms.LinkLabel BlackWaspLink;
        private System.Windows.Forms.CheckBox SubfoldersInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

