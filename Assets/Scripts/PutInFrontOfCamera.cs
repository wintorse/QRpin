using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutInFrontOfCamera : MonoBehaviour
{
    public GameObject mainCamObj;
    public void RunOnButtonReleased()
    {
        Vector3 mainCamPos = mainCamObj.transform.position;
        this.gameObject.transform.position = new Vector3(mainCamPos.x, mainCamPos.y - 0.4f, mainCamPos.z + 1.0f);
    }
}