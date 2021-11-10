using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using QuanLyDiemSV.DataAcess;

namespace QuanLyDiemSV.Business
{
    class GiaoVienBus
    {
        GiaoVienDA GiaoVienDA = new GiaoVienDA();
        public string Them(string ma)
        {
             return GiaoVienDA.KiemTra(ma);
        }
    }
}
