using Decorator;

var concrete = new ConcreteComponent();
var slackService = new SlackDecorator(concrete);
var smsService = new SMSDecorator(slackService);

Client.ClientCode(smsService, "This Is My Message");