using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chestionar.model
{
    class Question
    {
        public Question()
        {
            ID = 0;
            Intrebare = "";
            Variante = new List<string>();
            Corecte = new List<string>();
        }

        public Question(Question question)
        {
            ID = question.ID;
            Intrebare = question.Intrebare;
            Variante = new List<string>(question.Variante);
            Corecte = new List<string>(question.Corecte);
        }

        public Question(int id, string intrebare, List<string> variante, List<string> corecte)
        {
            ID = id;
            Intrebare = intrebare;
            Variante = variante;
            Corecte = corecte;
        }

        public string Intrebare { get; set; }
        public int ID { get; set; }

        public List < string > Variante { get; set; }
        public List < string > Corecte { get; set; }        
    }
}
