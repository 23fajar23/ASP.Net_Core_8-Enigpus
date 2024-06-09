using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigpus.model
{
    public class Novel : Book
    {
        public string Author { get; set; }
        public override string GetTitle()
        {
            return Title;
        }
    }
}
