﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Especialidad
    {
        public Especialidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

