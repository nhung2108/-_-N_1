using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using QuanLyDiemSV.DataAcess;

namespace QuanLyDiemSV.Business
{
    class KhoaHocBus
    {
        KhoaHocDA KhoaHocDA = new KhoaHocDA();
        public string Them(string ma)
        {
             return KhoaHocDA.KiemTra(ma);
        }
    }
}
