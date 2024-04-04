using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;

namespace CustomerSupportTests;

public class SupportControllerTests
{
    [Fact]
    public void SubmitSupportRequest_AddsRequestAndRedirects()
    {
        // Arrange
        var mockTempData = new Mock<ITempDataDictionary>();
        var controller = new SupportController
        {
            TempData = mockTempData.Object
        };

        // Act
        var result = controller.SubmitSupportRequest("Test Problem", DateTime.Now.AddDays(1).ToString());

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("ViewAllRequests", redirectToActionResult.ActionName);
        Assert.Single(controller.GetRequestList()); // Assuming the controller adds to the mockList 
    }
    
    [Fact]
    public void DeleteRequest_RemovesRequest()
    {
        // Arrange
        var initialRequest = new SupportRequest { Id = 1, Body = "Test" };
        var controller = new SupportController(); // Add this request to your controller's list

        // Act
        controller.DeleteRequest(1);

        // Assert
        Assert.DoesNotContain(controller.GetRequestList(), r => r.Id == 1); // Adjust access to _requests as needed
    }

}