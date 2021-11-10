using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class GiaoVienDA
    {
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public GiaoVienDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        private List<GiaoVien> DocTep()
        {
            List<GiaoVien> l = new List<GiaoVien>();
            //Đọc tệp giaovien.txt
            StreamReader sr = new StreamReader("giaovien.txt");
            string MaGV, TenGV, GioiTinh, SoDT, Email, QueQuan;
            DateTime NgaySinh;
            string s;
            //Đọc từng dùng dữ liệu trong tệp
            while ((s = sr.ReadLine()) != null)
            {
                //Tách các thuộc tính ở mỗi dòng
                string[] GiaoViens = s.Split('#');
                MaGV = GiaoViens[0];
                TenGV = GiaoViens[1];
                NgaySinh = DateTime.Parse(GiaoViens[2]);
                GioiTinh = GiaoViens[3];
                SoDT = GiaoViens[4];
                Email = GiaoViens[5];
                QueQuan = GiaoViens[6];
                GiaoVien GiaoVien = new GiaoVien();
                GiaoVien.MaGV = MaGV;
                GiaoVien.TenGV = TenGV;
                GiaoVien.NgaySinh = NgaySinh;
                GiaoVien.GioiTinh = GioiTinh;
                GiaoVien.SoDT = SoDT;
                GiaoVien.Email = Email;
                GiaoVien.QueQuan = QueQuan;
                //Đưa dữ liệu của GiaoVien vào trong list
                l.Add(GiaoVien);
            }
            return l;
        }
        public string KiemTra(string Ma)
        {
            List<GiaoVien> l = DocTep();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaGV == Ma)
                    return l[i].MaGV + "#" + l[i].TenGV + "#" + l[i].TenGV + "#" + l[i].NgaySinh + "#" + l[i].SoDT + "#" + l[i].Email;
            }
            return "null";
        }
    }
}
