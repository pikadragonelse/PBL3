using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTOVIEW;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class QLPhong_BLL
    {
        private static QLPhong_BLL _Instance;
        QLKS db = new QLKS();

        public static QLPhong_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLPhong_BLL();
                }
                return _Instance;
            }
            private set { }

        }

        public List<CBBItemPhong> getCbbPhong()
        {
            List<CBBItemPhong> list = new List<CBBItemPhong>();
            foreach (Phong i in db.Phongs.Select(p => p))
            {
                list.Add(new CBBItemPhong { Text = i.Name, Value = i.IdPhong});
            }
            return list;
        }

        public List<Phong> GetAllPhong()
        {
            return db.Phongs.Select(p => p).ToList();
        }
        public List<CBBItemPhong> getCbbPhongByLoaiPhong(string idloaiphong)
        {
            List<CBBItemPhong> list = new List<CBBItemPhong>();
            foreach (Phong i in db.Phongs.Select(p => p))
            {
                if (i.LoaiPhong.IdLoaiPhong == idloaiphong)
                {
                    list.Add(new CBBItemPhong { Text = i.Name, Value = i.IdPhong });

                }
            }
            return list;
        }



    }
}
