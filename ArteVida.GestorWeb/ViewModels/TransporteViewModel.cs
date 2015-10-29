using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArteVida.Dominio.Utilitarios;

namespace ArteVida.GestorWeb.ViewModels
{
    public class JanelaViewModel
    {
        public JanelaViewModel()
        {
            Titulo = "Cadastro de (...Em construção)";
            Tela = "_GridBase";
            Relatorio = "RelatorioBase.trdx";
        }
        public JanelaViewModel(string titulo)
        {
            Titulo = $"Cadastro de {titulo}"; ;
            Tela = $"_Grid{titulo.SemAcentos()}";
            Relatorio = $"Relatorio{titulo.SemAcentos()}.trdx"; ;
        }
        public string Titulo { get; set; }
        public string Relatorio { get; set; }
        public string Tela { get; set; }
    }
}
