using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    class Khoa
    {
        private string maKhoa;
        private string tenKhoa;
        private string soDT;
        private string diaChi;

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
