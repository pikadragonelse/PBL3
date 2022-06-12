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
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.VIEW
{
    public partial class formThuePhongcs : Form
    {
        public formThuePhongcs()
        {
            InitializeComponent();
            dataGridView1.DataSource = ThuePhong_BLL.Instance.getAllDichVu();
            cbbTenPhong.Items.AddRange(ThuePhong_BLL.Instance.getAllPhong().ToArray());
            cbbLoaiPhong.Items.Add(new CBBItemPhong {Value="All",Text="All" });
            cbbLoaiPhong.Items.AddRange(ThuePhong_BLL.Instance.getAllLoaiPhong().ToArray());
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThuePhong_BLL.Instance.getDVbySearch(txtSearch.Text);
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenPhong.Items.Clear();
            cbbTenPhong.Items.AddRange(ThuePhong_BLL.Instance.getCbbPhongByLoaiPhong(((CBBItemPhong)cbbLoaiPhong.SelectedItem).Value).ToArray());
        }

        private void butChonKhachHang_Click(object sender, EventArgs e)
        {
            formChonKhachHang f = new formChonKhachHang();
            f.d = new formChonKhachHang.Mydel(ShowKH);
            f.Show();
        }
       public void ShowKH(string MaKH)
        {
            dataGridViewKhachHang.DataSource = ThuePhong_BLL.Instance.getKHViewbyMaKH(MaKH);
        }

        private void formThuePhongcs_Load(object sender, EventArgs e)
        {

        }
    }
}
