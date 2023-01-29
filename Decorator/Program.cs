using Decorator;

var concrete = new ConcreteComponent();
var slackService = new SlackDecorator(concrete);
var smsService = new SMSDecorator(slackService);
smsService.Send("This is my message");