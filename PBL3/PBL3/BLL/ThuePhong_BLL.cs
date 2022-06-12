using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.BLL
{
    public class ThuePhong_BLL
    {
        private static ThuePhong_BLL _Instance;
        QLKS db = new QLKS();
        public static ThuePhong_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThuePhong_BLL();
                }
                return _Instance;
            }
            private set { }

        }
        public List<DichVuView> getAllDichVu()
        {
            List<DichVuView> data = new List<DichVuView>();
            foreach(var i in db.LoaiDichVus.Select(p => p))
            {
                data.Add(new DichVuView
                {
                    IdDichVu=i.IdDichVu,TenDichVu=i.TenDichVu,DonGia=i.DonGia
                });
            }
            return data;
        }
        public List<CBBItemPhong> getAllPhong()
        {
            List<CBBItemPhong> data = new List<CBBItemPhong>();
            foreach (var i in db.Phongs.Select(p => p))
            {
                data.Add(new CBBItemPhong
                {
                    Value = i.IdPhong,
                    Text = i.Name,
                });
            }
            return data;
        }



        public List<DichVuView> getDVbySearch(string txt)
        {
            List<DichVuView> data = new List<DichVuView>();
            foreach (var i in db.LoaiDichVus.Select(p => p))
            {
                if (i.TenDichVu.Contains(txt))
                {
                    data.Add(new DichVuView
                    {
                        IdDichVu = i.IdDichVu,
                        TenDichVu = i.TenDichVu,
                        DonGia = i.DonGia
                    });
                }
            }
            return data;
        }
    }
}
