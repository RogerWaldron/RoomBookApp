namespace RoomBook.Core.Models.Domain
{
  public class RoomBookingRequest
  {
    public string FirstName { get; set;} = string.Empty!;
    public string LastName { get; set;} = string.Empty!;
    public DateTime Date { get; set;} 
    public string Email { get; set;} = string.Empty!;
  }
}