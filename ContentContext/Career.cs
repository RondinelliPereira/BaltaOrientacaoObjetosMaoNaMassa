using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaOrientacaoObjetosMaoNaMassa.ContentContext
{
    public class Career : Content //derivado da classe base Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        public int TotalCourses
        {
            get
            {
                return Items.Count; 
            }
        }
    }

}