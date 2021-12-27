using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int stylistId { get; set; }
        public string name { get; set; }
        public string details { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}