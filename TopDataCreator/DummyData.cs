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

            string connectionString = services.ConnectionString(txtDatabaseServer.Text, txtDatabase.Text,
                chkWinAuthentication.Checked, txtDBUser.Text, txtDBUPassword.Text);

            List<string> tableList = new List<string>();

            tableList = services.DatabaseTables(connectionString, txtDatabase.Text);

            foreach (string table in tableList)
            {
                cmbDatabaseTables.Items.Add(table);
            }
        }
        #endregion
    }
}
