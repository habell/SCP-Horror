using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using Object = UnityEngine.Object;

public class DayCycle : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(.2f, 0, 0) * transform.rotation;
    }
}
