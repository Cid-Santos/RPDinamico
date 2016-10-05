using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPDinamico.ObjRelacional
{
    #region Classe Animal
    public class cachorro
    {
        private static cachorro instance;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        #region Carrega Classe interna Classificacao
        private cachorro()
        {
            this.Nome = "Dr. Bob";
            this.Idade = 2;
            this.Sexo = "Masculino";
        }
        #endregion

        public static cachorro Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new cachorro();
                }

                return instance;
            }
        }
    }
    #endregion
}
