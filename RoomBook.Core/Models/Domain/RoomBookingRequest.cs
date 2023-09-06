namespace RoomBook.Core.Models.Domain
{
  public class RoomBookingRequest
  {
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public DateTime Date { get; set;}
    public string Email { get; set;}
  }
}