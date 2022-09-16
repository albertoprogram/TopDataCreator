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
    public partial class FieldSetup : Form
    {
        #region variables
        int rowIndex;
        string fieldName;
        string fieldType;
        string fieldLength;
        #endregion

        #region property contract
        public IFieldsContract contract { get; set; }
        #endregion

        #region Constructors
        public FieldSetup(int rowIndex, string fieldName, string fieldType, string fieldLength)
        {
            InitializeComponent();

            this.rowIndex = rowIndex;
            this.fieldName = fieldName;
            this.fieldType = fieldType;
            this.fieldLength = fieldLength;
        }
        #endregion

        #region Labels
        void Labels()
        {
            lblField.Text = Spanish.FieldName;
            lblFieldName.Text = fieldName;
            lblType.Text = Spanish.FieldType;
            lblFieldType.Text = fieldType;
            lblLength.Text = Spanish.FieldLength;
            lblFieldLength.Text = fieldLength;
            rbFillAccordingTypeLength.Text = Spanish.FillAccordingTypeLength;

            btnAccept.Text = Spanish.Accept;
        }
        #endregion

        #region FieldSetup_Load
        private void FieldSetup_Load(object sender, EventArgs e)
        {
            Labels();
        }
        #endregion

        #region btnAccept_Click
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (rbFillAccordingTypeLength.Checked)
            {
                var tuple = new Tuple<int, string, string>(rowIndex, lblFieldName.Text, "rbFillAccordingTypeLength");

                contract.FieldSetings(tuple);

                MessageBox.Show(Spanish.TheFieldHasBeenConfigured, Spanish.SystemName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }
        #endregion
    }
}
