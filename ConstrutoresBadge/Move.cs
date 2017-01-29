using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresBadge
{
    public class Move
    {

        public Move(string nomeMovimento)
        {
            this.MoveNome = nomeMovimento;
        }

        //o que um movimento de pokemon deve ter? descreva e defina como ele deve se comportar

        public string MoveNome { get; set; }
        
               
    }
}
