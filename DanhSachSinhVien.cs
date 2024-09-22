using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeChucGiang_Buoi3
{
    internal class DanhSachSinhVien
    {
        private string mSSV;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public DanhSachSinhVien() { } //Hàm khởi tạo ko có tham số

        public DanhSachSinhVien( string MSSV,string Ten,string GioiTinh,DateTime NgaySinh, string DiaChi) // Hàm khởi tạo có tham số
        {
            this.MSSV = MSSV;
            this.Ten = Ten;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh ;
            this.DiaChi = DiaChi ;

        }

        

        

    }
    
}
