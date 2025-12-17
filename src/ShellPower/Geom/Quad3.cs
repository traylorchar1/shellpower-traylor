using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace SSCP.ShellPower {
    public struct Quad3 {
        public Vector3 Min, Max;

        public bool Contains(float x, float y, float z) {
            return
                x >= Min.X &&
                y >= Min.Y &&
                z >= Min.Z &&
                x < Max.X &&
                y < Max.Y &&
                z < Max.Z;
        }
        public bool Overlaps(Quad3 other) {
            /* there must be a faster way */
            return
                Min.X < other.Max.X && Max.X > other.Min.X &&
            Min.Y < other.Max.Y && Max.Y > other.Min.Y &&
            Min.Z < other.Max.Z && Max.Z > other.Min.Z;
        }

        public static readonly Quad3 Infinite = new Quad3() {
            Min = new Vector3(float.NegativeInfinity,
                float.NegativeInfinity,
                float.NegativeInfinity),
            Max = new Vector3(float.PositiveInfinity,
                float.PositiveInfinity,
                float.PositiveInfinity)
        };

        public override string ToString() {
            return "[" + Min.ToString() + "," + Max.ToString() + "]";
        }
    }
}

