using Design.Pattern.Command.Api;
using Design.Pattern.Mediator;
using Design.Pattern.Mediator.ChatRoomExample;
using Design.Pattern.Mediator.ChatRoomExample.Commands;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddMediator(typeof(Program));
services.AddMemoryCache();

var provider = services.BuildServiceProvider();
var mediator = provider.GetRequiredService<IMediator>();

var from = new Developer("Dev");
var to = new Tester("Tester");
var message = "Test message, it worked!";
mediator.Send(new RegisterTeamMemberCommand() { TeamMember = from });
mediator.Send(new RegisterTeamMemberCommand() { TeamMember = to });
mediator.Send(new MessageCommand() { From = from, To = to, Message = message });
    

