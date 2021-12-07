using BaltaOrientacaoObjetosMaoNaMassa.ContentContext.Enums;
using BaltaOrientacaoObjetosMaoNaMassa.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaOrientacaoObjetosMaoNaMassa.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public String Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}

