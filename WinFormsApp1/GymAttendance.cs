using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalaDeGimnastica
{
    public partial class GymAttendance : Form
    {
        public GymAttendance()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            panel1.BackColor = Color.HotPink;
        }



        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(files[0]);
            MessageBox.Show("Your file was added");
            panel1.BackColor = Color.Pink;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Pink;

        }

    }
}

