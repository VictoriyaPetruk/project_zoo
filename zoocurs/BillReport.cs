﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Utils;
using FastReport.Data;
using FastReport.Design;
using FastReport.Design.StandardDesigner;

namespace zoocurs
{
    public partial class BillReport : Form
    {
        public BillReport()
        {
            InitializeComponent();
        }
        FastReport.Preview.PreviewControl pc = new FastReport.Preview.PreviewControl();

        private void BillReport_Load(object sender, EventArgs e)
        {
            pc.Size = new Size(this.Size.Width, this.Size.Height);
            this.Controls.Add(pc);
            Report report = new Report();
        
            report.Load("billreport.frx");
            report.Preview = pc;
            report.Show();
        }
    }
}
