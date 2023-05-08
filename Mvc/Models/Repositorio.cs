using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }

        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta()
            { Nome = "gustavo", Email = "gustavo@gustavo", Sim = true });
            respostas.Add(new Resposta()
            { Nome = "gustavo1", Email = "gustavo1@gustavo", Sim = false });
            respostas.Add(new Resposta()
            { Nome = "gustavo2", Email = "gustavo2@gustavo", Sim = true });
            respostas.Add(new Resposta()
            { Nome = "gustavo3", Email = "gustavo3@gustavo", Sim = true });
            respostas.Add(new Resposta()
            { Nome = "gustavo4", Email = "gustavo4@gustavo", Sim = false });
            respostas.Add(new Resposta()
            { Nome = "gustavo5", Email = "gustavo5@gustavo", Sim = true });

        }
    }
}