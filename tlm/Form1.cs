using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tlm
{
    public partial class Form1 : Form
    {
        tlmDataContext db = new tlmDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void load()
        {
            List<tbl_SinhVien> dssv = new List<tbl_SinhVien>();
            dssv = db.tbl_SinhViens.ToList();
            tlm_dtg.DataSource = dssv;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            tbl_SinhVien newObj = new tbl_SinhVien();
            newObj.MSSV = MSSV_txt.Text;
            newObj.HoTen = HoTen_txt.Text;
            newObj.GioiTinh = GioiTinh_txt.Text;
            newObj.NgaySinh = Convert.ToString(NgaySinh_dtp.Value);
            newObj.DiaChi = DiaChi_txt.Text;
            newObj.SDT = SDT_txt.Text;
            newObj.Email = Email_txt.Text;
            db.tbl_SinhViens.InsertOnSubmit(newObj);
            db.SubmitChanges();
            MessageBox.Show("Thêm mới thành công!");
            load();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            MSSV_txt.Text = "";
            HoTen_txt.Text = "";
            GioiTinh_txt.Text = "";
            NgaySinh_dtp.Text = "";
            DiaChi_txt.Text = "";
            SDT_txt.Text = "";
            Email_txt.Text = "";
        }

        private void tlm_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tlm_dtg.Rows[e.RowIndex];
            MSSV_txt.Text = row.Cells[0].Value.ToString();
            HoTen_txt.Text = row.Cells[1].Value.ToString();
            GioiTinh_txt.Text = row.Cells[2].Value.ToString();
            NgaySinh_dtp.Text = row.Cells[3].Value.ToString();
            DiaChi_txt.Text = row.Cells[4].Value.ToString();
            SDT_txt.Text = row.Cells[5].Value.ToString();
            Email_txt.Text = row.Cells[6].Value.ToString();
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            tbl_SinhVien suaObj = db.tbl_SinhViens.Where(d=> d.MSSV.Equals(MSSV_txt.Text)).FirstOrDefault();
            suaObj.MSSV = MSSV_txt.Text;
            suaObj.HoTen = HoTen_txt.Text;
            suaObj.GioiTinh = GioiTinh_txt.Text;
            suaObj.NgaySinh = Convert.ToString(NgaySinh_dtp.Value);
            suaObj.DiaChi= DiaChi_txt.Text;
            suaObj.SDT = SDT_txt.Text;
            suaObj.Email= Email_txt.Text;
            db.SubmitChanges();
            MessageBox.Show("Sửa thành công!");
            load();
        }

        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            tbl_SinhVien xoaObj = db.tbl_SinhViens.Where(p => p.MSSV.Equals(MSSV_txt.Text)).FirstOrDefault();
            db.tbl_SinhViens.DeleteOnSubmit(xoaObj);
            db.SubmitChanges();
            MessageBox.Show("Xóa thành công!");
            load();
        }
    }
}
