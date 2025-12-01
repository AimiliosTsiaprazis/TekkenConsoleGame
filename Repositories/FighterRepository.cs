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
            this.fighters.Add(new Fighter("Kazuya Mishima", 130, 25, 18));
            this.fighters.Add(new Fighter("Heihachi Mishima", 140, 22, 20));
            this.fighters.Add(new Fighter("Jin Kazama", 120, 20, 15));
            this.fighters.Add(new Fighter("Hwoarang", 115, 23, 14));
            this.fighters.Add(new Fighter("Paul Phoenix", 150, 28, 17));
            this.fighters.Add(new Fighter("Marshall Law", 125, 21, 16));
            this.fighters.Add(new Fighter("King", 135, 24, 19));
            this.fighters.Add(new Fighter("Nina Williams", 110, 22, 13));
            this.fighters.Add(new Fighter("Anna Williams", 110, 21, 13));
            this.fighters.Add(new Fighter("Yoshimitsu", 120, 23, 15));
            this.fighters.Add(new Fighter("Lei Wulong", 115, 20, 14));
            this.fighters.Add(new Fighter("Ling Xiaoyu", 105, 18, 12));
            this.fighters.Add(new Fighter("Bryan Fury", 140, 27, 16));
            this.fighters.Add(new Fighter("Steve Fox", 110, 21, 14));
            this.fighters.Add(new Fighter("Asuka Kazama", 120, 20, 15));
            this.fighters.Add(new Fighter("Lars Alexandersson", 130, 24, 17));
            this.fighters.Add(new Fighter("Feng Wei", 125, 23, 16));
            this.fighters.Add(new Fighter("Bob", 140, 25, 18));
            this.fighters.Add(new Fighter("Jack-7", 150, 26, 20));
            this.fighters.Add(new Fighter("Kuma", 135, 22, 19));
            this.fighters.Add(new Fighter("Panda", 135, 22, 19));
            this.fighters.Add(new Fighter("King II", 135, 24, 19));
            this.fighters.Add(new Fighter("Dragunov", 120, 23, 15));
            this.fighters.Add(new Fighter("Devil Jin", 130, 26, 17));
            this.fighters.Add(new Fighter("Azazel", 160, 30, 20));
            this.fighters.Add(new Fighter("Alisa Bosconovitch", 110, 21, 14));
            this.fighters.Add(new Fighter("Claudio Serafino", 120, 22, 15));
            this.fighters.Add(new Fighter("Leo Kliesen", 115, 20, 14));
            this.fighters.Add(new Fighter("Shaheen", 120, 21, 16));
            this.fighters.Add(new Fighter("Lucky Chloe", 105, 18, 12));
            this.fighters.Add(new Fighter("Josie Rizal", 110, 20, 13));
            this.fighters.Add(new Fighter("Jack-8", 150, 26, 20));
            this.fighters.Add(new Fighter("Ganryu", 130, 22, 18));
            this.fighters.Add(new Fighter("Kunimitsu", 115, 21, 14));
            this.fighters.Add(new Fighter("Negan", 130, 25, 17));
        }
        public List<Fighter> GetAll() => this.fighters;
        public Fighter GetByName(string name)
        {
            return this.fighters.FirstOrDefault(f => f.GetName == name);
        }
    }
}