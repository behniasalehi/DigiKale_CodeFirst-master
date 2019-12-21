using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKala
{
    public partial class Form1 : Form
    {
        #region [- ctor -]
        public Form1()
        {
            InitializeComponent();
            ReF_CategoryViewModel = new ViewModel.Category.CategoryViewModel();
        }
        #endregion

        public ViewModel.Category.CategoryViewModel ReF_CategoryViewModel { get; set; }
        #region [- BtnRefresh_Click -]
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource =  ReF_CategoryViewModel.FillGrid();
        } 
        #endregion
    }
}
