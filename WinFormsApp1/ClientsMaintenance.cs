using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace SalaDeGimnastica
{ 
public partial class ClientsMaintenance : Form
{
    ClientsList clients = new ClientsList();
    string path = Path.Combine(Environment.CurrentDirectory, @"Data\", "file.txt");
     
    public ClientsMaintenance()
    {
            InitializeComponent();
    }
    private void ListChanged(ClientsList c)
    {
        //update list box
        this.members.Items.Clear();
        for (int i = 0; i < c.Count; i++)
        {
            this.members.Items.Add(c[i].getDisplayText());
        }
        //save
        c.save(path);
    }

    private void clientAdded(Client c)
    {
        clients = clients + c;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        AddClient addWindow = new AddClient();
        addWindow.newClient += new AddClient.AddClientListener(clientAdded);
        addWindow.ShowDialog();

    }

    private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }


    private void DeleteButton_Click(object sender, EventArgs e)
    {
        int index = members.SelectedIndex;
        var confirmResult = MessageBox.Show("Are you sure to delete " + clients[index].getDisplayText(),
                                             "Confirm Delete!!",
                                             MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
            clients = clients - clients[index];


    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void ClientsMaintenance_Load(object sender, EventArgs e)
    {
        clients.write(path);
       
        clients.Changed += clientslist =>
        {
            //update list box
            this.members.Items.Clear();
            for (int i = 0; i < clientslist.Count; i++)
            {
                this.members.Items.Add(clientslist[i].getDisplayText());
            }
            //save
            clientslist.save(path);
        };

        //initialize list box
        for (int i = 0; i < clients.Count; i++)
        {
            this.members.Items.Add(clients[i].getDisplayText());
        }

        //this.members.Items.AddRange();
    }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("saladegimnastica.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, clients.getClientList());

            fs.Close();
        }

 

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach (Client c in clients.getClientList())
            {
                e.Graphics.DrawString(c.ToString(), Font, Brushes.Black, 20, 20);
            }
        }
 
        private void printDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void printPreviewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
             AddReservation addWindow = new AddReservation();
             addWindow.ShowDialog();

        }

        private void btn_attendance_list_Click(object sender, EventArgs e)
        {

            GymAttendance addWindow = new GymAttendance();
            addWindow.ShowDialog();
        }

        private void members_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
