using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Avatar { get; set; }

        public string Password { get; set; }

        public Location Location { get; set; }

        public bool IsGabai { get; set; }

        public Synagogue Synagogue { get; set; }

        //public List<Minyan> minyans { get; set; }
    }
}
