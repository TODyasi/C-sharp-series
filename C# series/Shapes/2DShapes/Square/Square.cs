using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__series.Shapes._2DShapes.IFormulas;

namespace C__series.Shapes._2DShapes.Square
{
    public class Square : IFormula
    {
        private float Length {  get; set; }
        private float Breadth {  get; set; }

        public Square(float length, float breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }
        public float CalculateArea()
        {
            float answer = Length * Breadth;
            return answer;
        }

        public float CalculatePerimeter()
        {
            float answer = 4 * Length;
            return answer;
        }
    }
}
