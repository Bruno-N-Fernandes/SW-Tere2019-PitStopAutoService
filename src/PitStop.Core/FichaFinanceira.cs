using System;
using System.Collections.Generic;

namespace PitStop.Core
{
	public class FichaFinanceira
	{
		public Cliente Cliente { get; set; }
		public Plano Plano { get; set; }
		public DateTime Solicitacao { get; set; }
		public DateTime? Pagamento { get; set; }
		public decimal? ValorPago { get; set; }
		public List<Voucher> Vouchers { get; set; }
	}
}