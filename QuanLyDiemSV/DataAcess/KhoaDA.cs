using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class KhoaDA
    {
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public KhoaDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        private List<Khoa> DocTep()
        {
            List<Khoa> l = new List<Khoa>();
            //Đọc tệp khoa.txt
            StreamReader sr = new StreamReader("khoa.txt");
            string MaKhoa, TenKhoa,SoDT,DiaChi;
            string s;
            //Đọc từng dùng dữ liệu trong tệp
            while ((s = sr.ReadLine()) != null)
            {
                //Tách các thuộc tính ở mỗi dòng
                string[] khoa = s.Split('#');
                MaKhoa = khoa[0];
                TenKhoa = khoa[1];
                DiaChi = khoa[3];
                SoDT = khoa[2];
                Khoa kh = new Khoa();
                kh.MaKhoa = MaKhoa;
                kh.TenKhoa = TenKhoa;
                kh.SoDT = SoDT;
                kh.DiaChi = DiaChi;
                //Đưa dữ liệu của khoa vào trong list
                l.Add(kh);
            }
            return l;
        }
        public string KiemTra(string Ma)
        {
            List<Khoa> l = DocTep();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaKhoa == Ma)
                    return l[i].MaKhoa+"#"+l[i].TenKhoa + "#" + l[i].SoDT + "#" + l[i].DiaChi;
            }
            return "null";
        }
    }

}

