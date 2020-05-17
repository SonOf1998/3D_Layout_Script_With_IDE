using static _3D_layout_script.vec3;
using System;

namespace _3D_layout_script
{
    public class Matrix4
    {
        double[] data = new double[4 * 4];

        public vec3 GetLine1()
        {
            return new vec3(data[0], data[1], data[2]);
        }

        public vec3 GetLine2()
        {
            return new vec3(data[4], data[5], data[6]);
        }

        public vec3 GetLine3()
        {
            return new vec3(data[8], data[9], data[10]);
        }

        public vec3 GetLine4()
        {
            return new vec3(data[12], data[13], data[14]);
        }

        public Matrix4()
        {
            data[0] = 1;
            data[5] = 1;
            data[10] = 1;
            data[15] = 1;
        }

        public Matrix4(double[] newData)
        {
            for (int i = 0; i < newData.Length; ++i)
            {
                data[i] = newData[i];
            }
        }

        public void Translate(vec3 vec)
        {
            data[12] = vec.x;
            data[13] = vec.y;
            data[14] = vec.z;
        }

        public void Scale(vec3 vec)
        {
            data[0] = vec.x;
            data[5] = vec.y;
            data[10] = vec.z;
        }

        public static Matrix4 CreateRotationMatrix(vec3 axis, double angleDeg)
        {       
            double c = Math.Cos((angleDeg / 180) * Math.PI);
            double s = Math.Sin((angleDeg / 180) * Math.PI);

            vec3 w = Normalize(axis);

            vec3 l1 = new vec3(c * (1 - w.x * w.x) + w.x * w.x, w.x * w.y * (1 - c) + w.z * s, w.x * w.z * (1 - c) - w.y * s);
            vec3 l2 = new vec3(w.x * w.y * (1 - c) - w.z * s, c * (1 - w.y * w.y) + w.y * w.y, w.y * w.z * (1 - c) + w.x * s);
            vec3 l3 = new vec3(w.x * w.z * (1 - c) + w.y * s, w.y * w.z * (1 - c) - w.x * s, c * (1 - w.z * w.z) + w.z * w.z);



            return new Matrix4(new double[] {  l1.x, l2.x, l3.x, 0,
                                               l1.y, l2.y, l3.y, 0,
                                               l1.z, l2.z, l3.z, 0,
                                               0,    0,    0,    1 });
        }

        public static Matrix4 operator *(Matrix4 left, Matrix4 right)
        {
            vec3 l1 = left.GetLine1() * right;
            vec3 l2 = left.GetLine2() * right;
            vec3 l3 = left.GetLine3() * right;
            vec3 l4 = left.GetLine4() * right;

            return new Matrix4(new double[16] { l1.x, l1.y, l1.z, 0,
                l2.x, l2.y, l2.z, 0,
                l3.x, l3.y, l3.z, 0,
                l4.x, l4.y, l4.z, 1
            });
        }
       
        public void Invert()
        {
            // TODO jövőre! Most megfelel csak félig meddig valógsághűen.
        }

        public void Transpose()
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    data[4 * i + j] = data[4 * j + i];
                }
            }            
        }
    }
}
