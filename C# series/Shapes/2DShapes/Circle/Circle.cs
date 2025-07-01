using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__series.Shapes._2DShapes.IFormulas;

namespace C__series.Shapes.Circle
{
    public class Circle : IFormula
    {
        private float Radius {  get; set; }

        public Circle(float radius)
        {
            this.Radius = radius;
        }
        public  float CalculateArea()
        {
            return 3.14f * (Radius * Radius);
        }

        public  float CalculatePerimeter()
        {
            float answer = 2 * 3.14f * Radius;
            return answer;
        }
    }
}
