using System;
using System.Collections.Generic;

namespace Pinacoteca.Models.Entities;

public partial class Coleccion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public virtual ICollection<Cuadro> Cuadro { get; set; } = new List<Cuadro>();
}
