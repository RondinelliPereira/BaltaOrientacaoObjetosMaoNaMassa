using BaltaOrientacaoObjetosMaoNaMassa.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaOrientacaoObjetosMaoNaMassa.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;

        internal static void Add(Subscription subscription)
        {
            throw new NotImplementedException();
        }
    }
}
