﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class Observaciones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fechas { get; set; }
        public virtual ICollection<AlumnoObservaciones> AlumnoObservaciones { get; set; }
    }
}