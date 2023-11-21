using System;
using System.Collections.Generic;

namespace Contabil;

public partial class Empresa
{
    public int Id { get; set; }

    public decimal? Capital { get; set; }

    public decimal? Caixa { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Despesa { get; set; }

    public decimal? Obrigacoes { get; set; }

    public decimal? Bens { get; set; }

    public decimal? Direitos { get; set; }

}
