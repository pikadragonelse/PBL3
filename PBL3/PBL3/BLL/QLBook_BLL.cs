using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DTOVIEW;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class QLBook_BLL
    {
        private static QLBook_BLL _Instance;
        QLKS db = new QLKS();
        public static QLBook_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLBook_BLL();
                }
                return _Instance;
            }
            private set { }



        }


        public QLBook_BLL()
        {

        }
        public DateTime GetCheckInRealTimeByIdPhong(string IdPhong)

        {

            string idBook = QLBookDetail_BLL.Instance.GetBookDetailByIdPhong(IdPhong).IdBook;
            return db.Books.Where(x => x.IdBook == idBook)
                    .Select(x => x.NgayCheckInThucTe).FirstOrDefault();
        }

        public DateTime GetCheckOutRealTimeByIdPhong(string IdPhong)
        {
            string idBook = QLBookDetail_BLL.Instance.GetBookDetailByIdPhong(IdPhong).IdBook;
            return db.Books.Where(x => x.IdBook == idBook)
                    .Select(x => x.NgayCheckOutThucTe).FirstOrDefault();
        }
    }
}
