using RoomBook.Core.Models.Domain;
using RoomBook.Core.Processors;
using Shouldly;

namespace RoomBook.Core;

public class RoomBookingRequestProcessorTest
{
    [Fact]
    public void Should_Return_Room_Booking_Request()
    {
        // Arrange
        var processor = new RoomBookingRequestProcessor();

        var bookingRequest = new RoomBookingRequest
        {
            FirstName = "Fred",
            LastName = "Flintstone",
            Email = "Fred@Quarry.com",
            Date = new DateTime(2023, 1, 1)
        };

        // Act
        RoomBookingResult bookingResult = processor.BookRoom(bookingRequest);

        // Assert
        bookingResult.ShouldNotBeNull();
        bookingResult.FirstName.ShouldBe(bookingRequest.FirstName);
        bookingResult.LastName.ShouldBe(bookingRequest.LastName);
        bookingResult.Email.ShouldBe(bookingRequest.Email);
    }
}