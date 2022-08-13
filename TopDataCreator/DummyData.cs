using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDataCreator
{
    public partial class DummyData : Form
    {
        #region Constructors
        public DummyData()
        {
            InitializeComponent();
        }
        #endregion

        #region Labels
        void Labels()
        {
            //labels
            lblConnection.Text = Spanish.Connection;
            lblDatabaseServer.Text = Spanish.DatabaseServer;
            lblDBUser.Text = Spanish.DBUser;
            lblDBUPassword.Text = Spanish.DBUPassword;
            lblDatabase.Text = Spanish.Database;
            lblTable.Text = Spanish.Table;

            dgvTableFields.Columns[0].HeaderText = Spanish.FieldName;
            dgvTableFields.Columns[1].HeaderText = Spanish.FieldType;
            dgvTableFields.Columns[2].HeaderText = Spanish.FieldLength;

            chkWinAuthentication.Text = Spanish.WinAuthentication;

            btnConnect.Text = Spanish.Connect;
        }
        #endregion

        #region DummyData_Load
        private void DummyData_Load(object sender, EventArgs e)
        {
            Labels();
        }
        #endregion

        #region btnConnect_Click
        private void btnConnect_Click(object sender, EventArgs e)
        {
            TDCServices services = new TDCServices();

            string connectionString = services.SetConnectionString(txtDatabaseServer.Text, txtDatabase.Text,
                chkWinAuthentication.Checked, txtDBUser.Text, txtDBUPassword.Text);

            List<string> tableList = new List<string>();

            tableList = services.GetDatabaseTables(connectionString, txtDatabase.Text);

            foreach (string table in tableList)
            {
                cmbDatabaseTables.Items.Add(table);
            }

            cmbDatabaseTables.DroppedDown = true;
        }
        #endregion

        #region cmbDatabaseTables_SelectedIndexChanged
        private void cmbDatabaseTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTableFields.Rows.Clear();

            TDCServices services = new TDCServices();

            DataTable fields = new DataTable();

            string connectionString = services.SetConnectionString(txtDatabaseServer.Text, txtDatabase.Text,
                chkWinAuthentication.Checked, txtDBUser.Text, txtDBUPassword.Text);

            fields = services.GetTableFields(connectionString, txtDatabase.Text, cmbDatabaseTables.GetItemText(cmbDatabaseTables.SelectedItem));

            foreach(DataRow row in fields.Rows)
            {
                dgvTableFields.Rows.Add(row["COLUMN_NAME"].ToString(), row["DATA_TYPE"].ToString(), row["FIELD_LENGTH"].ToString());
            }
        }
        #endregion
    }
}
