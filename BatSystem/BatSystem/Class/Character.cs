using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatSystem.Class
{
    abstract class Character
    {
        public string Nome { get; set; }
        public string Codinome { get; set; }
        public string Especie { get; set; }
        public string Habilidade { get; set; }
        public string Vulnerabilidade { get; set; }
        public string NomeEquipamento { get; set; }
        public string Descricao { get; set; }
        public string Finalidade { get; set; }
        public int Nivel_de_acesso { get; set; }
    }
}
