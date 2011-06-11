using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Pessoa : EntityBase
    {
        public string Nome { get; set; }

        public void RetornarInvalidOperation()
        {
            throw new InvalidOperationException();
        }
    }
}
