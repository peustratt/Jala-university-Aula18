using Design.Pattern.Command.Api.Receivers;
using Design.Pattern.Mediator.ChatRoomExample.Commands;
using Microsoft.Extensions.Caching.Memory;

namespace Design.Pattern.Mediator.ChatRoomExample.Receivers;

public class RegisterHandle : IReceiver<RegisterTeamMemberCommand, bool>
{
    private readonly IMemoryCache _memoryCache;

    public RegisterHandle(IMemoryCache cache)
    {
        _memoryCache = cache;
    }
    
    public bool Handle(RegisterTeamMemberCommand command)
    {
        _memoryCache.GetOrCreate(command.TeamMember.Name, entry =>
        {
            entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(1));

            return command.TeamMember;
        });
        
        return true;
    }
}
