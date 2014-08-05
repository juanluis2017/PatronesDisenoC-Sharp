﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTavo.RepositoryPattern.Dominio;

namespace ElTavo.RepositoryPattern.Contrato
{
    public interface IDatosContactoRepository
    {
        DatosContacto ObtenerDatosContactoEmpleado(string idEmpleado);
    }
}
