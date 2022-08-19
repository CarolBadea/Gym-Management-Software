using System;
using SalaDeGimnastica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeGimnastica
{
    public partial class AddClient : Form
    {

        ClientsList clients = new ClientsList();
        string path = Path.Combine(Environment.CurrentDirectory, @"Data\", "file.txt");
        public delegate void AddClientListener(Client c);
        public event AddClientListener newClient;

        public virtual void OnClientAdd(Client client)
        {
            newClient?.Invoke(client);
        }

        public AddClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (ValidateEmail.EmailIsValid(this.textBox3_email.Text))
                { 
                OnClientAdd(new Client(this.textBox_nume.Text, this.textBox_birthdate.Text, this.textBox3_email.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email!");
            }


        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            clients.write(path);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
