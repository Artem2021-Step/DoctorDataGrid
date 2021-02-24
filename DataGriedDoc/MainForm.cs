using DataGriedDoctor2HW.Models;
using DoctorDataGried.DAL.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGriedDoctor2HW
{
    public partial class MainForm : Form
    {
        public int PaginationIndex { get; set; }
        public int MaxLength { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            doctorScrollBar.Visible = false;
            PaginationIndex = 0;
            doctorScrollBar.Value = 0;


            using (Context context = new Context())
            {
                doctorScrollBar.Maximum = ((context.doctors.Count() / 20) * 9);
                MaxLength = doctorScrollBar.Maximum / 9;
                foreach (var item in context.doctors.Include(doc => doc.Department).Skip(20 * PaginationIndex).Take(20))
                {
                    string[] arr =
                    {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Department.Name
                    };

                    doctorDataGried.Rows.Add(arr);
                }
            }
        }
    }
}

