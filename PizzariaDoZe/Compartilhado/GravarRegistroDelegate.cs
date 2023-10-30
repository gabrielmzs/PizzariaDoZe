using FluentResults;
using PizzariaDoZe.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado {


    public delegate Result GravarRegistroDelegate<TEntidade>(TEntidade registro)
        where TEntidade : EntidadeBase<TEntidade>;
}
