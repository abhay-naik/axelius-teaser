using Axelius.Mediators.Commands;
using Axelius.Mediators.Decorators;
using Axelius.Mediators.Requests;
using Axelius.Storages.Keys;
using Axelius.Storages.SqlDb;
using NewApi.Commands.Models;

namespace NewFeebackApi.Commands;

[EnableApi("feedbacks", ApiMethod.POST,DisableAuthentication = true)]
public class StoreFeedback : Request
{
    [GenerateKey(typeof(Feedback))]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
}

public class StoreFeedbackHandler : IHandleCommand<StoreFeedback>
{
    private readonly ISqlRepository _sqlRepository;

    public StoreFeedbackHandler(ISqlRepository sqlRepository)
    {
        _sqlRepository = sqlRepository;
    }
    public async Task Handle(StoreFeedback request)
    {
        await _sqlRepository.Insert(new Feedback
        {
            Id = request.Id,
            Name = request.Name,
            Content = request.Content
        });
    }
}

