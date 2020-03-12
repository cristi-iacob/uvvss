using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chestionar.model
{
    class Quiz
    {
        public Quiz()
        {
            Questions = new List<Question>();
            Corecte = 0;
            Gresite = 0;
            ID = 1;
            Nummer = 1;
        }
        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Corecte = 0;
            Gresite = 0;
            ID = 1;
            Nummer = 1;
        }

        public List < chestionar.model.Question > Questions { get; set; }
        public int Corecte { get; set; }
        public int Gresite { get; set; }
        public int ID { get; set; }
        public int Nummer { get; set; }

    }
}
