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
using PBL3.DTOVIEW;
using PBL3.DTO;

namespace PBL3
{
    public partial class formManageLostStuff : Form
    {

        public formManageLostStuff()
        {
            InitializeComponent();
            foreach (string i in QLDoThatLac_BLL.Instance.getCbbTinhTrang())
            {
               cbbTinhTrang.Items.Add(i);
            }

            foreach (string i in QLDoThatLac_BLL.Instance.getCbbTinhTrang())
            {
                cbbTinhTrang2.Items.Add(i);
            }
            cbbTinhTrang2.SelectedIndex = 0;
            cbbPhong.Items.Add(new CBBItemPhong { Text = "Tất cả", Value = "0"});
            cbbPhong.SelectedIndex = 0;

            foreach (CBBItemPhong i in QLPhong_BLL.Instance.getCbbPhong())
            {
                cbbPhong.Items.Add(i);
            }

            foreach (Phong i in QLPhong_BLL.Instance.GetAllPhong())  { 
                cbbPhongTime.Items.Add(new CBBItemPhong { Text = i.Name + "  " + QLBook_BLL.Instance.GetCheckInRealTimeByIdPhong(i.IdPhong).ToString(), Value = i.IdPhong });
            }

            SetMinNumberic();
        }

        public void ShowAll()
        {
            dataGridView.DataSource = QLDoThatLac_BLL.Instance.GetDoThatLacViews( ((CBBItemPhong)cbbPhong.SelectedItem).Value, cbbTinhTrang2.SelectedItem.ToString()).ToList();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        public void SetMinNumberic()
        {
            NumbericID.Minimum = Convert.ToInt32(QLDoThatLac_BLL.Instance.GetLast().ID) + 1;
            NumbericID.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoThatLac doThatLac = new DoThatLac
            {
                ID = NumbericID.Value.ToString(),
                Name = txtName.Text,
                IdPhong = ((CBBItemPhong)cbbPhongTime.SelectedItem).Value,
                TinhTrang = cbbTinhTrang.SelectedItem.ToString(),
            };
            QLDoThatLac_BLL.Instance.AddDoThatLac(doThatLac);
            ShowAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DoThatLac doThatLac = new DoThatLac
            {
                ID = NumbericID.Value.ToString(),
                Name = txtName.Text,
                IdPhong = ((CBBItemPhong)cbbPhongTime.SelectedItem).Value,
                TinhTrang = cbbTinhTrang.SelectedItem.ToString(),
            };
            QLDoThatLac_BLL.Instance.UpdateDoThatLac(doThatLac);
            ShowAll();
            SetMinNumberic();
            txtName.Text = "";
            

        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
           
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                DoThatLacView doThatLacView = (DoThatLacView)dataGridView.SelectedRows[0].DataBoundItem;
                foreach (DoThatLac i in QLDoThatLac_BLL.Instance.GetAllDoThatLac())
                {
                    if (doThatLacView.ID == i.ID)
                    {
                        NumbericID.Enabled = false;
                        NumbericID.Minimum = 0;
                        NumbericID.Value = Convert.ToInt32(i.ID);
                        txtName.Text = i.Name;
                        cbbTinhTrang.SelectedItem = i.TinhTrang;

                        foreach (CBBItemPhong j in cbbPhongTime.Items)
                        {
                            if (j.Value == i.IdPhong)
                            {
                                cbbPhongTime.SelectedItem = j;
                            }
                        }

                    }
                }
            }
        }
    }
}
