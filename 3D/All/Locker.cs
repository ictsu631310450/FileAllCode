using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public GameObject Camera;
    public Transform WarpIn;

    public GameObject AreaOn;
    public GameObject AreaOff;

    public GameObject inttext;
    //public AudioSource pickup;
    public bool interactable;
    public bool InLoker;

    public PlayerController PlayerController_;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerController_.OFFcharacterController();
                Camera.gameObject.transform.position = WarpIn.position;
                AreaOn.SetActive(true);
                AreaOff.SetActive(false);
                inttext.SetActive(false);
                interactable = false;
                PlayerController_.OncharacterController();
            }
        }
    }
}
