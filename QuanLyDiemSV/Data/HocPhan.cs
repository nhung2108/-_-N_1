using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    class HocPhan
    {
        private string maHP;
        private string tenHP;
        private int soTin;
        private string ghiChu;

        public string MaHP { get => maHP; set => maHP = value; }
        public string TenHP { get => tenHP; set => tenHP = value; }
        public int SoTin { get => soTin; set => soTin = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
