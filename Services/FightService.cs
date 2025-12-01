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
    class FightService
    {
        public void Fight(Fighter fighter1, Fighter fighter2)
        {
            System.Console.WriteLine($"Get Ready for the Next Battle: {fighter1.GetName} vs {fighter2.GetName}");

            while(fighter1.isAlive() && fighter2.isAlive())
            {
                Attack(fighter1, fighter2);
                if(!fighter2.isAlive())
                break;
                Attack(fighter2, fighter1);
            }
            var winner = fighter1.isAlive() ? fighter1.GetName : fighter2.GetName;
            System.Console.WriteLine($"Winner is: {winner}");
        }
        public void Attack(Fighter fighter1, Fighter fighter2)
        {
            var damage = Math.Max(fighter1.GetAttackPower - fighter2.GetDefence, 0);
            fighter2.GetHealth -= damage;
            System.Console.WriteLine($"{fighter1.GetName} attacks {fighter2.GetName} for {damage} damage.");
        }
    }
}