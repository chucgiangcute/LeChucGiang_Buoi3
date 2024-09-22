using System.Diagnostics.Eventing.Reader;

namespace LeChucGiang_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DanhSachSinhVien> li_sv = new List<DanhSachSinhVien>();

        private void btnnhap_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien sv = new DanhSachSinhVien(txtMssv.Text, txtTen.Text, txtGioiTinh.Text, dtNgaysinh.Value, txtDiaChi.Text);
            //MessageBox.Show( "MSSV:" +sv.getMSSV() +"\n Họ Tên:"+ sv.getTen() +"\n Giới Tính:"+ sv.getGioiTinh() + "\n Ngày Sinh:"+ sv.getNgaySinh() +"\n Địa Chỉ"+ sv.getDiaChi() );
            /*DanhSachSinhVien sv1 = new DanhSachSinhVien()
            sv1.setTen(txtTen.Text);
            sv1.setGioiTinh(txtGioiTinh.Text);
            sv1.setNgaySinh(dtNgaysinh.Value);
            sv1.setDiaChi(txtDiaChi.Text);*/

            li_sv.Add(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sv;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach(DanhSachSinhVien i in li_sv)
            {
                if (txtMssv.Text == i.MSSV)
                {
                    li_sv.Remove(li_sv[0]);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = li_sv;
                }
                  
            }
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
          
                
        }
    }
}
