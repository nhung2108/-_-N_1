using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.DataAcess;

namespace QuanLyDiemSV.Business
{
    class DangNhapBus
    {
        DangNhapDA dnd = new DangNhapDA();
        public int KiemTra(string Ma, string Pass)
        {
            return dnd.KiemTra(Ma, Pass);
        }
    }
}