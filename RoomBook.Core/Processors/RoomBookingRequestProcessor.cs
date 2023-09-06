using RoomBook.Core.Models.Domain;

namespace RoomBook.Core.Processors
{
  public class RoomBookingRequestProcessor
  {
    // public RoomBookingRequestProcessor()
    // {}

    public RoomBookingResult BookRoom(RoomBookingRequest bookingRequest)
    {
      return new RoomBookingResult
      {
        FirstName = bookingRequest.FirstName,
        LastName = bookingRequest.LastName,
        Email = bookingRequest.Email,
      };
    }
  }
}