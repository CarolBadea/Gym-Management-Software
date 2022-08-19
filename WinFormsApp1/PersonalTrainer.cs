
using SalaDeGimnastica;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeGimanastica
{
  public  class PersonalTrainer
    {
        private string name;
      

       public PersonalTrainer(string name)
        {
            this.name = name;
          
        }
        public PersonalTrainer()
        {
            name =" ";

        }
            public void setName(string name)
        {
            this.name = name;
        }
    }
}
