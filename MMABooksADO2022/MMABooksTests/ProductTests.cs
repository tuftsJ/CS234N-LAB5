using MMABooksBusinessClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksTests
{
        [TestFixture]
        public class ProductTests
        {
            private Product def;
            private Product p;

            [SetUp]

            public void Setup()
            {
                def = new Product();
                p = new Product("CS10", "Murach's C# 2010", 56.0000m, 5136);
            }

            [Test]

            public void TestConstructor()
            {
                Assert.IsNotNull(def);
                Assert.AreEqual(null, def.ProductCode);
                Assert.AreEqual(null, def.Description);
                Assert.AreEqual(0m, def.UnitPrice);
                Assert.AreEqual(0, def.OnHandQuantity);

                Assert.IsNotNull(p);
                Assert.AreNotEqual(null, p.ProductCode);
                Assert.AreNotEqual(null, p.Description);
                Assert.AreNotEqual(0m, p.UnitPrice);
                Assert.AreNotEqual(0, p.OnHandQuantity);
               
            }

        }

    }

