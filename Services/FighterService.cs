using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FightingGame.Models;
using FightingGame.Repositories;

namespace FightingGame.Services
{
    class FighterService
    {
        private FighterRepository fighterRepository;
        public FighterService(FighterRepository repository)
        {
            this.fighterRepository = repository;
        }
        public void DisplayFighters()
        {
            System.Console.WriteLine("Available Fighters:");
            foreach (var fighter in this.fighterRepository.GetAll())
            {
                System.Console.WriteLine(fighter.GetName);
            }
        }
    }
}