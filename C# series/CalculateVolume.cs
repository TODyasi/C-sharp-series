using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__series
{
    public class CalculateVolume
    {
        public float VolumeOfRectangularPrism(float length, float width, float height)
        {

            float answer = length * width * height;
            return answer;
        }

        public float VolumeOfCylinder(float radius, float height)
        {
            float answer = 3.14f * (radius * radius) * height;
            return answer;
        }
        public float VolumeOfCube(float side)
        {
            float answer = side * side * side;
            return answer;
        }

        public float VolumeOfCone(float radius, float height)
        {
            float answer = 3.14f * (radius*radius) * height/3;
            return answer;
        }

        public float VolumeOfSphere(float radius)
        {
            float answer = 1.33f * 3.14f * (radius * radius * radius);
            return answer;
        }

        public float VolumeOfPrism(float baseOfShape, float height)
        {
            float answer = baseOfShape * height;
            return answer;
        }

        public float VolumeOfPyramid(float baseOfShape, float height)
        {
            float answer = 0.33f * baseOfShape * height;
            return answer;
        }
    }
}
