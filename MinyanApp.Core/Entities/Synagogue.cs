using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum eNusach { a, s, em }


namespace MinyanApp.Core.Entities
{

    public class Synagogue
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public eNusach Nusach { get; set; }

        public bool IsVerified { get; set; }

        public List<Minyan> Minyans { get; set; }

        //public int UserId { get; set; }

        //public User User { get; set; }
    }
}
