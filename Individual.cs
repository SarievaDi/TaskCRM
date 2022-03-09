using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JusanTaskCRM
{
    public class Individual : Counterparty
    {
        public string IndividualLastName { get; set; }
        public string IndividualFirstName { get; set; }
        public string IndividualMiddleName { get; set; }
        public Individual(int id, string LastName, string FirstName, string MiddleName, string bin_iin, string Creator, string Editor, DateTime? Create, DateTime? Edit)
        {
            ID = id;
            IndividualLastName = LastName;
            IndividualFirstName = FirstName;
            IndividualMiddleName = MiddleName;
            BIN_IIN = bin_iin;
            nameCreator = Creator;
            nameEditor = Editor;
            DateEdit = Edit;
            DateCreate = Create;
        }

        public string GetFullNameIndividual()
        {
            return $"{IndividualLastName} {IndividualFirstName} {IndividualMiddleName}";
        }

    }
}
