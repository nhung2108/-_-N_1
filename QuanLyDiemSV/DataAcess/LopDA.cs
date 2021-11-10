using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class LopDA
    {
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public LopDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        private List<Lop> DocTep()
        {
            List<Lop> l = new List<Lop>();
            //Đọc tệp Lop.txt
            StreamReader sr = new StreamReader("Lop.txt");
            string MaLop, TenLop, MaKhoa, MaGVCN,MaKhoaHoc,GhiChu;
            string s;
            //Đọc từng dùng dữ liệu trong tệp
            while ((s = sr.ReadLine()) != null)
            {
                //Tách các thuộc tính ở mỗi dòng
                string[] Lops = s.Split('#');
                MaLop = Lops[0];
                TenLop = Lops[1];
                MaKhoa = Lops[2];
                MaGVCN = Lops[3];
                MaKhoaHoc = Lops[5];
                GhiChu = Lops[4];
                Lop lop = new Lop();
                lop.MaLop = MaLop;
                lop.TenLop = TenLop;
                lop.MaKhoa = MaKhoa;
                lop.MaGVCN = MaGVCN;
                lop.MaKhoaHoc = MaKhoaHoc;
                lop.GhiCHu = GhiChu;
                //Đưa dữ liệu của Lop vào trong list
                l.Add(lop);
            }
            return l;
        }
        public string KiemTra(string Ma)
        {
            List<Lop> l = DocTep();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaLop == Ma)
                    return l[i].MaLop + "#" + l[i].TenLop + "#" + l[i].MaKhoa + "#" + l[i].MaGVCN + "#" + l[i].MaKhoaHoc + "#" + l[i].GhiCHu;
            }
            return "null";
        }
    }
}
