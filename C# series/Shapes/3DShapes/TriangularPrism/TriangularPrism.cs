using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__series.Shapes._3DShapes.IFormulas;

namespace C__series.Shapes._3DShapes.TriangularPrism
{
    public class TriangularPrism : I3DFormulas
    {
        private float _height {  get; set; }
        private float _baseSideA {  get; set; }
        private float _baseSideB {  get; set; }
        private float _baseSideC {  get; set; }
        private float _perimeterOfBase {  get; set; }
        private float _lengthOfPrism {  get; set; }
        private float _baseArea {  get; set; }

        //Formulas: V=14h﹣a4+2(ab)2+2(ac)2﹣b4+2(bc)2﹣c4, SA= (Perimeter of the base × Length of the prism) + (2 × Base Area)
        //These methods were created and configured with help of chatgpt

        //Constructorto calculate the volume
        public TriangularPrism(float baseSideA, float baseSideB, float baseSideC, float height)
        {
            this._baseSideA = baseSideA;
            this._baseSideB = baseSideB;
            this._baseSideC = baseSideC;
            this._height = height;
        }
        // Constructor to calculate the Surface area
        public TriangularPrism(float length, float perimeterOfBase, float baseArea)
        {
            this._lengthOfPrism = length;
            this._perimeterOfBase = perimeterOfBase;
            this._baseArea = baseArea;
        }
        public float CalculateSurfaceArea()
        {
             if (_perimeterOfBase > 0 && _lengthOfPrism > 0 && _baseArea > 0)
            {
                return (_perimeterOfBase * _lengthOfPrism) + (2 * _baseArea);
            }
            else if (_baseSideA > 0 && _baseSideB > 0 && _baseSideC > 0 && _height > 0)
            {
                float perimeter = _baseSideA + _baseSideB + _baseSideC;
                float baseArea = CalculateBaseArea();
                return (perimeter * _height) + (2 * baseArea);
            }
            else
            {
                throw new InvalidOperationException("Insufficient data to calculate surface area.");
            }
        }

        public float CalculateVolume()
        {
            if (_baseArea > 0 && _lengthOfPrism > 0)
            {
                return _baseArea * _lengthOfPrism;
            }
            else if (_baseSideA > 0 && _baseSideB > 0 && _baseSideC > 0 && _height > 0)
            {
                float baseArea = CalculateBaseArea();
                return baseArea * _height;
            }
            else
            {
                throw new InvalidOperationException("Insufficient data to calculate volume.");
            }
        }
        public float CalculateBaseArea()
        {
            //semi-perimeter is half the sum of all three sides of a triangle
            float semiPerimeter = (_baseSideA + _baseSideB + _baseSideC) / 2;
            float areaSquared = semiPerimeter * (semiPerimeter - _baseSideA) * (semiPerimeter - _baseSideB) * (semiPerimeter - _baseSideC);

            if (areaSquared <= 0)
            {
                throw new InvalidOperationException("Invalid triangle sides provided.");
            }

            //The area of a triangle is the square root of areaSquared
            return (float)Math.Sqrt(areaSquared);
        }
    }
}
