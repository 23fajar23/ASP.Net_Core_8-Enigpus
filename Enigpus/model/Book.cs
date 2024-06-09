using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigpus.model
{
    public abstract class Book
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string PublicationYear { get; set; }
        public abstract string GetTitle();
    }
}
