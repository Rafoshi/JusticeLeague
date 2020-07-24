using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatSystem.Class
{
    class Heroe : Character
    {
        Heroe(string nome,
                string codinome,
                string especie,
                string habilidade,
                string vulnerabilidade,
                string nomeEquipamento,
                string descricao,
                string finalidade,
                int nivelDeAcesso)
        {
            this.Nome = nome;
            this.Codinome = codinome;
            this.Especie = especie;
            this.Habilidade = habilidade;
            this.Vulnerabilidade = vulnerabilidade;
            this.NomeEquipamento = nomeEquipamento;
            this.Descricao = descricao;
            this.Finalidade = finalidade;
            this.Nivel_de_acesso = nivelDeAcesso;
        }
    }
}
