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

namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //chart1.Series.Add("lineChart");
            //chart1.Series["lineChart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //for (int i = 0; i < 10; i++)
            //{
            //    chart1.Series["lineChart"].Points.AddXY(i, i * 5);
            //}
        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            chart1.Series.Add("lineChart");
            chart1.Series["lineChart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < 10; i++)
            {
                chart1.Series["lineChart"].Points.AddXY(i, i * 5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //用于更改测试


            ///第二次更改了哈
            ///


            ///Add file 分支，基于主分支，先pull request但是不要去同意，看看有没有合并到主分支
            ///2024.12.22晚9点

            ///分支Geometry的更改，2024.12.22晚8点半

        }
    }
}
