using PBL3.DAL;
using PBL3.DTOVIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLNguoiDung_BLL
    {
        private static QLNguoiDung_BLL _Instance;
        QLKS db = new QLKS();
        public static QLNguoiDung_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNguoiDung_BLL();
                }
                return _Instance;
            }
            private set { }

        }
        public List<string> getCbbNhomNguoiDung()
        {
            List<string> data = new List<string>();
            foreach(var i in db.ChucVus.Select(p => p))
            {
                data.Add(i.TenChucVu);
            }
            return data;
        }
        public List<string> getPass()
        {
            List<string> data = new List<string>();
            foreach (var i in db.DangNhaps.Select(p => p))
            {
                data.Add(i.MatKhau);
            }
            return data;
        }
    }
}
