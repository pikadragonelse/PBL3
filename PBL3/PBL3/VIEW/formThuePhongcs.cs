using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
namespace PBL3.VIEW
{
    public partial class formThuePhongcs : Form
    {
        public formThuePhongcs()
        {
            InitializeComponent();
            dataGridView1.DataSource = ThuePhong_BLL.Instance.getAllDichVu();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
