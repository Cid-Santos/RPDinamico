using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPDinamico.ObjAnonimo
{
    public class clAnonima
    {
        #region Metodo para Serializacao de Objetos anonimos
        /// <summary>
        /// Metodo para serializa um objeto de tipo anonimo 
        /// </summary>
        /// <typeparam name="T">Tipo Anonimo</typeparam>
        /// <param name="Entidade">Objeto anonimo</param>
        /// <returns>Uma string no formato Json </returns>
        public string serialize<T>(T Entidade)
        {
            string output = JsonConvert.SerializeObject(Entidade);

            return output;
        }

        /// <summary>
        /// Metodo para serializa uma Lista de objeto de tipo anonimo 
        /// </summary>
        /// <typeparam name="T">Tipo Anonimo</typeparam>
        /// <param name="collection">Lista de objetos anonimos</param>
        /// <returns>Lista de string no formato Json</returns>
        public IList<string> serializeList<T>(IList<T> collection)
        {
            IList<string> output = new List<string>();
            int i = 0;
            foreach (var Entidade in collection)
            {
                output[++i] = JsonConvert.SerializeObject(Entidade);
            }

            return output;
        }
        #endregion

        #region Deserializacao de objetos Json
        /// <summary>
        /// Metodo para deserializar um objeto Json
        /// </summary>
        /// <typeparam name="T">Tipo Anonimo</typeparam>
        /// <param name="Entidade">Classe ou Tabela a ser populada</param>
        /// <param name="Dados">Dados serializados do tipo string</param>
        /// <returns>Retorna um objeto do tipo informado contendo todos os dados</returns>
        public T deserialize<T>(T Entidade, string Dados)
        {
            T output = JsonConvert.DeserializeObject<T>(Dados);
            return output;
        }
        
        /// <summary>
        /// Metodo para deseializar uma lista de Objetos no formato Json
        /// </summary>
        /// <typeparam name="T">Tipo Anonimo</typeparam>
        /// <param name="Entidade">Classe ou Tabela a ser populada</param>
        /// <param name="collection"></param>
        /// <returns></returns>
        public T deserialize<T>(T Entidade, IList<string> collection)
        {
            string Dados = string.Empty;
            foreach (var item in collection)
            {
                if (Dados.Length > 0)
                {
                    Dados = Dados.Replace("}", ",");
                    Dados += item.Replace("{", "");
                }
                else
                {
                    Dados = item;
                }
            }
            T output = JsonConvert.DeserializeObject<T>(Dados);
            return output;
        }
        #endregion        

     }
}
