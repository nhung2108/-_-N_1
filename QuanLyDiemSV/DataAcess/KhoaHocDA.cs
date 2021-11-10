using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class KhoaHocDA
    {
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public KhoaHocDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        private List<KhoaHoc> DocTep()
        {
            List<KhoaHoc> l = new List<KhoaHoc>();
            //Đọc tệp khoahoc.txt
            StreamReader sr = new StreamReader("khoahoc.txt");
            string MaKhoaHoc, TenKhoaHoc, SoDT;
            int NamNhapHoc;
            string s;
            //Đọc từng dùng dữ liệu trong tệp
            while ((s = sr.ReadLine()) != null)
            {
                //Tách các thuộc tính ở mỗi dòng
                string[] khoa = s.Split('#');
                MaKhoaHoc = khoa[0];
                TenKhoaHoc = khoa[1];
                NamNhapHoc = int.Parse(khoa[3]);
                KhoaHoc kh = new KhoaHoc();
                kh.MaKhoaHoc = MaKhoaHoc;
                kh.TenKhoaHoc = TenKhoaHoc;
                kh.NamNhapHoc = NamNhapHoc;
                //Đưa dữ liệu của khoa vào trong list
                l.Add(kh);
            }
            return l;
        }
        public string KiemTra(string Ma)
        {
            List<KhoaHoc> l = DocTep();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaKhoaHoc == Ma)
                    return l[i].MaKhoaHoc + "#" + l[i].TenKhoaHoc + "#" + l[i].NamNhapHoc;
            }
            return "null";
        }

    }
}
