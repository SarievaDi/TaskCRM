using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JusanTaskCRM
{
    public abstract class Counterparty
    {
        public int ID { get; set; }
        public string BIN_IIN { get; set; }
        public string nameCreator { get; set; }
        public string nameEditor { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateEdit { get; set; }
    }
}
