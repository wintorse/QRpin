using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetPositionAndRotation1 : MonoBehaviour
{
    TextMeshProUGUI tmp;
    string px, py, pz, rx, ry, rz;

    // Update is called once per frame
    void Update()
    {
        tmp = this.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        px = this.transform.position.x.ToString("N3");
        py = this.transform.position.y.ToString("N3");
        pz = this.transform.position.z.ToString("N3");
        Quaternion quaternion = this.transform.rotation;
        float x = quaternion.eulerAngles.x;
        float y = quaternion.eulerAngles.y;
        float z = quaternion.eulerAngles.z;
        rx = x.ToString("N1");
        ry = y.ToString("N1");
        rz = z.ToString("N1");

        //Math.Round(1.15, 1, MidpointRounding.AwayFromZero)

        tmp.text = px + "," + py + "," + pz + "\n" + rx + "," + ry + "," + rz;
    }
}