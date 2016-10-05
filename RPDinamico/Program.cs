using RPDinamico.ObjAnonimo;
using RPDinamico.ObjRelacional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            clAnonima _Anonima = new clAnonima();
        
            //Quando preenchido contera nomes e valores dos objetos sereializados
            string StringAnonimo = string.Empty;  

            #region Criando o Objeto Anonimo
            var c = new
            {
                Nome = cachorro.Instance.Nome,
                Idade = cachorro.Instance.Idade,
                Sexo = cachorro.Instance.Sexo,
                reino = Classificacao_Cientifica.Instance.reino,
                filo = Classificacao_Cientifica.Instance.filo,
                ordem = Classificacao_Cientifica.Instance.ordem,
                classe = Classificacao_Cientifica.Instance.classe,
                familia = Classificacao_Cientifica.Instance.familia,
                genero = Classificacao_Cientifica.Instance.genero,
                especie = Classificacao_Cientifica.Instance.especie
            };
            #endregion

            if (c != null)
            {                
                StringAnonimo = _Anonima.serialize(c); //Serializa um tipo anonimo
            }
            //Obijetos do tipo anonimo não podem ser convertido em para objeto tipados
            //Classificacao_Cientifica IClassificacao = (Classificacao_Cientifica)c;

            //Descerializa os dados em dois objetos tipados apartir de um objeto de tipo Anonimo serializado
            Classificacao_Cientifica IClassificacao = _Anonima.deserialize(Classificacao_Cientifica.Instance, StringAnonimo);
            cachorro Icachorro = _Anonima.deserialize(cachorro.Instance, StringAnonimo);

            Console.Write("Nome : " +
                          Icachorro.Nome +
                          "\n" +
                          "Sexo : " +
                          Icachorro.Sexo +
                          "\n" +
                          "Idade : " +
                          Icachorro.Idade +
                          "\n" +
                          "Genero : " +
                          IClassificacao.genero +
                          "\n" +
                          "Especie : " +
                          IClassificacao.especie +
                          "\n" +
                          "Familia : " +
                          IClassificacao.familia
                          );

            Console.ReadLine();
        }
    }
}
