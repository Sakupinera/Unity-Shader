using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumetricLightController : MonoBehaviour
{
    public VolumetricLight vLight;

    public float targetScatter;

    // Update is called once per frame
    void Update()
    {
        vLight.ScatteringCoef = Mathf.Lerp(vLight.ScatteringCoef, targetScatter, 0.1f);
    }
}
