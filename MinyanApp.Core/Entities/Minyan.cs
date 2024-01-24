using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum eSpeed { slow, normel, fast }


namespace MinyanApp.Core.Entities
{

    public class Minyan
    {
        public int Id { get; set; }

        public Synagogue Synagogue { get; set; }

        public Location Loction { get; set; }

        public eNusach Nusach { get; set; }

        public TimeSpan Time { get; set; }

        public bool IsFixed { get; set; }

        public eSpeed Speed { get; set; }

        //public List<User> Users { get; set; }
    }
}
