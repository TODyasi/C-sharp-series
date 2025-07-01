using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__series.Shapes._3DShapes.IFormulas;

namespace C__series.Shapes._3DShapes.Sphere
{
    public class Sphere : I3DFormulas
    {
        //Formula: A=4πr2,V=4/3πr3
        private float _radius {  get; set; }
        private float _piValue = 3.14159f;

        public Sphere(float radius, float piValue)
        {
            this._radius = radius;
            this._piValue = piValue;
        }
        public float CalculateSurfaceArea()
        {
            float answer = 4 * _piValue * (_radius * _radius);
            return answer;
        }

        public float CalculateVolume()
        {
            float answer = 1.33f * _piValue * (_radius * _radius *  _radius);
            return answer;
        }
    }
}
