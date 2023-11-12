using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;

Console.WriteLine("... Design Patters ...");
Console.WriteLine("----------------------");


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