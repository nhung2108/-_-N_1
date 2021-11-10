using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Data;
using System.IO;

namespace QuanLyDiemSV.DataAcess
{
    class DiemDA
    {
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public DiemDA()
        {

        }
        /// <summary>
        /// Đọc dữ liệu từ tệp
        /// </summary>
        /// <returns></returns>
        private List<Diem> Doc()
        {
            List<Diem> l = new List<Diem>();
            //Đọc tệp Diem.txt
            StreamReader sr = new StreamReader("diem.txt");
            string MaSV, MaHP;
            int Lan, Ki, NamHoc;
            double DiemQT, DiemKT, DiemTB;
            string s;
            //Đọc từng dùng dữ liệu trong tệp
            while ((s = sr.ReadLine()) != null)
            {
                //Tách các thuộc tính ở mỗi dòng
                string[] hp = s.Split('#');
                MaSV = hp[0];
                MaHP = hp[1];
                Lan = int.Parse(hp[2]);
                Ki = int.Parse(hp[3]);
                NamHoc = int.Parse(hp[4]);
                DiemQT = double.Parse(hp[5]);
                DiemKT = double.Parse(hp[6]);
                DiemTB = double.Parse(hp[7]);
                Diem Diem = new Diem();
                Diem.MaSV = MaSV;
                Diem.MaHP = MaHP;
                Diem.Lan = Lan;
                Diem.Ki = Ki;
                Diem.NamHoc = NamHoc;
                Diem.DiemQT = DiemQT;
                Diem.DiemKT = DiemKT;
                Diem.DiemTB = DiemTB;
                //Đưa dữ liệu của khoa vào trong list
                l.Add(Diem);
            }
            return l;
        }
        public string KiemTra(string Ma)
        {
            List<Diem> l = Doc();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaHP == Ma)
                    return l[i].MaSV + "#" + l[i].MaHP + "#" + l[i].Lan + "#" + l[i].NamHoc + "#" + l[i].DiemQT + "#" + l[i].DiemKT + "#" + l[i].DiemTB;
            }
            return "null";
        }
        public void Ghi(List<Diem> l)
        {
            StreamWriter sw = new StreamWriter("diem.txt");
            for (int i = 0; i < l.Count; i++)
            {
                sw.WriteLine( l[i].MaSV + "#" + l[i].MaHP + "#" + l[i].Lan + "#" + l[i].NamHoc + "#" + l[i].DiemQT + "#" + l[i].DiemKT + "#" + l[i].DiemTB);
            }
            sw.Close();
        }
        public void Them(Diem d)
        {
            List<Diem> l = Doc();
            l.Add(d);
            Ghi(l);
        }
        public void Sua(Diem d)
        {
            List<Diem> l = Doc();
            for(int i = 0;i<l.Count;i++)
            {
                if(l[i].MaSV == d.MaSV && l[i].MaHP ==d.MaHP && l[i].Lan ==d.Lan)
                {
                    l[i].Ki = d.Ki;
                    l[i].NamHoc = d.NamHoc;
                    l[i].DiemQT = d.DiemQT;
                    l[i].DiemKT = d.DiemKT;
                    l[i].DiemTB = d.DiemTB;
                }    
            }    
            Ghi(l);
        }
        public void Xoa(Diem d)
        {
            List<Diem> l = Doc();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].MaSV == d.MaSV && l[i].MaHP == d.MaHP && l[i].Lan == d.Lan)
                {
                    l.RemoveAt(i);
                    break;
                }
            }
            Ghi(l);
        }
        public List<Diem> Hien()
        {
            return Doc();
        }


    }
}
