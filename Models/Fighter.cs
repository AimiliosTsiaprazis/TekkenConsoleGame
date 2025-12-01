using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightingGame.Models
{
    class Fighter
    {
        private string Name;
        private int Health;
        private int AttackPower;
        private int Defence;
        private List<Move> Moves;

        public Fighter(string name, int health, int attackPower, int defence)
        {
            this.Name = name;
            this.Health = health;
            this.AttackPower = attackPower;
            this.Defence = defence;
            this.Moves = new List<Move>();
        }
        public string GetName
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int GetHealth
        {
            get { return this.Health; }
            set { this.Health = value; }
        }
        public int GetAttackPower
        {
            get { return this.AttackPower;}
            set { this.AttackPower = value;}
        }
        public int GetDefence
        {
            get { return this.Defence;}
            set { this.Defence = value;}
        }
        public bool isAlive()
        {
            if(this.Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddMove(Move move)
        {
            this.Moves.Add(move);
        }
        public void RemoveMove(Move move)
        {
            this.Moves.Remove(move);
        }
        public void showAllMoves()
        {
            foreach(Move move in this.Moves)
            {
                System.Console.WriteLine($"Move: {move.Name} Damage: {move.Damage}");
            }
        }
    }
}