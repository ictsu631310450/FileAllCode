using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridScrip : MonoBehaviour
{
    public GameObject Fadee;

    public void StartFade()
    {
        Fadee.SetActive(false);
        Fadee.SetActive(true);
    }
}
