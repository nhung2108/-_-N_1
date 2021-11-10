using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.Business;

namespace QuanLyDiemSV.View
{
    class DangNhapView
    {
        DangNhapBus dnb = new DangNhapBus();
        public void DangNhap()
        {
            Console.Clear();
            string ch = "y";
            int i = -1;
            while (ch =="y")
            {
                Console.WriteLine("             PHAN MEM QUAN LY DIEM SINH VIEN             ");
                Console.Write("         Ten dang nhap: ");
                string Ma = ChuanHoa(Console.ReadLine());
                Console.Write("         Mat khau: ");
                string Pass = ChuanHoa(Console.ReadLine());
                i = dnb.KiemTra(Ma, Pass);
                if (i == -1)
                {
                    Console.WriteLine("Sai tai khoan hoac mat khau! Ban co muon dang nhap lai(y/n)?");
                    ch = ChuanHoa(Console.ReadLine());
                    continue;
                }
                else break;
            }    
            switch(i)
            {
                case 1:
                    Console.WriteLine("Dang Nhap Thanh Cong");
                    break;
            }    
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
