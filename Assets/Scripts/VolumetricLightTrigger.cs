using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumetricLightTrigger : MonoBehaviour
{
    public VolumetricLightController vLightCon;

    private void OnTriggerEnter()
    {
        vLightCon.targetScatter = 1.0f;
    }

    private void OnTriggerExit()
    {
        vLightCon.targetScatter = 0;
    }

}
