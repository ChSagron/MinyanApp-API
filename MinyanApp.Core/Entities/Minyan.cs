using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ePrayer { shachrith =1 , mincha , arvith }
//public enum eSpeed { slow =1, normel, fast }



namespace MinyanApp.Core.Entities
{

    public class Minyan
    {
        public int Id { get; set; }

        public ePrayer Prayer { get; set; }

        public Synagogue? Synagogue { get; set; }

        public Location? Loction { get; set; }

        public eNusach? Nusach { get; set; }

        public bool IsFixed { get; set; }

        public DateTime? DateTime { get; set; }



        //public eSpeed Speed { get; set; }
        //public List<User> Users { get; set; }
    }
}
