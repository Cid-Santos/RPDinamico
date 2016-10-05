using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPDinamico.ObjRelacional
{ 
    #region Classe Classificacao
    public class Classificacao_Cientifica
    {
        private static Classificacao_Cientifica instance;
        public string reino { get; set; }
        public string filo { get; set; }
        public string ordem { get; set; }
        public string Subordem { get; set; }
        public string classe { get; set; }
        public string familia { get; set; }
        public string genero { get; set; }
        public string especie { get; set; }
        public string Subespecie { get; set; }

        #region construtor carrega classe interna
        public Classificacao_Cientifica()
        {
            // Interna_Classificacao _classificacao = new Interna_Classificacao();
            this.reino = "Animalia";
            this.filo = "Chordata";
            this.ordem = "Carnivora";
            this.classe = "Mammalia";
            this.Subordem = "Caniformia";
            this.familia = "Canidae";
            this.genero = "Canis";
            this.especie = "C. lupus";
            this.Subespecie = "C. l. familiaris";
        }
        #endregion

        public static Classificacao_Cientifica Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Classificacao_Cientifica();
                }

                return instance;
            }
        }
    }
    #endregion
}
