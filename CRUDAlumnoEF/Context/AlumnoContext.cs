using CRUDAlumnoEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDAlumnoEF.Context
{
    public class AlumnoContext: DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
    }
}