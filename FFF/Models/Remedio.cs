﻿using System;
using System.Collections.Generic;

namespace FFF.Models;

public partial class Remedio
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Horario> Horarios { get; } = new List<Horario>();
}
