using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClienteAPINT3.Models;

namespace ClienteAPINT3.Dados
{
    public class DB
    {
        public static List<Alunos> alunos = 
                                 new List<Alunos>()
        {
            new Alunos() { Codigo = 1, Nome = "Joao"},
            new Alunos() { Codigo = 2, Nome = "Maria"},
            new Alunos() { Codigo = 3, Nome = "Sandra"},
            new Alunos() { Codigo = 4, Nome = "Carlos"},
            new Alunos() { Codigo = 5, Nome = "Marlene"},
        };

        public static IEnumerable<Alunos> ListarAlunos()
        {
            return alunos;
        }

        public static IEnumerable<string> ListarMaterias()
        {
            return new List<string>()
            {
                "Matematica", "Historia", "Quimica"
            };
        }

    }
}