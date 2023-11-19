using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Template;
using DesignPatterns.Structural.Adaptor;
using DesignPatterns.Structural.Adaptor.Lib;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;

Console.WriteLine("... Design Patters ...");
Console.WriteLine("----------------------");


// Behavioral Design Patterns
#region Mememto Pattern

Console.WriteLine("--> Mememto Pattern");

Editor editor = new Editor();
editor.Content = "1";
editor.CreateState(editor.Content);

editor.Content = "2";
editor.CreateState(editor.Content);

Console.WriteLine(editor.Restore());
Console.WriteLine(editor.Restore());


Console.WriteLine("---------------");


#endregion

#region State Pattern

Console.WriteLine("--> State Pattern");
Canvas canvas = new Canvas(new BrushTool());
canvas.MouseUp();
canvas.MouseDown();

Console.WriteLine("---------------");

#endregion

#region Iterator Pattern

Console.WriteLine("--> Iterator Pattern");

BrowseHistory history = new BrowseHistory();
history.AddHistory("https://google.com");
history.AddHistory("https://mohsenasadi501.com");
history.AddHistory("https://yahoo.com");

var iterator = history.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}

Console.WriteLine("---------------");

#endregion

#region Strategy Pattern

Console.WriteLine("--> Strategy Pattern");

ImageStorage imageStorage = new ImageStorage();
imageStorage.Store("a", new PngCompressor());
imageStorage.Store("b", new JpegCompressor());

Console.WriteLine("---------------");

#endregion

#region Template Method

Console.WriteLine("--> Template Method Pattern");

TransferMoneyTask transferMoneyTask = new TransferMoneyTask();
transferMoneyTask.Execute();

Console.WriteLine("---------------");

#endregion

#region Command Pattern

Console.WriteLine("--> Command Pattern");

CustomerService customerService = new CustomerService();
ICommand command = new AddCustomerCommand(customerService);
Button button = new Button(command);
button.Click();

Console.WriteLine("---------------");

#endregion

#region Observer Pattern

Console.WriteLine("--> Observer Pattern");

DataSource dataSource = new DataSource();
SpreadSheet spreadSheet1 = new SpreadSheet();
SpreadSheet spreadSheet2 = new SpreadSheet();
Chart chart = new Chart();

dataSource.AddObserver(spreadSheet1);
dataSource.AddObserver(spreadSheet2);
dataSource.AddObserver(chart);

dataSource.Value = 1;

Console.WriteLine("---------------");

#endregion

#region Mediator Pattern

Console.WriteLine("--> Mediator Pattern");

// The client code.
Component1 component1 = new Component1();
Component2 component2 = new Component2();
new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggers operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();

Console.WriteLine("---------------");

#endregion

#region Chain Of Responsibility Pattern

Console.WriteLine("--> Chain Of Responsibility Pattern");

// authenticator -> logger -> compressor

Compressor compressor = new Compressor(null);
Logger logger = new Logger(compressor);
Authenticator authenticator = new Authenticator(logger);

WebServer webServer = new WebServer(authenticator);

webServer.Handle(new HttpRequest() { UserName = "admin", Password = "1234" });


Console.WriteLine("---------------");

#endregion


//Structural Design Patterns
#region Composite Pattern

Console.WriteLine("--> Composite Pattern");

var group1 = new Group();
group1.add(new Shape());
group1.add(new Shape());

var group2 = new Group();
group2.add(new Shape());
group2.add(new Shape());

var group = new Group();
group.add(group1);
group.add(group2);
group.render();

Console.WriteLine("---------------");

#endregion

#region Adaptor Pattern

Console.WriteLine("--> Adaptor Pattern");

ImageView imageView = new ImageView(new Image());
imageView.apply(new VividFilter());
imageView.apply(new CaramlFilter());

Console.WriteLine("---------------");

#endregion

#region Decorator Pattern 

Console.WriteLine("--> Composite Pattern");

// It will call write method like a tree
// EncryptedCloudStream -> CompressedCloudStream -> CloudStream

IStream stream = new EncryptedCloudStream(
    new CompressedCloudStream(new CloudStream()));
stream.Write("asd@#@$#RFSdfs");

Console.WriteLine("---------------");

#endregion

#region Facade Pattern

Console.WriteLine("--> Facade Pattern");

//var notificationServer = new NotificationServer();
//var connection = notificationServer.Connect("ip");
//var authToken = notificationServer.authentication("appId", "key");
//var message = new Message("Hello world");
//notificationServer.Send(authToken, message, "target");
//connection.Disconnect();

NotificationService notificationService = new NotificationService();
notificationService.Send("Hello", "ip");


Console.WriteLine("---------------");

#endregion

#region Flyweight Pattern

Console.WriteLine("--> Flyweight Pattern");

Console.WriteLine("---------------");

#endregion