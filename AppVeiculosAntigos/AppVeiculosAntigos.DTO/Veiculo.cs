using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.DTO
{
    public class Veiculo
    {
        public int? AnoFabricacao { get; set; }
        public string Descricao { get; set; }
        public Fabricante Fabricante { get; set; }
        public int IdVeiculo { get; set; }
        public string Modelo { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
    }
}
