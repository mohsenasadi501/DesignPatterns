// See https://aka.ms/new-console-template for more information
using DesignPatterns.Memento;

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