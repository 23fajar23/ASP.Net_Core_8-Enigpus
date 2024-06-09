using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigpus.model
{
    public class Magazine : Book
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public override string GetTitle()
        {
            return Title;
        }
    }
}
