using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class HocPhanDA
    {
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public HocPhanDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        private List<HocPhan> DocTep()
        {
            List<HocPhan> l = new List<HocPhan>();
            //Đọc tệp hocphan.txt
            StreamReader sr = new StreamReader("hocphan.txt");
            string MaHP, TenHP, GhiChu;
            int SoTin;
            string s;
            //Đọc từng dùng dữ liệu trong tệp
            while ((s = sr.ReadLine()) != null)
            {
                //Tách các thuộc tính ở mỗi dòng
                string[] hp = s.Split('#');
                MaHP = hp[0];
                TenHP = hp[1];
                SoTin = int.Parse(hp[2]);
                GhiChu = hp[3];
                HocPhan hocphan = new HocPhan();
                hocphan.MaHP = MaHP;
                hocphan.TenHP = TenHP;
                hocphan.SoTin = SoTin;
                hocphan.GhiChu = GhiChu;
                //Đưa dữ liệu của khoa vào trong list
                l.Add(hocphan);
            }
            return l;
        }
        public List<HocPhan> HocPhans()
        {
            return DocTep();
        }
        public string KiemTra(string Ma)
        {
            List<HocPhan> l = DocTep();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaHP == Ma)
                    return l[i].MaHP + "\t" + l[i].TenHP + "\t" + l[i].SoTin + "\t" + l[i].GhiChu;
            }
            return "null";
        }
    }
}
