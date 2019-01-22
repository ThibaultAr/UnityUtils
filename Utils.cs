using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils {
    public static class Methods {
        public static class Math {
            public static int mod(int a, int b) {
                return (a % b + b) % b;
            }

            public static float mod(float a, float b) {
                return (a % b + b) % b;
            }
        }

        public static class GameObject {
            public static UnityEngine.GameObject FirstChildWithTag(UnityEngine.GameObject Parent, string tag) {
                return FindChildWithTag(Parent, tag)[0];
            }

            public static List<UnityEngine.GameObject> FindChildWithTag(UnityEngine.GameObject Parent, string tag) {
                if (Parent.transform.childCount == 0) {
                    if (!Parent.CompareTag(tag))
                        return new List<UnityEngine.GameObject>();
                    else
                        return new List<UnityEngine.GameObject>() { Parent };
                } else {
                    List<UnityEngine.GameObject> res = new List<UnityEngine.GameObject>();
                    for (int i = 0; i < Parent.transform.childCount; i++)
                        res.AddRange(FindChildWithTag(Parent.transform.GetChild(i).gameObject, tag));
                    if (Parent.CompareTag(tag)) res.Add(Parent);
                    return res;
                }
            }
        }
    }
}