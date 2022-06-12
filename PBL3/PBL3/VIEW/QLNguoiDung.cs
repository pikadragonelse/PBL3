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
namespace PBL3
{
    public partial class QLNguoiDung : Form
    {
        public QLNguoiDung()
        {
            InitializeComponent();
            setCBB();
        }
        public void setCBB()
        {
            cbbQLND.Items.AddRange(QLNguoiDung_BLL.Instance.getCbbNhomNguoiDung().Distinct().ToArray());
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
