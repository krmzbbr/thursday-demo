using System;
using System.IO; //must include this to read or write from external file
using System.Text.Json;

namespace WeekSixThursdayFall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do you know the difference between an absolute and relative path?
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\mytext.txt"; //absolute paths only work with the exact same path!

            Console.WriteLine(path);

            //string relativePath = "MyTest.txt"; //This is an example of a relative path - put in same folder as .exe

            //File.Exists() will return a boolean (true or false) value

            //if (!File.Exists(path))
            //{
            //    // Create a file to write to.
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine("Hello");
            //        sw.WriteLine("And");
            //        sw.WriteLine("Welcome");
            //        sw.WriteLine("Class");
            //    }
            //}

            //// Open the file to read from.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    string location11Path = $"{AppDomain.CurrentDomain.BaseDirectory}\\location{i}.txt";
            //    string location11Content = GetContentFromDisk(location11Path);
            //    Console.WriteLine(location11Content);
            //}



            //string gamePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\gamedata.txt";
            //if (File.Exists(gamePath))
            //{
            //    string gameContent = File.ReadAllText(gamePath);
            //    Game game = JsonSerializer.Deserialize<Game>(gameContent);

            //}
            //Game game = new Game()
            //{
            //    PlayerName = "John",
            //    Score = 100
            //};
            //string gamePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\gamedata.txt";
            //if (!File.Exists(gamePath))
            //{
            //    string json = JsonSerializer.Serialize(game);
            //    File.WriteAllText(gamePath, json);
            //}

            //Used to read all text from a file
            string gameContent = File.ReadAllText("path to my game");

            //Used to read all text from a file
            File.WriteAllText("path to my game", "contents");



            Game game = new Game();
            game.LoadGame();

            Console.WriteLine($"Player Name: {game.PlayerName} Score: {game.Score}");

            Random random = new Random();
            game.Score = random.Next(100);


            game.GameName = "My New Game";

            game.SaveGame();


            Console.ReadLine();
        }

        public static string GetContentFromDisk(string path )
        {
            return File.ReadAllText(path);
        }
    }
}
