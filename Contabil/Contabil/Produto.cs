using System;
using System.Collections.Generic;

namespace Contabil;

public partial class Produto
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public decimal? Compra { get; set; }

    public decimal? Venda { get; set; }

    public decimal? IcmsCompra { get; set; }

    public decimal? PisCompra { get; set; }

    public decimal? CofinsCompra { get; set; }

    public decimal? IcmsVenda { get; set; }

    public decimal? PisVenda { get; set; }

    public decimal? CofinsVenda { get; set; }
}
