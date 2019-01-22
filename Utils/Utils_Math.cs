using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils {
    public static class Math {
        public static int Mod(int a, int b) {
            return (a % b + b) % b;
        }

        public static float Mod(float a, float b) {
            return (a % b + b) % b;
        }
    }
}
