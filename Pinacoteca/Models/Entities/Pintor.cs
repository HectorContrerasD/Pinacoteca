using System;
using System.Collections.Generic;

namespace Pinacoteca.Models.Entities;

public partial class Pintor
{
    public int IdPintor { get; set; }

    public string Nombre { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string? FechaNacimiento { get; set; }

    public string? FechaFallecimiento { get; set; }

    public string Biografia { get; set; } = null!;

    public string Imagen { get; set; } = null!;

    public virtual ICollection<Cuadro> Cuadro { get; set; } = new List<Cuadro>();
}
