using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FightingGame.Jobs;
using FightingGame.Models;
using FightingGame.Repositories;
using FightingGame.Services;

namespace FightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var GameJobTekken = new GameJob();
            GameJobTekken.Run();
        }
    }
}