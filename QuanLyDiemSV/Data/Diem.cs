using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.Data
{
    class Diem
    {
        private string maSV;
        private string maHP;
        private int lan;
        private int ki;
        private int namHoc;
        private double diemQT;
        private double diemKT;
        private double diemTB;

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public int Lan { get => lan; set => lan = value; }
        public int Ki { get => ki; set => ki = value; }
        public int NamHoc { get => namHoc; set => namHoc = value; }
        public double DiemQT { get => diemQT; set => diemQT = value; }
        public double DiemKT { get => diemKT; set => diemKT = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
    }
}
