using System;
using System.Collections.Generic;

namespace PitStop.Core
{
	public class Campanha
	{
		public Parceiro Parceiro { get; set; }
		public int QuantidadeDePublico { get; set; }
		public string TextoDaCampanha { get; set; }
		public DateTime? DataHoraCampanha { get; set; }

		public decimal Custo { get; set; }
		public DateTime Solicitacao { get; set; }
		public DateTime? Pagamento { get; set; }
		public Decimal? ValorPago { get; set; }

		public List<Cliente> PublicoAtingido { get; set; }

	}
}