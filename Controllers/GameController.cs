using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FightingGame.Repositories;
using FightingGame.Services;

namespace FightingGame.Controllers
{
    class GameController
    {
        private FighterService _fighterService;
        private FightService _fightService;
        private FighterRepository _fighterRepository;

        public GameController()
        {
            _fighterRepository = new FighterRepository();
            _fighterService = new FighterService(_fighterRepository);
            _fightService = new FightService();
        }

        public void Start()
        {
             _fighterService.DisplayFighters();

            Console.WriteLine("\nChoose Fighter 1:");
            var f1Name = Console.ReadLine();
            var fighter1 = _fighterRepository.GetByName(f1Name);

            Console.WriteLine("Choose Fighter 2:");
            var f2Name = Console.ReadLine();
            var fighter2 = _fighterRepository.GetByName(f2Name);

            if (fighter1 == null || fighter2 == null)
            {
                Console.WriteLine("Invalid fighter names. Exiting...");
                return;
            }

            _fightService.Fight(fighter1, fighter2);
        }
    }
}