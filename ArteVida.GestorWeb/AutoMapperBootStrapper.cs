using AutoMapper;
using ArteVida.GestorWeb.ViewModels;
using ArteVida.Dominio.Entidades;

namespace ArteVida.GestorWeb
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {

            //Mapper.CreateMap<TabelaAuxiliarViewModel, TabelaAuxiliar>();
            //Mapper.CreateMap<TabelaAuxiliar, TabelaAuxiliarViewModel>();

            //Mapper.CreateMap<PessoaViewModel, Pessoa>();
            //Mapper.CreateMap<Pessoa, PessoaViewModel>();

            //Mapper.CreateMap<AtletaViewModel, Atleta>();
            //Mapper.CreateMap<Atleta, AtletaViewModel>()
            //    .ForMember(d => d.TelefonePais, o => o.MapFrom(p => p.TelefonePai + " - " + p.TelefoneMae))
            //     .ForMember(d => d.NomePais, o => o.MapFrom(p =>  p.Pai +",  "+ p.Mae));

            //Mapper.CreateMap<IrmaoViewModel, Irmao>();
            //Mapper.CreateMap<Irmao, IrmaoViewModel>();

            //Mapper.CreateMap<InstrutorViewModel, Instrutor>();
            //Mapper.CreateMap<Instrutor, InstrutorViewModel>();





            //Mapper.CreateMap<ProdutoViewModel, Produto>();


            //Mapper.CreateMap<Produto, ProdutoViewModel>()
            //  .ForMember(d => d.sCusto1, o => o.MapFrom(p => p.Custo1.ToString() + " " + p.Fornecedor1))
            //  .ForMember(d => d.sCusto2, o => o.MapFrom(p => p.Custo2.ToString() + " " + p.Fornecedor2))
            //  .ForMember(d => d.sCusto3, o => o.MapFrom(p => p.Custo3.ToString() + " " + p.Fornecedor3))
            //  .ForMember(d => d.sCusto4, o => o.MapFrom(p => p.Custo4.ToString() + " " + p.Fornecedor4))
            //  .ForMember(d => d.sCusto5, o => o.MapFrom(p => p.Custo5.ToString() + " " + p.Fornecedor5));




        }
    }
}