using HHTRQDChonTuong.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HHTRQDChonTuong
{
    public partial class FormAHPPA : Form
    {
        public FormAHPPA()
        {
            InitializeComponent();
        }

        private void FormAHPPA_Load(object sender, EventArgs e)
        {

        }
        private void loadMaTranPA()
        {
            //HeHoTroRaQuyetDinhContext context = new HeHoTroRaQuyetDinhContext();

            //// Lấy danh sách các trường đại học từ bảng TruongAHP
            //List<string> dsTruong = context.TruongAhp.Select(r => r.MaTruong).ToList();

            //// Tạo ma trận đánh giá phương án cho tiêu chí HocPhi
            //double[,] maTranHocPhi = new double[dsTruong.Count, dsTruong.Count];

            //for (int i = 0; i < dsTruong.Count; i++)
            //{
            //    for (int j = 0; j < dsTruong.Count; j++)
            //    {
            //        if (i == j)
            //        {
            //            maTranHocPhi[i, j] = 1;
            //        }
            //        else if (i < j)
            //        {
            //            double phanTram = (from a in context.TruongAhp
            //                               join b in context.TieuChi on a.ma equals b.MaTieuChi
            //                               where a.MaTruong == dsTruong[i] && b.TenTieuChi == "HocPhi"
            //                               select a.GetType().GetProperty(dsTruong[j]).GetValue(a, null))
            //                                .FirstOrDefault();
            //            maTranHocPhi[i, j] = phanTram;
            //            maTranHocPhi[j, i] = 1 / phanTram;
            //        }
            //    }
            //}



        }
    }
}
