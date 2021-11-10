using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    class Lop
    {
        private string maLop;
        private string tenLop;
        private string maKhoa;
        private string maGVCN;
        private string maKhoaHoc;
        private string ghiCHu;

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaGVCN { get => maGVCN; set => maGVCN = value; }
        public string MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
        public string GhiCHu { get => ghiCHu; set => ghiCHu = value; }
    }
}
