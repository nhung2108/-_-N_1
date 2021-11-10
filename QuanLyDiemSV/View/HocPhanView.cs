using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Business;

namespace QuanLyDiemSV.View
{
    class HocPhanView
    {
        HocPhanBus dnb = new HocPhanBus();
        public void HocPhan()
        {
            Console.Clear();
            string ch = "y";
            string i = "";
            while (ch =="y")
            {
                Console.WriteLine("             PHAN MEM QUAN LY DIEM SINH VIEN             ");
                Console.Write("         Ten dang nhap: ");
                string Ma = ChuanHoa(Console.ReadLine());
                i = dnb.Ktra(Ma);
                if (i == "null")
                {
                    Console.WriteLine("Sai tai khoan hoac mat khau! Ban co muon dang nhap lai(y/n)?");
                    ch = ChuanHoa(Console.ReadLine());
                    continue;
                }
                else break;
            }
            Console.WriteLine(i);
        }
        private string ChuanHoa(string str)
        {
            str = str.Trim();
            str = str.ToLower();
            
            while(str.Contains(" "))
            {
                str=str.Replace(" ","");
            }    
            return str;
        }
    }
}
