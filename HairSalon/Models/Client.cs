namespace HairSalon.Models
{
  public class Client
  {
    public int clientId { get; set; }
    public string clientname { get; set; }
    public int stylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}