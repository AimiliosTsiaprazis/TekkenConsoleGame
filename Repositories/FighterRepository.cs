using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FightingGame.Models;

namespace FightingGame.Repositories
{
    class FighterRepository
    {
        private List<Fighter> fighters;

        public FighterRepository()
        {
            this.fighters = new List<Fighter>();
            seedFighters();
        }
        public void seedFighters()
        {
            this.fighters.Add(new Fighter("Kazuya", 100, 50, 5));
            this.fighters.Add(new Fighter("Heihachi", 110, 45, 10));
            this.fighters.Add(new Fighter("Paul", 120, 50, 5));
            this.fighters.Add(new Fighter("Marshall Law", 110, 40, 15));
            this.fighters.Add(new Fighter("Nina", 100, 40, 20));
            this.fighters.Add(new Fighter("Yosimitsu", 100, 60, 2));
            this.fighters.Add(new Fighter("King",120, 55, 20));
            this.fighters.Add(new Fighter("Lei", 105, 30, 30));
            this.fighters.Add(new Fighter("Jin", 100, 50, 5));
        }
        public List<Fighter> GetAll() => this.fighters;
        public Fighter GetByName(string name)
        {
            return this.fighters.FirstOrDefault(f => f.GetName == name);
        }
    }
}