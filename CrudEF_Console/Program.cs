using CrudEF_Console.Dados;
using CrudEF_Console.Dados.Extensions;
using CrudEF_Console.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudEF_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            // Operações
            // CRUD

            // INSERT GERAIS

            // Departamento
            //using (var contextoDepartamento = new CRUDEF_Context())
            //{
            //    var dep = new Departamento();
            //    dep.Descricao = "AstroFísica";

            //    contextoDepartamento.Departamentos.Add(dep);

            //    contextoDepartamento.LogSQLToConsole();
            //    contextoDepartamento.SaveChanges();

            //}


            // Veiculo Publicação
            //using (var contextoVeiculoPublicacao = new CRUDEF_Context())
            //{
            //    var vp = new Veiculo_Publicacao();
            //    vp.tipo = "Jornal";
            //    vp.descricao = "John Nash Journal";
            //    //vp.dataPublicacao = new DateTime(2018, 10, 15);


            //    contextoVeiculoPublicacao.VeiculoPublicacoes.Add(vp);

            //    contextoVeiculoPublicacao.LogSQLToConsole();

            //    contextoVeiculoPublicacao.SaveChanges();

            //}


            // Idioma
            //using (var contextoIdioma = new CRUDEF_Context())
            //{

            //    var idioma = new Idioma();
            //    idioma.Descricao = "RU";

            //    contextoIdioma.Idiomas.Add(idioma);

            //    contextoIdioma.LogSQLToConsole();

            //    contextoIdioma.SaveChanges();


            //}


            // Inserir Pesquisador com o Departamento(FK)
            //using (var contextoPesquisador = new CRUDEF_Context())
            //{

            //    var pesq = new Pesquisador();
            //    pesq.Nome = "Albert Einstein";

            //    var dep = new Departamento();
            //    dep = contextoPesquisador.Departamentos.FirstOrDefault(p => p.Descricao == "Estatística Aplicada");

            //    pesq.Departamento = dep;

            //    contextoPesquisador.Pesquisadores.Add(pesq);

            //    contextoPesquisador.LogSQLToConsole();

            //    contextoPesquisador.SaveChanges();

            //}


            // Contato
            //using (var contextoContato = new CRUDEF_Context())
            //{

            //    var pesq = contextoContato.Pesquisadores.FirstOrDefault(c => c.Id == 1);

            //    pesq.Contatos.Add(
            //                new Contato() { tipo = "email", texto = "stellalourmbakoslima@gmail.com" }
            //        );

            //    contextoContato.LogSQLToConsole();

            //    contextoContato.SaveChanges();

            //}


            //  Artigo
            //using (var contextoArtigo = new CRUDEF_Context())
            //{

            //    var pesq = contextoArtigo.Pesquisadores.FirstOrDefault(c => c.Id == 2);

            //    var veipublic = contextoArtigo.VeiculoPublicacoes.FirstOrDefault(c => c.Id == 2);

            //    var idiomaOriginal = contextoArtigo.Idiomas.FirstOrDefault(c => c.Id == 2);
            //    //var idiomaTraduzido = contextoArtigo.Idiomas.FirstOrDefault(c => c.Id == 3);

            //    var artigo = new Artigo();

            //    artigo.titulo = "WormHoles: How to Create it!";
            //    artigo.ano = 2018;

            //    artigo.Pesquisador = pesq;
            //    artigo.veiculo_publicacao = veipublic;
            //    artigo.idiomaOriginal = idiomaOriginal;
            //    //artigo.idiomaTraduzido = idiomaTraduzido;

            //    artigo.dataPublicacao = new DateTime(2018, 10, 18);
            //    artigo.ISBN = "B123";

            //    contextoArtigo.Artigos.Add(artigo);

            //    contextoArtigo.LogSQLToConsole();

            //    contextoArtigo.SaveChanges();

            //}

            // UPDATES GERAIS
            //Update em Pesquisador: Alteração do Departamento
            //using (var contexto = new CRUDEF_Context())
            //{

            //    var pesq = contexto.Pesquisadores.FirstOrDefault(c => c.Id == 2);

            //    var dep = contexto.Departamentos.FirstOrDefault(p => p.Id == 5);

            //    pesq.Departamento = dep;

            //    contexto.LogSQLToConsole();

            //    contexto.SaveChanges();

            //}

            // Alterar algum contato do Pesquisador
            //using (var contexto = new CRUDEF_Context())
            //{

            //    // Já tenho o pesquisador selecionado
            //    var pesq = contexto.Pesquisadores.FirstOrDefault(c => c.Id == 2);
            //    Console.WriteLine("Pesquisador: ", pesq);

            //    var pesquisador = contexto.Pesquisadores.Include(p => p.Contatos).FirstOrDefault(p => p.Id == 2);

            //    if (pesquisador.Contatos.Count == 0)
            //    {
            //        Console.WriteLine("Pesquisador não tem Contatos!");
            //        Environment.Exit(0);
            //    }

            //    foreach (var contato in pesquisador.Contatos)
            //    {
            //        if (contato.tipo.Equals("teleone") ){

            //            Console.WriteLine(contato);
            //            contato.tipo = "Telefone";
            //            contato.texto = "(12) 3902-8096";

            //            contexto.SaveChanges();

            //        }


            //    }


            //}

            //Alterar o artigo: Alterar o veiculo de publicação e o idioma dos artigos / nome do pesquisador
            // e data de publicação

            //pq no select vc nunca filtra
            //pra filtrar eh o where
            //o select vc diz o que vc quer do resultado

            //using (var contexto =new CRUDEF_Context())
            // {

            //var artigos = contexto.Artigos.ToList();

            //contexto.LogSQLToConsole();
            //var artigoX = contexto.Artigos
            //        .Include(p => p.Pesquisador)
            //        .Include(vp => vp.veiculo_publicacao)
            //        .Include(i => i.idiomaOriginal)
            //        .Include(i1 => i1.idiomaTraduzido)
            //        .FirstOrDefault(a => a.ISBN == "B123");



            //Console.WriteLine(artigoX);

            //var pesquisador = contexto.Pesquisadores.FirstOrDefault(p => p.Id == 2);
            //artigoX.Pesquisador = pesquisador;
            //contexto.SaveChanges();



            //foreach (var artigo in artigos)
            //{

            //    if (artigo.ISBN.Equals("B123"))
            //    {
            //        artigo.dataPublicacao = new DateTime(2018, 10, 17);

            //        var idiomaOriginal = contexto.Idiomas.FirstOrDefault(c => c.Id == 3);
            //        artigo.idiomaOriginal = idiomaOriginal;

            //        var pesquisador = contexto.Pesquisadores.FirstOrDefault(p => p.Id == 4);
            //        artigo.Pesquisador = pesquisador;

            //        var veipublic = contexto.VeiculoPublicacoes.FirstOrDefault(c => c.Id == 3);
            //        artigo.veiculo_publicacao = veipublic;

            //        contexto.SaveChanges();

            //    }

            //    //Console.WriteLine(artigo);

            //}

            //}

            // Operações DELETE
            // Idioma
            //using (var contexto = new CRUDEF_Context())
            //{
            //    var idiomaRusso = contexto.Idiomas.FirstOrDefault(i => i.Descricao == "RU");

            //    contexto.Idiomas.Remove(idiomaRusso);
            //    contexto.LogSQLToConsole();

            //    contexto.SaveChanges();


            //}

            // Contato
            //using (var contexto = new CRUDEF_Context()) // Using
            //{

            //    try
            //    {

            //        var pesquisador = contexto.Pesquisadores.Include(p => p.Contatos).FirstOrDefault(p => p.Id == 1);

            //        if (pesquisador.Contatos.Count == 0)
            //        {
            //            Console.WriteLine("Pesquisador não tem Contatos!");
            //            Environment.Exit(0);
            //        }

            //        foreach (var contato in pesquisador.Contatos)
            //        {
            //            if (contato.tipo.Equals("email"))
            //            {

            //                contexto.Set<Contato>().Remove(contato);

            //                contexto.LogSQLToConsole();

            //                contexto.SaveChanges();
            //                break;

            //            }


            //        }


            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //} // Using

            // Algumas consultas com select e where
            using (var contextoConsulta = new CRUDEF_Context())
            {

                string nomeRevista = "Plank´s Magazine";

               // var vpRevistaApenas = 
                    //contextoConsulta.VeiculoPublicacoes.Where(vp1 => vp1.tipo == "Revista");

                var vpRevistaApenas =
                 contextoConsulta.VeiculoPublicacoes.Where(vp1 => vp1.descricao.Contains(nomeRevista) );

                foreach (var revista in vpRevistaApenas)
                {
                    Console.WriteLine(revista);

                }

            }


        }
    }
}
