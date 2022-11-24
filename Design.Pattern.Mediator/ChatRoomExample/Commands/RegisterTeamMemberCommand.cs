using Design.Pattern.Command.Api.Commands;

namespace Design.Pattern.Mediator.ChatRoomExample.Commands;

public class RegisterTeamMemberCommand : ICommand<bool>
{
    public TeamMember TeamMember { get; set; }
}