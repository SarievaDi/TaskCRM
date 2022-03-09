using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JusanTaskCRM
{
    public class Entity : Counterparty
    {
        public string OragnizationName { get; set; }
        public string OragnizationAddress{ get; set; }
        public string JuridicalPersonLastName { get; set; }
        public string JuridicalPersonFirstName { get; set; }
        public string JuridicalPersonMiddlName { get; set; }
        //public Individual individualContact { get; set; }
        public List<Individual> individualContact { get; set; }


        public Entity(int id, string Oragnization, string Address, string LastName, string FirstName, string MiddleName, string bin_iin, string Creator, string Editor, DateTime? Create, DateTime? Edit, List<Individual> ContactName)
        {
            ID = id;
            OragnizationName = Oragnization;
            OragnizationAddress = Address;
            JuridicalPersonLastName = LastName;
            JuridicalPersonFirstName = FirstName;
            JuridicalPersonMiddlName = MiddleName;
            BIN_IIN = bin_iin;
            nameCreator = Creator;
            nameEditor = Editor;
            DateEdit = Edit;
            DateCreate = Create;
            individualContact = ContactName;
        }


    }
}
