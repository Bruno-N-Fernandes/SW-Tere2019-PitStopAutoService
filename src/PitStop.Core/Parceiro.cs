using System.Collections.Generic;

namespace PitStop.Core
{
	public enum Segmento
	{
		LavaRapido = 1,
		Borracharia = 2,
		Oficina = 4,
		AutoPecas = 8
	}

	public class Parceiro
	{
		public string RazaoSocial { get; set; }
		public string NomeFantasia { get; set; }
		public string Responsavel { get; set; }
		public Segmento Segmento { get; set; }
		public string Telefone { get; set; }
		public string Endereco { get; set; }
		public List<Campanha> Campanhas { get; set; }
	}
}