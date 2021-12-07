using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaOrientacaoObjetosMaoNaMassa.ContentContext
{
    //internal: Fica disponivel dentro do mesmo namespace
    public class Article : Content //derivado da classe base Content
    {
        public Article(string title, string url) : base(title, url)  
        {

        }
    }

}
