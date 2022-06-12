using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.BLL
{
    public class QLDoThatLac_BLL
    {
        private static QLDoThatLac_BLL _Instance;
        QLKS db = new QLKS();
        public static QLDoThatLac_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLDoThatLac_BLL();
                }
                return _Instance;
            }
            private set { }

        }

        public List<string> getCbbTinhTrang()
        {
            List<string> data = new List<string>();
            foreach (string i in db.DoThatLacs.Select(p => p.TinhTrang).Distinct())
            {
                data.Add(i);
            }
            return data;
        }

        public List<DoThatLac> GetAllDoThatLac()
        {
            List<DoThatLac> data = new List<DoThatLac> ();
            foreach (DoThatLac i in db.DoThatLacs.Select(p => p))
            {
                data.Add(i);
            }
            return data;
        }

        public DoThatLac GetLast()
        {
            return db.DoThatLacs.Select(p => p).ToList().Last();
        }

        public List<DoThatLac> GetAllDoThatLacByCbb(string IdPhong, string TinhTrang)
        {
            List<DoThatLac> data = new List<DoThatLac>();
            if (IdPhong == "0")
            {
                foreach (DoThatLac i in db.DoThatLacs.Where(p => p.TinhTrang == TinhTrang).Select(p => p))
                {
                    data.Add(i);
                }
            }
            else
            {
                foreach (DoThatLac i in db.DoThatLacs.Where(p => p.IdPhong == IdPhong && p.TinhTrang == TinhTrang).Select(p => p))
                {
                    data.Add(i);
                }
            }

            return data;
        }

        public List<DoThatLacView> GetDoThatLacViews(string IdPhong, string TinhTrang)
        {
            List<DoThatLacView> data = new List<DoThatLacView> ();
            foreach (DoThatLac i in GetAllDoThatLacByCbb(IdPhong, TinhTrang))
            {
                data.Add(new DoThatLacView { ID = i.ID, TimeHired = QLBook_BLL.Instance.GetCheckInRealTimeByIdPhong(i.IdPhong).ToString() + "\n" + " -> " + "\n" + QLBook_BLL.Instance.GetCheckOutRealTimeByIdPhong(i.IdPhong).ToString(),
                        Name = i.Name, TinhTrang = i.TinhTrang });
            }
            return data;
        }

        public void UpdateDoThatLac( DoThatLac dothatlac)
        {
            DoThatLac d = db.DoThatLacs.Where(p => p.ID == dothatlac.ID).Select(p => p).FirstOrDefault();
            d.Name = dothatlac.Name;
            d.TinhTrang = dothatlac.TinhTrang;
            db.SaveChanges();
        }

        public void AddDoThatLac(DoThatLac d)
        {
            db.DoThatLacs.Add(d);
            db.SaveChanges();
        }

    }
}
