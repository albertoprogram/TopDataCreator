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
    public partial class DummyData : Form, IFieldsContract
    {
        #region Form Variables
        private List<Tuple<int, string, string>> fieldSettings = new List<Tuple<int, string, string>>();
        #endregion

        #region Constructors
        public DummyData()
        {
            InitializeComponent();
        }
        #endregion

        #region FieldSetings
        public void FieldSetings(Tuple<int, string, string> fieldSetting)
        {
            fieldSettings.Add(fieldSetting);

            DataGridViewRow row = dgvTableFields.Rows[fieldSetting.Item1];

            DataGridViewCheckBoxCell boxCell = row.Cells["Ready"] as DataGridViewCheckBoxCell;

            boxCell.Value = true;
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
            lblNumberRecordsGenerate.Text = Spanish.NumberRecordsGenerate;

            dgvTableFields.Columns[0].HeaderText = Spanish.FieldName;
            dgvTableFields.Columns[1].HeaderText = Spanish.FieldType;
            dgvTableFields.Columns[2].HeaderText = Spanish.FieldLength;
            dgvTableFields.Columns[3].HeaderText = Spanish.Actions;
            dgvTableFields.Columns[4].HeaderText = Spanish.Ready;

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

            foreach (DataRow row in fields.Rows)
            {
                dgvTableFields.Rows.Add(row["COLUMN_NAME"].ToString(), row["DATA_TYPE"].ToString(), row["FIELD_LENGTH"].ToString(), Spanish.SetUp);
            }
        }
        #endregion

        #region dgvTableFields_CellContentClick
        private void dgvTableFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                FieldSetup fieldSetup = new
                    FieldSetup(dgvTableFields.Rows[e.RowIndex].Index,
                    dgvTableFields.Rows[e.RowIndex].Cells["FieldName"].Value.ToString(),
                    dgvTableFields.Rows[e.RowIndex].Cells["FieldType"].Value.ToString(),
                    dgvTableFields.Rows[e.RowIndex].Cells["FieldLength"].Value.ToString());

                fieldSetup.contract = this;

                fieldSetup.ShowDialog();
            }
            else if (e.ColumnIndex == 4)
            {
                int indexdgvRow = e.RowIndex;
                
                DataGridViewRow row = dgvTableFields.Rows[e.RowIndex];

                DataGridViewCheckBoxCell boxCell = row.Cells["Ready"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(boxCell.Value))
                {
                    int indexList = 0;
                    foreach (var item in fieldSettings)
                    {
                        if (item.Item1 == indexdgvRow)
                        {
                            fieldSettings.RemoveAt(indexList);
                            boxCell.Value = false;
                            break;
                        }
                        indexList++;
                    }
                }
            }
        }
        #endregion

        #region btnSeeFieldConfiguration_Click
        private void btnSeeFieldConfiguration_Click(object sender, EventArgs e)
        {
            StringBuilder infoFieldsSetting = new StringBuilder();

            foreach (var item in fieldSettings)
            {
                infoFieldsSetting.Append(item.Item1.ToString() + "-" + item.Item2.ToString() + "-" + item.Item3.ToString() + Environment.NewLine);
            }

            MessageBox.Show(infoFieldsSetting.ToString());
        }
        #endregion
    }
}
