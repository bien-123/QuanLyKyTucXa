﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCK_LTCSDL
{
    public partial class GSVThieuTienPhong : Form
    {
        public GSVThieuTienPhong()
        {
            InitializeComponent();
        }

        private void GSVThieuTienPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SVThieuTienPhong.tb_HDTienPhong' table. You can move, or remove it, as needed.
            this.tb_HDTienPhongTableAdapter.Fill(this.SVThieuTienPhong.tb_HDTienPhong);

            this.reportViewer1.RefreshReport();
        }
    }
}
