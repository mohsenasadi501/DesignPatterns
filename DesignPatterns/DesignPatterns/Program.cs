using DesignPatterns.Memento;
using DesignPatterns.State;

Console.WriteLine("... Design Patters ...");


#region Mememto Pattern

Console.WriteLine("--> Mememto Pattern");

Editor editor = new Editor();
editor.Content = "1";
editor.CreateState(editor.Content);

editor.Content = "2";
editor.CreateState(editor.Content);

Console.WriteLine(editor.Restore());
Console.WriteLine(editor.Restore());

#endregion

#region State Pattern

Console.WriteLine("--> State Pattern");
Canvas canvas =  new Canvas(new BrushTool());
canvas.MouseUp();
canvas.MouseDown();

#endregion