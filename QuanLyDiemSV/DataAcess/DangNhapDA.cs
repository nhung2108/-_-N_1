using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class DangNhapDA
    {
        /// <summary>
        /// Khai báo thuộc tính cho lớp đăng nhập
        /// </summary>
        private DangNhap d;
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public DangNhapDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        public List<DangNhap> DocTep()
        {
            List<DangNhap> l = new List<DangNhap>();
            StreamReader sr = new StreamReader("dangnhap.txt");
            string MaDN, Password;
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] ac = s.Split('#');
                MaDN = ac[0];
                Password = ac[1];
                DangNhap dn = new DangNhap();
                dn.MaDN = MaDN;
                dn.Password = Password;
                l.Add(dn);
            }
            return l;
        }
        public int KiemTra(string Ma,string pass)
        {
            List<DangNhap> l = DocTep();
            for(int i=0;i<l.Count;i++)
            {
                if (l[i].MaDN == Ma && l[i].Password == pass)
                    return 1;
            }
            return -1;
        }
    }
}
