using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string QuoteCharacter { get; set; }

        public string QuoteAnswer { get; set; }

        public Quote()
        {

        }
    }
}
