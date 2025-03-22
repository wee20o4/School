using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class QuanLyThongTinMuonTra : Form
    {
        public QuanLyThongTinMuonTra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_ghi.Enabled = false;
            groupBox1.Enabled = true;
            btn_themsach.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void QuanLyThongTinMuonTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet6.DMSACH' table. You can move, or remove it, as needed.
            this.dMSACHTableAdapter1.Fill(this.qLThuVienDataSet6.DMSACH);
            // TODO: This line of code loads data into the 'qLThuVienDataSet5.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter1.Fill(this.qLThuVienDataSet5.DOCGIA);
            
            LoardSach();
            lbl_tennv.Text = Form1.HoTenNV.ToString();


            string sqlloard = @"select dg.MaDG, dg.HoTen,dg.DonVi from DOCGIA dg";
            DataTable dtdulieu = DataProvider.LoadCSDL(sqlloard);
            BindingSource bd = new BindingSource();
            bd.DataSource = dtdulieu;
            cb_madocgia.DataSource = bd;
            cb_madocgia.DisplayMember = "MaDG";
            cb_madocgia.ValueMember = "MaDG";
            txt_hoteDG.DataBindings.Add("Text", bd, "HoTen");
            txt_donvi.DataBindings.Add("Text", bd, "DonVi");

            //string sql = "select * from DocGia";
            //BindingSource bd = new BindingSource();
            //DataTable dt = DataProvider.LoadCSDL(sql);
            //bd.DataSource = dt;

            //cb_madocgia.DataSource = bd;
            //cb_madocgia.DisplayMember = "MaDG";

            string sqlchitiet = @"select dms.Masach, dms.TenSach,dms.Nxb,dms.Tacgia,dmc.Macuon
                                from DMSACH dms, DMCUON dmc
                                where dms.Masach=dmc.Masach and dmc.Trangthai=0;";
            DataTable dt1 = DataProvider.LoadCSDL(sqlchitiet);
            BindingSource bd1 = new BindingSource();
            bd1.DataSource = dt1;
            cb_masach.DataSource = bd1;
            cb_masach.DisplayMember = "Masach";
            cb_masach.ValueMember = "Masach";
            txt_tensach.DataBindings.Add("Text", bd1, "TenSach");
            txt_nhaxuatban.DataBindings.Add("Text", bd1, "Nxb");
            txt_tentacgia.DataBindings.Add("Text", bd1, "Tacgia");
            cb_macuon.DataBindings.Add("Text", bd1, "MaCuon");

            //dgv_sach.Columns.Add("SoPhieu", "Số phiếu");
        }

        private void dgv_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoardSach();
        }

        private void LoardSach()
        {
            string sql = @"SELECT 
                        CTPHIEU.Macuon, 
                        DMSACH.TenSach, 
                        CTPHIEU.Ngayhentra
                    FROM 
                        CTPHIEU
                    INNER JOIN 
                        DMCUON ON CTPHIEU.Macuon = DMCUON.Macuon
                    INNER JOIN 
                        DMSACH ON DMCUON.Masach = DMSACH.Masach
                    WHERE 
                        DMCUON.Trangthai = 1;";
            DataTable dt=DataProvider.LoadCSDL(sql);
            dgv_sach.DataSource = dt;

            dgv_sach.Columns["Macuon"].HeaderText = "Mã Cuốn";
            dgv_sach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgv_sach.Columns["Ngayhentra"].HeaderText = "Ngày Hẹn Trả";
        }

        private void DefaultTxt()
        {
            txt_ngaymuon.Text = DateTime.Now.ToString("yyyy-MM-dd");
            string query = @"select Sophieu from PHIEUMUON";
            DataTable dt = DataProvider.LoadCSDL(query);
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                int highestSophieu = Convert.ToInt32(dt.Rows[0][0]);
                txt_sophieu.Text = (highestSophieu + 1).ToString();
            }
            else
            {
                txt_sophieu.Text = "";
            }
        }

        private void btn_themphieu_Click(object sender, EventArgs e)
        {
            DefaultTxt();
            btn_ghi.Enabled = true;
            btn_themphieu.Enabled = false;
            cb_madocgia.Enabled = false;
            txt_ngaymuon.Enabled=false;
            cb_madocgia.Enabled = true;
            txt_ngaymuon.Enabled = true;

        }

        private void btn_themsach_Click(object sender, EventArgs e)
        {
            btn_themsach.Enabled = false;
            cb_masach.Enabled = true ;
            cb_masach.Focus();
            datime_hantra.Enabled = true;
            btn_ghichitietphieu.Enabled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_masach.Enabled=false;
            datime_hantra.Enabled=false;
            groupBox1.Enabled = false;
            btn_ghi.Enabled=false;
            btn_ghichitietphieu.Enabled=false;
            btn_themsach.Enabled=false;
            cb_madocgia.Enabled=false;
            txt_ngaymuon.Text = "";
            txt_sophieu.Text = "";
            txt_ngaymuon.Enabled= false;
            txt_sophieu.Enabled=false;
            btn_themphieu.Enabled=true;
        }

        private void btn_ghichitietphieu_Click(object sender, EventArgs e)
        {
            string SoPhieu = txt_sophieu.Text;
            string NgayMuon = txt_ngaymuon.Text;
            string MaDocGia = cb_madocgia.Text;
            string MaSach = cb_masach.Text;
            string HanTra = datime_hantra.Text;
        }


      
    }
}
