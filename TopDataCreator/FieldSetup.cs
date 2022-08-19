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
        string fieldName;
        #endregion

        #region Constructors
        public FieldSetup(string fieldName)
        {
            InitializeComponent();

            this.fieldName = fieldName;
        }
        #endregion

        #region Labels
        void Labels()
        {
            lblField.Text = Spanish.FieldName;
            lblFieldName.Text = fieldName;
        }
        #endregion

        #region FieldSetup_Load
        private void FieldSetup_Load(object sender, EventArgs e)
        {
            Labels();
        }
        #endregion
    }
}
