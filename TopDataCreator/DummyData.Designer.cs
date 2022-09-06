namespace TopDataCreator
{
    partial class DummyData
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
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblDatabaseServer = new System.Windows.Forms.Label();
            this.txtDatabaseServer = new System.Windows.Forms.TextBox();
            this.lblSQLServer = new System.Windows.Forms.Label();
            this.lblDBUser = new System.Windows.Forms.Label();
            this.chkWinAuthentication = new System.Windows.Forms.CheckBox();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.lblDBUPassword = new System.Windows.Forms.Label();
            this.txtDBUPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.cmbDatabaseTables = new System.Windows.Forms.ComboBox();
            this.dgvTableFields = new System.Windows.Forms.DataGridView();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblNumberRecordsGenerate = new System.Windows.Forms.Label();
            this.txtNumberRecordsGenerate = new System.Windows.Forms.TextBox();
            this.btnSeeFieldConfiguration = new System.Windows.Forms.Button();
            this.fieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Ready = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFields)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(31, 18);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(84, 20);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Connection";
            // 
            // lblDatabaseServer
            // 
            this.lblDatabaseServer.AutoSize = true;
            this.lblDatabaseServer.Location = new System.Drawing.Point(31, 52);
            this.lblDatabaseServer.Name = "lblDatabaseServer";
            this.lblDatabaseServer.Size = new System.Drawing.Size(113, 20);
            this.lblDatabaseServer.TabIndex = 1;
            this.lblDatabaseServer.Text = "DatabaseServer";
            // 
            // txtDatabaseServer
            // 
            this.txtDatabaseServer.Location = new System.Drawing.Point(226, 41);
            this.txtDatabaseServer.Name = "txtDatabaseServer";
            this.txtDatabaseServer.Size = new System.Drawing.Size(236, 27);
            this.txtDatabaseServer.TabIndex = 2;
            // 
            // lblSQLServer
            // 
            this.lblSQLServer.AutoSize = true;
            this.lblSQLServer.Location = new System.Drawing.Point(226, 18);
            this.lblSQLServer.Name = "lblSQLServer";
            this.lblSQLServer.Size = new System.Drawing.Size(80, 20);
            this.lblSQLServer.TabIndex = 3;
            this.lblSQLServer.Text = "SQL Server";
            // 
            // lblDBUser
            // 
            this.lblDBUser.AutoSize = true;
            this.lblDBUser.Location = new System.Drawing.Point(31, 137);
            this.lblDBUser.Name = "lblDBUser";
            this.lblDBUser.Size = new System.Drawing.Size(58, 20);
            this.lblDBUser.TabIndex = 4;
            this.lblDBUser.Text = "DBUser";
            // 
            // chkWinAuthentication
            // 
            this.chkWinAuthentication.AutoSize = true;
            this.chkWinAuthentication.Location = new System.Drawing.Point(31, 110);
            this.chkWinAuthentication.Name = "chkWinAuthentication";
            this.chkWinAuthentication.Size = new System.Drawing.Size(154, 24);
            this.chkWinAuthentication.TabIndex = 5;
            this.chkWinAuthentication.Text = "WinAuthentication";
            this.chkWinAuthentication.UseVisualStyleBackColor = true;
            // 
            // txtDBUser
            // 
            this.txtDBUser.Location = new System.Drawing.Point(226, 134);
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(125, 27);
            this.txtDBUser.TabIndex = 6;
            // 
            // lblDBUPassword
            // 
            this.lblDBUPassword.AutoSize = true;
            this.lblDBUPassword.Location = new System.Drawing.Point(31, 170);
            this.lblDBUPassword.Name = "lblDBUPassword";
            this.lblDBUPassword.Size = new System.Drawing.Size(100, 20);
            this.lblDBUPassword.TabIndex = 7;
            this.lblDBUPassword.Text = "DBUPassword";
            // 
            // txtDBUPassword
            // 
            this.txtDBUPassword.Location = new System.Drawing.Point(226, 167);
            this.txtDBUPassword.Name = "txtDBUPassword";
            this.txtDBUPassword.Size = new System.Drawing.Size(125, 27);
            this.txtDBUPassword.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(373, 210);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 33);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(31, 81);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(72, 20);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(226, 74);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(225, 27);
            this.txtDatabase.TabIndex = 11;
            // 
            // cmbDatabaseTables
            // 
            this.cmbDatabaseTables.FormattingEnabled = true;
            this.cmbDatabaseTables.Location = new System.Drawing.Point(226, 249);
            this.cmbDatabaseTables.Name = "cmbDatabaseTables";
            this.cmbDatabaseTables.Size = new System.Drawing.Size(438, 28);
            this.cmbDatabaseTables.TabIndex = 12;
            this.cmbDatabaseTables.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseTables_SelectedIndexChanged);
            // 
            // dgvTableFields
            // 
            this.dgvTableFields.AllowUserToAddRows = false;
            this.dgvTableFields.AllowUserToDeleteRows = false;
            this.dgvTableFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldName,
            this.fieldType,
            this.fieldLength,
            this.Actions,
            this.Ready});
            this.dgvTableFields.Location = new System.Drawing.Point(31, 305);
            this.dgvTableFields.Name = "dgvTableFields";
            this.dgvTableFields.ReadOnly = true;
            this.dgvTableFields.RowHeadersWidth = 51;
            this.dgvTableFields.RowTemplate.Height = 29;
            this.dgvTableFields.Size = new System.Drawing.Size(907, 303);
            this.dgvTableFields.TabIndex = 13;
            this.dgvTableFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableFields_CellContentClick);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(31, 257);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 20);
            this.lblTable.TabIndex = 14;
            this.lblTable.Text = "Table";
            // 
            // lblNumberRecordsGenerate
            // 
            this.lblNumberRecordsGenerate.AutoSize = true;
            this.lblNumberRecordsGenerate.Location = new System.Drawing.Point(31, 648);
            this.lblNumberRecordsGenerate.Name = "lblNumberRecordsGenerate";
            this.lblNumberRecordsGenerate.Size = new System.Drawing.Size(176, 20);
            this.lblNumberRecordsGenerate.TabIndex = 15;
            this.lblNumberRecordsGenerate.Text = "NumberRecordsGenerate";
            // 
            // txtNumberRecordsGenerate
            // 
            this.txtNumberRecordsGenerate.Location = new System.Drawing.Point(386, 641);
            this.txtNumberRecordsGenerate.Name = "txtNumberRecordsGenerate";
            this.txtNumberRecordsGenerate.Size = new System.Drawing.Size(125, 27);
            this.txtNumberRecordsGenerate.TabIndex = 16;
            // 
            // btnSeeFieldConfiguration
            // 
            this.btnSeeFieldConfiguration.Location = new System.Drawing.Point(747, 614);
            this.btnSeeFieldConfiguration.Name = "btnSeeFieldConfiguration";
            this.btnSeeFieldConfiguration.Size = new System.Drawing.Size(191, 29);
            this.btnSeeFieldConfiguration.TabIndex = 17;
            this.btnSeeFieldConfiguration.Text = "SeeFieldConfiguration";
            this.btnSeeFieldConfiguration.UseVisualStyleBackColor = true;
            this.btnSeeFieldConfiguration.Click += new System.EventHandler(this.btnSeeFieldConfiguration_Click);
            // 
            // fieldName
            // 
            this.fieldName.HeaderText = "FieldName";
            this.fieldName.MinimumWidth = 6;
            this.fieldName.Name = "fieldName";
            this.fieldName.ReadOnly = true;
            this.fieldName.Width = 125;
            // 
            // fieldType
            // 
            this.fieldType.HeaderText = "FieldType";
            this.fieldType.MinimumWidth = 6;
            this.fieldType.Name = "fieldType";
            this.fieldType.ReadOnly = true;
            this.fieldType.Width = 125;
            // 
            // fieldLength
            // 
            this.fieldLength.HeaderText = "FieldLength";
            this.fieldLength.MinimumWidth = 6;
            this.fieldLength.Name = "fieldLength";
            this.fieldLength.ReadOnly = true;
            this.fieldLength.Width = 125;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.Width = 125;
            // 
            // Ready
            // 
            this.Ready.HeaderText = "Ready";
            this.Ready.MinimumWidth = 6;
            this.Ready.Name = "Ready";
            this.Ready.ReadOnly = true;
            this.Ready.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ready.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ready.Width = 125;
            // 
            // DummyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 744);
            this.Controls.Add(this.btnSeeFieldConfiguration);
            this.Controls.Add(this.txtNumberRecordsGenerate);
            this.Controls.Add(this.lblNumberRecordsGenerate);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.dgvTableFields);
            this.Controls.Add(this.cmbDatabaseTables);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDBUPassword);
            this.Controls.Add(this.lblDBUPassword);
            this.Controls.Add(this.txtDBUser);
            this.Controls.Add(this.chkWinAuthentication);
            this.Controls.Add(this.lblDBUser);
            this.Controls.Add(this.lblSQLServer);
            this.Controls.Add(this.txtDatabaseServer);
            this.Controls.Add(this.lblDatabaseServer);
            this.Controls.Add(this.lblConnection);
            this.Name = "DummyData";
            this.Text = "DummyData";
            this.Load += new System.EventHandler(this.DummyData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConnection;
        private Label lblDatabaseServer;
        private TextBox txtDatabaseServer;
        private Label lblSQLServer;
        private Label lblDBUser;
        private CheckBox chkWinAuthentication;
        private TextBox txtDBUser;
        private Label lblDBUPassword;
        private TextBox txtDBUPassword;
        private Button btnConnect;
        private Label lblDatabase;
        private TextBox txtDatabase;
        private ComboBox cmbDatabaseTables;
        private DataGridView dgvTableFields;
        private Label lblTable;
        private Label lblNumberRecordsGenerate;
        private TextBox txtNumberRecordsGenerate;
        private Button btnSeeFieldConfiguration;
        private DataGridViewTextBoxColumn fieldName;
        private DataGridViewTextBoxColumn fieldType;
        private DataGridViewTextBoxColumn fieldLength;
        private DataGridViewLinkColumn Actions;
        private DataGridViewCheckBoxColumn Ready;
    }
}