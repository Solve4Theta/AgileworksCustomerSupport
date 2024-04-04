using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

public class SupportController : Controller
{
    private static List<SupportRequest> _requests = new List<SupportRequest>();
    private static int _nextId = 1;
    
    public SupportController()
    {
        _requests ??= new List<SupportRequest>();
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public List<SupportRequest> GetRequestList()
    {
        return _requests;
    }
    
    [HttpPost]
    public IActionResult DeleteRequest(int id)
    {
        var request = _requests.FirstOrDefault(r => r.Id == id);
        if (request != null)
        {
            _requests.Remove(request);
        }
        
        return RedirectToAction("ViewAllRequests");
    }

    [HttpPost]
    public IActionResult SubmitSupportRequest(string problemBody, string deadline)
    {
        var supportRequest = new SupportRequest
        {
            Id = _nextId++,
            Body = problemBody,
            SubmissionDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time")),
            Deadline = DateTime.Parse(deadline),
        };

        _requests.Add(supportRequest);
        _requests = _requests.OrderBy(r => r.Deadline).ToList();

       TempData["confirmationMessage"] = $"Thank you for submitting your request. Your support request number is: {supportRequest.Id}";
       
       return RedirectToAction("ViewAllRequests"); 
    }

    public IActionResult ViewAllRequests()
    {
        return View(_requests);
    }
}
