using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.View;

namespace QuanLyDiemSV
{
    class Program
    {
        static void Main(string[] args)
        {
            DangNhapView dnv = new DangNhapView();
            //HocPhanView hpv = new HocPhanView();
            dnv.DangNhap();
            Console.ReadLine();
        }
    }
}
