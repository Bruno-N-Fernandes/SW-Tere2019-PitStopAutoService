using System;

namespace PitStop.Core
{
	public class Voucher
	{
		public Int64 Id { get; set; }
		public FichaFinanceira FichaFinanceira { get; set; }
		public DateTime Gerado { get; set; }
		public DateTime? Utilizado { get; set; }
		public Parceiro Parceiro { get; set; }

	}
}