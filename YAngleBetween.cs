using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tools
{
    public class YAngleBetween : MonoBehaviour
    {

        public float Angle (Quaternion rotationA, Quaternion rototationB)
        {
            Vector3 forwardA = rotationA * Vector3.forward;
            Vector3 forwardB = rototationB * Vector3.forward;
            float angleA = Mathf.Atan2(forwardA.x, forwardA.z) * Mathf.Rad2Deg;
            float angleB = Mathf.Atan2(forwardB.x, forwardB.z) * Mathf.Rad2Deg;
            return Mathf.DeltaAngle(angleA, angleB);
        }

    }
}
