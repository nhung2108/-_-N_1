using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.DataAcess;
using QuanLyDiemSV.Data;

namespace QuanLyDiemSV.Business
{
    class DiemBus
    {
        DiemDA DiemDA = new DiemDA();
        public void Them(Diem diem)
        {
            DiemDA.Them(diem);
        }
        public void Sua(Diem diem)
        {
            DiemDA.Sua(diem);
        }
        public void Xoa(Diem diem)
        {
            DiemDA.Xoa(diem);
        }
        public List<Diem> Hien()
        {
            return DiemDA.Hien();
        }
        public List<Diem> Tim(string MaSV)
        {
            List<Diem> l = DiemDA.Hien();
            List<Diem> ldm = new List<Diem>();
            for (int i = 0; i < l.Count; i++)
            {
                if(l[i].MaSV == MaSV)
                {
                    ldm.Add(l[i]);
                }    
            }
            return ldm;
        }
    }
}
