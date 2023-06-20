using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffePoltekSSN
{
    internal class Order
    {
        public Guid Id { get; set; }
        public string Item { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Sugar { get; set; } = string.Empty;
        public string Ice { get; set; } = string.Empty;
        public string Top { get; set; } = string.Empty;
        public string Qty { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public DateTime Waktu { get; set; }
    }
}
