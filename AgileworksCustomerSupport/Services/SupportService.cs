public class SupportService
{
    private readonly List<SupportRequest> _requests = new List<SupportRequest>();
    private int _nextId = 1;

    public IEnumerable<SupportRequest> GetAllRequests()
    {
        return _requests;
    }

    public SupportRequest AddRequest(string body)
    {
        var request = new SupportRequest
        {
            Id = _nextId++,
            Body = body,
            SubmissionDate = DateTime.UtcNow
        };

        _requests.Add(request);
        return request;
    }
}