using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net7.Dtos.Weapon
{
    public class AddWeaponDto
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public int CharacterId { get; set; }
        
    }
}