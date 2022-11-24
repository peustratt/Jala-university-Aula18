using Design.Pattern.Command.Api.Commands;

namespace Design.Pattern.Mediator.ChatRoomExample.Commands;

public class MessageCommand : ICommand<bool>
{
    public TeamMember From { get; set; }
    public TeamMember To { get; set; }
    public string Message { get; set; }
}