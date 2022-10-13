using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO; //must include this to read or write from external file
using System.Text.Json;

namespace WeekSixThursdayFall
{
    internal class Game
    {

        string gamePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\gamedata.txt";
        
        public int Score { get; set; }
        public string PlayerName { get; set; }

        public string GameName { get; set; }

        public Game()
        {


        }   

        public void LoadGame()
        {
            if (File.Exists(gamePath))
            {
                string gameContent = File.ReadAllText(gamePath);
                Game loadedGame = JsonSerializer.Deserialize<Game>(gameContent);
                Score = loadedGame.Score;
                PlayerName = loadedGame.PlayerName;
            }
        }

        
        public void SaveGame()
        {
            Game savedGame = new Game()
            {
                Score = Score,
                PlayerName = PlayerName
            };
            string json = JsonSerializer.Serialize(savedGame);
            File.WriteAllText(gamePath, json);
        }

    }
}
