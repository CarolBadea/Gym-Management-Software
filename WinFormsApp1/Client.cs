using SalaDeGimnastica;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeGimnastica
    {
    public class Client
    {

        private string name;
        private string birthDate;
        private string email;      
   

       
        public Client()
        {
            this.Name = "";
            this.BirthDate = "";
            this.email = "";


        }

        public Client(string name, string birthDate, string email)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.email=email;
           
           }

        public string Name { 
            get
            {
                return this.name;
            
            }

            set
            {
                if (value.Length > 25)
                    throw new System.ArgumentException("String parameter cannot exceed 25 characters.", "name");
                else
                    this.name = value; }
        
        }
        public string BirthDate
        {
            get
            {
                return this.birthDate;

            }

            set
            {
                if (value.Length > 25)
                    throw new System.ArgumentException("String parameter cannot exceed 25 characters.", "birthdate");
                else
                    this.birthDate = value;
            }
        }

        public String Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Length > 25)
                    throw new System.ArgumentException("String parameter cannot be longer than 25 characters.", "email");
                else
                    this.email = value;
            }
        }


        public string getDisplayText()
        {
            return this.name+ " " + this.birthDate+ " - " + this.email;
        }
    }

    
}
