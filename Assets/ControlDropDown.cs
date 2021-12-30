using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.XR.Interaction.Toolkit;

public class ControlDropDown : MonoBehaviour
{
    public GameObject dropDown;
    //public GameObject dropDown2;
    //public GameObject Cam;

    // Start is called before the first frame update
    void Start()
    {
        //if (Cam == null) { Cam = Camera.main.gameObject; }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            dropDown.SetActive(true);
        }
        //dropDown2.SetActive(true);
        //if (other.CompareTag("Player"))
        //{
        //    print("Player");
        //    dropDown.SetActive(true);
        //}
    }
    //void OnTriggerStay(Collider other);
    void OnTriggerExit(Collider other)
    {
        //if (other.CompareTag("MainCamera")) { }
        dropDown.SetActive(false);
        //dropDown2.SetActive(false);
    }
}