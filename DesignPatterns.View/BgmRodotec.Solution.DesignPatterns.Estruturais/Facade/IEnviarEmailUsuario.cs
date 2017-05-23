﻿using Estruturais.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Solution.DesignPatterns.Estruturais.Facade
{
    public interface IEnviarEmailUsuario
    {
        void EnviarEmail(UsuarioModel usuario);
    }
}
