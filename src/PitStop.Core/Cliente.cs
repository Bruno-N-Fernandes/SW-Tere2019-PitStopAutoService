using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitStop.Core
{
    public class Cliente
    {
		public String Nome { get; set; }
		public String Telefone { get; set; }
		public List<FichaFinanceira> FichasFinanceiras { get; set; } = new List<FichaFinanceira>()
	}
}
