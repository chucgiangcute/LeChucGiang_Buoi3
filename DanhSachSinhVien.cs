using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Buoi3
{
    internal class DanhSachSinhVien
    {
        public string MSSV;
        public string Ten;
        public string GioiTinh;
        public DateTime NgaySinh;
        public string DiaChi;
        public void setMSSV(string MSSV)
        {
            this.MSSV = MSSV;
        }
        public string getMSSV()
        {
            return this.MSSV;
        }
        public void setTen(string Ten)
        {
            this.Ten = Ten;
        }
        public string getTen()
        {
            return this.Ten;
        }
        public void setGioiTinh(string GioiTinh)
        {
            this.GioiTinh = GioiTinh;
        }
        public string getGioiTinh()
        {
            return this.GioiTinh;
        }
        public void setNgaySinh(DateTime NgaySinh)
        {
            this.NgaySinh = NgaySinh;
        }
        public DateTime getNgaySinh()
        {
            return this.NgaySinh;
        }
        public void setDiaChi(string DiaChi)
        {
            this.DiaChi = DiaChi;
        }
        public string getDiaChi()
        {
            return DiaChi;
        }

        public DanhSachSinhVien() { } //Hàm khởi tạo ko có tham số

        public DanhSachSinhVien(string MSSV,string Ten,string GioiTinh,DateTime NgaySinh, string DiaChi) // Hàm khởi tạo có tham số
        {
            this.MSSV = MSSV;
            this.Ten = Ten;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh ;
            this.DiaChi = DiaChi ;

        }



    }
    
}
