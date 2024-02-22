using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum eNusach { a =1, s=2, em=3 }


namespace MinyanApp.Core.Entities
{

    public class Synagogue
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public eNusach Nusach { get; set; }

        public bool IsVerified { get; set; } = false;

        public bool IsFavorite { get; set; } = false;

        public List<Minyan>? Minyans { get; set; }

        public List<User>? Users { get; set; }

        public Synagogue()
        {
            Minyans = new List<Minyan>();

            Users = new List<User>();   
        }
    }
}
