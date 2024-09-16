namespace LeChucGiang_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien sv = new DanhSachSinhVien(txtMssv.Text, txtTen.Text, txtGioiTinh.Text,dtNgaysinh.Value,txtDiaChi.Text);
            MessageBox.Show( "MSSV:" +sv.getMSSV() +"\n Họ Tên:"+ sv.getTen() +"\n Giới Tính:"+ sv.getGioiTinh() + "\n Ngày Sinh:"+ sv.getNgaySinh() +"\n Địa Chỉ"+ sv.getDiaChi() );
            DanhSachSinhVien sv1 = new DanhSachSinhVien();
            sv1.setTen(txtTen.Text);
            sv1.setGioiTinh(txtGioiTinh.Text);
            sv1.setNgaySinh(dtNgaysinh.Value);
            sv1.setDiaChi(txtDiaChi.Text);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
