using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightingGame.Models
{
    public enum MoveType
    {
        Normal,
        Special,
        Throw
    }
    class Move
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int StaminaCost { get; set; }
        public MoveType MoveType{ get; set; }
        public string Description { get; set; }

        public Move(string name, int damage, int staminaCost, MoveType moveType, string description)
        {
            this.Name = name;
            this.Damage = damage;
            this.MoveType = moveType;
            this.Description = description;
            this.StaminaCost = staminaCost;
        }
    }
}