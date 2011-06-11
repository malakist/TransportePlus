using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Entities;

namespace Tests
{
    [TestFixture]
    public class PessoaTests
    {        
        [Test]
        public void GivenTheSameEntityTestEqualsMethod()
        {
            Pessoa x;
            x = new Pessoa();
            x.Id = 1;

            Assert.IsTrue(x.Equals(x));
        }

        [Test]
        public void GivenTwoEntitiesTestEqualsMethod()
        {
            Pessoa x, y;
            x = new Pessoa();
            x.Id = 1;

            y = new Pessoa();
            y.Id = 2;

            Assert.IsFalse(x.Equals(y));
        }

        [Test]
        public void GivenTwoInstancesTheSameIdTestEqualsMethod()
        {
            Pessoa x, y;
            x = new Pessoa();
            x.Id = 1;

            y = new Pessoa();
            y.Id = 1;

            Assert.IsTrue(x.Equals(y));
        }

        [Test]
        public void GivenTwoInstancesTheSameIdTestGetHashCodeMethod()
        {
            Pessoa x, y;
            x = new Pessoa();
            x.Id = 1;

            y = new Pessoa();
            y.Id = 1;

            Assert.AreEqual(x.GetHashCode(), y.GetHashCode());
        }

        [Test]
        public void MetodoEquals_DuasInstanciasDeClassesDiferentesDevemRetornarFalse()
        {
            Pessoa x = new Pessoa();
            x.Id = 1;

            Assert.IsFalse(x.Equals("texto"));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Metodo_DeveRetornarInvalidOperationSempre()
        {
            Pessoa x = new Pessoa();
            x.RetornarInvalidOperation();
        }
    }
}
