﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using BLL;
using GUI_CSharp.DTO;

namespace GUI_CSharp
{
    public partial class ThemTT : MaterialForm
    {
        ThanhTichBLL thanhTichBLL = new ThanhTichBLL();
        public ThemTT()
        {
            InitializeComponent();

            string maTT_New = thanhTichBLL.GenMaTT();
            txMaTT.Text = maTT_New;

            cbDiemCong.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cbDiemCong.SelectedIndex = 0; // Set default selected value

        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            ThanhTichDTO thanhTich = new ThanhTichDTO
            {
                MaThanhTich = txMaTT.Text,
                TenThanhTich = txTenTT.Text,
                DiemThuong = Convert.ToDouble(cbDiemCong.SelectedItem)

            };

            if (thanhTichBLL.AddThanhTich(thanhTich))
            {
                MessageBox.Show("Thêm thành tích thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thành tích thất bại!");
            }
        }
    }
}
