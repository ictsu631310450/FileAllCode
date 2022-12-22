using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupBaterly : MonoBehaviour
{
    public GameObject inttext, batery_item;
    public AudioSource pickup;
    public bool interactable;

    public static bool Hard = false;


    private void Start()
    {
        CheckMode();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
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
                PlayerController.Battery = PlayerController.Battery + 1;
                inttext.SetActive(false);
                interactable = false;
                //pickup.Play();
                batery_item.SetActive(false);
                flashlight.TimeLimet = 20.0f;
            }
        }
    }

    public void CheckMode()
    {
        if (Hard == false)
        {
            batery_item.SetActive(true);
        }
        if (Hard == true)
        {
            batery_item.SetActive(false);
        }
    }
}
