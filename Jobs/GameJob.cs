using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FightingGame.Controllers;

namespace FightingGame.Jobs
{
    class GameJob
    {
        public void Run()
        {
            var GameController = new GameController();
            GameController.Start();
        }
    }
}