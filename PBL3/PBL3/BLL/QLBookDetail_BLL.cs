using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class QLBookDetail_BLL
    {
        private static QLBookDetail_BLL _Instance;
        QLKS db = new QLKS();
        public static QLBookDetail_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLBookDetail_BLL();
                }
                return _Instance;
            }
            private set { }

        }

        public BookDetail GetBookDetailByIdPhong(string IdPhong)
        {
            return db.BookDetails.Where(x => x.IdPhong == IdPhong).FirstOrDefault();
        }



    }
}
