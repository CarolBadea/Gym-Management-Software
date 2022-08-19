using System;
using SalaDeGimnastica;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SalaDeGimnastica
{
  
    class ClientsList
    {
        private ArrayList listOfClients;
        int count;
        public delegate void changeHolder(ClientsList list);
        public event changeHolder Changed;

     
        public ClientsList()
        {
            listOfClients = new ArrayList();
            int count = 0;
        }


  
        public int Count
        {
            get
            {
                return this.count;
            }
        }
       
        public virtual void OnChanged(ClientsList e)
        {
            Changed?.Invoke(e);
        }

        
        public ClientsList(ArrayList list)
        {
            this.count = list.Count;
            this.listOfClients = list;
        }

      
        public Client this[int index]
        {
            get
            {
                return (Client)listOfClients[index];
            }
            set
            {
                listOfClients[index] = value;
                OnChanged(this);
            }
        }

        
        public void add(Client client)
        {
            listOfClients.Add(client);
            count++;
            OnChanged(this);
        }

        public void remove(Client client)
        {
            listOfClients.Remove(client);
            count--;
            OnChanged(this);
        }

        public void write(string path)
        {
            string[] lines = ClientData.GetClients(path);
            string[] data;
           
            char[] delimiterChars = { ' ', ',', '-', };

            foreach (string s in lines)
            {
                data = s.Split(delimiterChars);
                add(new Client(data[0], data[1], data[2]));
                

            }
        }

        public void save(string path)
        {
            //ArrayList export = new ArrayList();
            string[] export = new string[listOfClients.Count];
            int i = 0;
            foreach (Client client in listOfClients)
            {
                export[i] = (client.getDisplayText());
                i++;
            }

            //save to file
            ClientData.SaveClients(path, export);
        }

       
        public static ClientsList operator +(ClientsList clients, Client client)
        {
            clients.add(client);
            return clients;
        }

      
        public static ClientsList operator -(ClientsList clients, Client client)
        {
            clients.remove(client);
            return clients;
        }

        public ArrayList getClientList()
        { return listOfClients; }
    }
}
