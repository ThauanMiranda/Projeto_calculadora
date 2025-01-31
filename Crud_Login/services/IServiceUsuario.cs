﻿using Crud_Login.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.services {
    public interface IServiceUsuario {

        bool salvarUsuario(Usuario usuario);
        Usuario getUsuarioPorId(int id);
        void atualizarUsuario(string email, Usuario usuario);
        bool existePorId(int id);
        bool deletarUsuario(int id);
        bool validarLogin(Usuario usuario);

    }
}
