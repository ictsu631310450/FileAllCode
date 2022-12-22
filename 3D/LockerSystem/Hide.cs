using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{

    public GameObject AreaSound;
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        AreaSound.SetActive(false);
    //        PlayerController.Hideing = true;
    //    }
    //}

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Locker"))
        {
            AreaSound.SetActive(false);
            PlayerController.Hideing = true;
        }
        else if(other.CompareTag("Under"))
        {
            AreaSound.SetActive(false);
            PlayerController.Hideing = true;
        }

        else if (other.CompareTag("OutLocker"))
        {
            AreaSound.SetActive(true);
            PlayerController.Hideing = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Locker"))
        {
            AreaSound.SetActive(true);
            PlayerController.Hideing = false;
        }
        else if (other.CompareTag("Under"))
        {
            AreaSound.SetActive(true);
            PlayerController.Hideing = false;
        }
    }
}
