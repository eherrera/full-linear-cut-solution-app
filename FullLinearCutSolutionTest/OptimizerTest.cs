using System.Collections.Generic;
using System.Linq;
using FullLinearCutSolution.Core;
using FullLinearCutSolution.Core.Model;
using LinealCutOptimizer.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FullLinearCutSolutionTest
{
    [TestClass]
    public class OptimizerTest
    {
        [TestMethod]
        public void TestOptimizerStrategy()
        {
            var result = TestOptimizer(OptimizerStrategy.Optimize);
            Assert.AreEqual(result.Sum(r => r.BarCount), 31);
        }

        [TestMethod]
        public void TestTraditionalStrategy()
        {
            var result = TestOptimizer(OptimizerStrategy.Traditional);
            Assert.AreEqual(result.Sum(r => r.BarCount), 0);
        }

        private static IEnumerable<CutSolution> TestOptimizer(OptimizerStrategy strategy)
        {
            var bar = GetBar();
            var order = GetOrder();
            var optimizer = GetOptimizer();
            var result = optimizer.Optimize(bar, order, strategy);
            return result;
        }

        private static Optimizer GetOptimizer()
        {
            return new Optimizer();
        }

        private static Bar GetBar()
        {
            return new Bar { Length = 9 };
        }

        private static Order GetOrder()
        {
            return new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Measurement = 3.98M,
                        Units = 14
                    },
                    new OrderItem
                    {
                        Measurement = 3.08M,
                        Units = 16
                    },
                    new OrderItem
                    {
                        Measurement = 2.2M,
                        Units = 16
                    },
                    new OrderItem
                    {
                        Measurement = 1.5M,
                        Units = 4
                    },
                    new OrderItem
                    {
                        Measurement = 1.34M,
                        Units = 68
                    },
                    new OrderItem
                    {
                        Measurement = 0.82M,
                        Units = 28
                    },
                    new OrderItem
                    {
                        Measurement = 0.25M,
                        Units = 26
                    },
                    new OrderItem
                    {
                        Measurement = 0.2M,
                        Units = 24
                    },
                }
            };
        }
    }
}