using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace POC_Testaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa entTest = new Pessoa();
            entTest.Nome = "Camila";

            Pessoa entControle = new Pessoa();
            entControle.Nome = "Rodrigo";
        }

        static void ValidaMetodoEquals(Pessoa entTest) 
        {
            if (!entTest.Equals)
            {
                throw new Exception("Método equals falhou");
            }
        }

        static void ValidaOperadorEquals(Pessoa entTest)
        {
            if (!(entTest == entTest))
            {
                throw new Exception();
            }
        }

        static void ValidaOperadorNotEquals(Pessoa entTest)
        {
            if (entTest != entTest)
            {
                throw new Exception();
            }
        }

        static void GivenTwoDifferentEntitiesValidaMetodoEquals(Pessoa entTest, Pessoa entControle)
        {
            if (entTest.Equals(entControle) != entControle.Equals(entTest))
            {
                throw new Exception();
            }
        }

        static void GivenThreDifferentEntitiesValidaMetodoEquals(Pessoa x, Pessoa y, Pessoa z)
        {
            
        }
    }
}
