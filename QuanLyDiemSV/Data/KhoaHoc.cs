using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    class KhoaHoc
    {
        private string maKhoaHoc;
        private string tenKhoaHoc;
        private int namNhapHoc;

        public string MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
        public string TenKhoaHoc { get => tenKhoaHoc; set => tenKhoaHoc = value; }
        public int NamNhapHoc { get => namNhapHoc; set => namNhapHoc = value; }
    }
}
