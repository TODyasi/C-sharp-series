using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__series.Shapes._2DShapes.IFormulas;

namespace C__series.Shapes._2DShapes.Triangle
{
    public class Triangle : IFormula
    {
        private float BaseOfShape {  get; set; }
        private float Height {  get; set; }
        private float Length { get; set; }
        private float Breadth {  get; set; }


        public Triangle(float baseOfShape, float height)
        {
            this.BaseOfShape = baseOfShape;
            this.Height = height;
        }
        public Triangle(float length, float breadth, float height)
        {
            this.Length = length;
            this.Breadth = breadth;
            this.Height = height;   
        }
        public float CalculateArea()
        {
            float answer = 0.5f * BaseOfShape * Height;
            return answer;
        }

        public float CalculatePerimeter()
        {
            float answer = Length + Breadth + Height;
            return answer;
        }
    }
}
