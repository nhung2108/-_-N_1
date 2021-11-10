using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    /// <summary>
    /// Cấu trúc dữ liệu đăng nhập
    /// </summary>
    class DangNhap
    {
        private string maDN;
        private string password;

        public string MaDN { get => maDN; set => maDN = value; }
        public string Password { get => password; set => password = value; }
    }
}
