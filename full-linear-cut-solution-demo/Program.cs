using System;
using FullLinearCutSolution.Core;
using FullLinearCutSolution.Core.Helpers;
using FullLinearCutSolution.Core.Model;
using LinealCutOptimizer.Core.Model;

namespace FullLinearCutSolution.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum.TryParse(Console.ReadLine(), out OptimizerStrategy strategy);
            var bar = new Bar {Length = int.Parse(Console.ReadLine())};
            var order = new Order();
            var orderItemCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < orderItemCount; i++)
            {
                var itemString = Console.ReadLine();
                if (itemString == null) continue;
                var item = itemString.Split(' ');
                order.Items.Add(new OrderItem {Measurement = decimal.Parse(item[0]), Units = int.Parse(item[1])});
            }
            var optimizer = new Optimizer();
            var result = optimizer.Optimize(bar, order, strategy);

            var barCount = 0;
            foreach (var el in result)
            {
                var text = $"{el.Id} - ";
                var pattern = el.GetCutPattern();
                var measurements = pattern.Measurements;
                var units = pattern.Units;
                for (int i = 0; i < measurements.Count; i++)
                {
                    text += $"{measurements[i]}-{units[i]} ";
                }
                if (el.ParentSolutionId != null)
                {
                    text += $"Parent Solution-{el.ParentSolutionId}";
                }
                text += $" Bar-{el.GetBar().Length}, Waste-{el.Waste}u  ({el.WastePercent.Round2()}%)";
                barCount += el.BarCount;

                Console.WriteLine(text);
            }
            Console.WriteLine($"Total: pieces-{order.TotalPieces}, bars-{barCount}");
            Console.ReadKey();
        }
    }
}