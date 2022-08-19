using SalaDeGimanastica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalaDeGimnastica
{
    public partial class AddReservation : Form
    {
        PersonalTrainer pt;
        Rezervare rez;
        public delegate void AddPersonalTrainerListener(PersonalTrainer pt);
        public event AddPersonalTrainerListener NewPersonalTrainer;

        public AddReservation()
        {
            InitializeComponent();
        }
        public virtual void OnPersonalTrainerAdd(PersonalTrainer pt)
        {
            NewPersonalTrainer?.Invoke(pt);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker2.Value.ToShortDateString();
        }

        private void lb_pt_SelectedIndexChanged(object sender, EventArgs e)
        {
              string curItem = lb_pt.SelectedItem.ToString();
            pt = new PersonalTrainer();
            pt.setName(curItem);
            OnPersonalTrainerAdd(new PersonalTrainer(curItem));
            rez = new Rezervare();
            rez.add(pt);
          
            int index = lb_pt.FindString(curItem);
            
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox");
            //else
               // lb_pt.SetSelected(index, true);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reservation is booked");
        }
    }
}
