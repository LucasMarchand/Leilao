using Leilao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Leilao
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new LeilaoContext();

            #region seeding
            if (db.Usuarios.Count() == 0)
            {
                Seed(db);
            }
            #endregion

        }
        private static void Seed(LeilaoContext context)
        {
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario { Nome = "Josefredo", CPF = "99999999999", /*CNPJ = "", */ Email = "josefedro@hotmail.com" },
                new Usuario { Nome = "Lindomar", CPF = "99999999999", /*CNPJ = "", */ Email = "Lindomar@hotmail.com" },
                new Usuario { Nome = "Regina", CPF = "99999999999", /*CNPJ = "", */ Email = "Regina@hotmail.com" },
                new Usuario { Nome = "Maria", CPF = "99999999999", /*CNPJ = "", */ Email = "Maria@hotmail.com" },
                new Usuario { Nome = "Betônia", CPF = "99999999999", /*CNPJ = "", */ Email = "betonia@hotmail.com" }

                };

            context.Usuarios.AddRange(usuarios);
            context.SaveChanges();

        }
    }
}
