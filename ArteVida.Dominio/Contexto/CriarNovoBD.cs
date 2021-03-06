﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Contexto
{
    public class CriarNovoBd : DropCreateDatabaseAlways<DbContexto>
    {
        protected override void Seed(DbContexto context)
        {
            var arqSql = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory,"my*.sql");
             
            foreach (string arq in arqSql)
            {
                try
                {
                    context.Database.ExecuteSqlCommand(File.ReadAllText(arq));

                }
                catch (Exception erro)
                {
                    
                    throw new Exception("Erro no Script de banco de dados"+ erro.Message);
                }
               
            }

            base.Seed(context);
        }
    }
}
