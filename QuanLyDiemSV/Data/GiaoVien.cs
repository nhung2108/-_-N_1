using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    class GiaoVien
    {
        private string maGV;
        private string tenGV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDT;
        private string email;
        private string queQuan;

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
    }
}
