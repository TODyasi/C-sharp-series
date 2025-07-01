using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__series.Shapes._3DShapes.IFormulas;

namespace C__series.Shapes._3DShapes.Cuboid
{
    public class Cuboid : I3DFormulas
    {
        //Formulas: A=2(lw + lh + wh), V = l x w x H
        private float _length {  get; set; }
        private float _height {  get; set; }
        private float _width { get; set; }

        public Cuboid(float length, float height, float width)
        {
            this._length = length;
            this._height = height;
            this._width = width;
        }
        public float CalculateSurfaceArea()
        {
            float result = 2 * (_length * _height + _length * _width + _length * _height);
            return result;
        }

        public float CalculateVolume()
        {
            float result = _length * _width * _height;
            return result;
        }
    }
}
