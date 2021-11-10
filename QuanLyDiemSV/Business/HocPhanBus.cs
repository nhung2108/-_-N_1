using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using QuanLyDiemSV.DataAcess;

namespace QuanLyDiemSV.Business
{
    class HocPhanBus
    {
        HocPhanDA HocPhanDA = new HocPhanDA();
        public string Ktra(string ma)
        {
            return HocPhanDA.KiemTra(ma);
        }
    }
}
