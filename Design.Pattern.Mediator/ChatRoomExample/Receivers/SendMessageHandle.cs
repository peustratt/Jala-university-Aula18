using Design.Pattern.Command.Api.Receivers;
using Design.Pattern.Mediator.ChatRoomExample.Commands;
using Microsoft.Extensions.Caching.Memory;

namespace Design.Pattern.Mediator.ChatRoomExample.Receivers;

public class SendMessageHandle : IReceiver<MessageCommand, bool>
{
    private readonly IMemoryCache _memoryCache;

    public SendMessageHandle(IMemoryCache cache)
    {
        _memoryCache = cache;
    }

    public bool Handle(MessageCommand command)
    {
        var teamMember = _memoryCache.Get<TeamMember>(command.To.Name);
        teamMember.ReceiveMessage(command.From.Name, command.Message);
        return true;
    }
}