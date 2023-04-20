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
    public partial class FormAHP : Form
    {
        public FormAHP()
        {
            InitializeComponent();
        }

        private void FormAHP_Load(object sender, EventArgs e)
        {
            loadTruongAHP();
            tieuChiAHP();
        }
        private void loadTruongAHP()
        {
            HeHoTroRaQuyetDinhContext context = new HeHoTroRaQuyetDinhContext();
            List<TruongAhp> tr = context.TruongAhp.ToList();
            dataGridViewTrAHP.DataSource = tr;
        }
        private void tieuChiAHP()
        {
            HeHoTroRaQuyetDinhContext context = new HeHoTroRaQuyetDinhContext();
            // Lấy danh sách các tiêu chí từ CSDL
            List<TieuChi> listTieuChi = context.TieuChi.ToList();

           

          

            // Thêm các cột vào DataGridView
            dataGridViewTC.Columns.Add("empty", "");
            
            dataGridViewTC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // cột rỗng
            foreach (var tc in listTieuChi)
            {
                dataGridViewTC.Columns.Add(tc.TenTieuChi, tc.TenTieuChi);
                dataGridViewTC.Columns[dataGridViewTC.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Thêm các dòng vào DataGridView
            for (int i = 0; i < listTieuChi.Count; i++)
            {
                dataGridViewTC.Rows.Add();
                dataGridViewTC.Rows[i].HeaderCell.Value = listTieuChi[i].TenTieuChi;
            }

            // Cho phép người dùng nhập giá trị đánh giá vào các ô bên trong DataGridView
            for (int i = 0; i < listTieuChi.Count; i++)
            {
                for (int j = 1; j <= listTieuChi.Count; j++)
                {
                    var cell = dataGridViewTC.Rows[j - 1].Cells[i + 1];
                    cell.Value = 1;
                    cell.ReadOnly = i == j - 1;
                    cell.Style.BackColor = i == j - 1 ? System.Drawing.SystemColors.Control : System.Drawing.SystemColors.Window;
                }
            }


        }

        private void dataGridViewTC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridViewTC.RowCount - 1;
            double[,] matrix = new double[n, n]; // Ma trận so sánh cặp các tiêu chí
            double[] weightVector = new double[n]; // Vector trọng số các tiêu chí
            double[] similarityVector = new double[n]; // Vector độ tương đồng giữa các tiêu chí

            // Lấy giá trị trong DataGridView để cập nhật ma trận so sánh cặp các tiêu chí
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 1; // Đường chéo chính bằng 1
                    }
                    else
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridViewTC.Rows[i].Cells[j + 1].Value);
                        matrix[j, i] = 1 / matrix[i, j]; // Ma trận đối xứng
                    }
                }
            }

            // Tính vector trọng số các tiêu chí
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[j, i];
                }
                weightVector[i] = sum / n;
            }

            // Tính vector độ tương đồng giữa các tiêu chí
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += Math.Pow(matrix[i, j] - matrix[j, i], 2);
                }
                similarityVector[i] = Math.Sqrt(sum);
            }

            // Tính độ sai số của quyết định
            double inconsistency = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inconsistency += Math.Abs(matrix[i, j] - weightVector[i] / weightVector[j]);
                }
            }
            inconsistency *= (0.1 * (n - 1) * (n - 2) / (n * (n - 1)));

            // Hiển thị ma trận trọng số, vector trọng số, độ tương đồng giữa các tiêu chí, độ sai số của quyết định
            // trong các control tương ứng trên form
            // ...
            textBoxSaiSo.Text = inconsistency.ToString();
            // Tạo mới DataTable và thêm các cột tương ứng
            DataTable weightTable = new DataTable();
            DataTable similarityTable = new DataTable();
            weightTable.Columns.Add("Trọng số", typeof(double));
            similarityTable.Columns.Add("Độ tương đồng", typeof(double));

            // Thêm từng phần tử vào DataTable
            for (int i = 0; i < weightVector.Length; i++)
            {
                weightTable.Rows.Add(weightVector[i]);
                similarityTable.Rows.Add(similarityVector[i]);
            }

            // Gán DataTable cho DataSource của DataGridView
            dataGridView1.DataSource = weightTable;
            dataGridView2.DataSource = similarityTable;


        }

        private void buttonTT_Click(object sender, EventArgs e)
        {
        //    FormAHPPA a = new FormAHPPA();
        //    a.ShowDialog();
        //}
        //double[,] BuildDecisionMatrix(int maTieuChi)
        //{
        //    HeHoTroRaQuyetDinhContext context = new HeHoTroRaQuyetDinhContext();
        //    int numTruong = context.TruongAhp.Select(a => a.MaTruong).Distinct().Count();
        //    double[,] decisionMatrix = new double[numTruong, numTruong];

        //    // Lấy danh sách các trường
        //    List<string> dsTruong = context.TruongAhp.Select(a => a.MaTruong).Distinct().ToList();

        //    // Tính phần trăm cho mỗi trường đối với tiêu chí đang xét
        //    double[] phanTram = new double[numTruong];
        //    for (int i = 0; i < numTruong; i++)
        //    {
        //        phanTram[i] = (from a in context.TruongAhp
        //                       join b in context.TieuChi on a.MaTieuChi equals b.MaTieuChi
        //                       where a.MaTruong == dsTruong[i] && b.MaTieuChi == maTieuChi
        //                       select a.TyLe).FirstOrDefault();
        //    }

        //    // Tạo ma trận phương án
        //    for (int i = 0; i < numTruong; i++)
        //    {
        //        for (int j = 0; j < numTruong; j++)
        //        {
        //            if (i == j)
        //            {
        //                decisionMatrix[i, j] = 1.0;
        //            }
        //            else if (i < j)
        //            {
        //                double value = phanTram[i] / phanTram[j];
        //                decisionMatrix[i, j] = value;
        //                decisionMatrix[j, i] = 1.0 / value;
        //            }
        //        }
        //    }

        //    return decisionMatrix;
        }

    }
}
