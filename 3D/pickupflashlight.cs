using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupflashlight : MonoBehaviour
{
    public GameObject inttext, flashlight_table, flashlight_hand;
    public AudioSource pickup;
    public bool interactable;

    public bool Showitem;
    public GameObject itemshow;
    public GameObject itemInfo;
    public GameObject Howto;

    public static bool Hard = false;
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
            if (Input.GetKeyDown(KeyCode.E) && Showitem == false)
            {
                StopPlayer();
                itemInfo.SetActive(true);
                itemshow.SetActive(true);
                Howto.SetActive(true);
                Showitem = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && Showitem == true)
        {
            PlayePlayer();
            Showitem = false;
            itemInfo.SetActive(false);
            itemshow.SetActive(false);
            Howto.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.G) && Showitem == true)
        {
            PlayePlayer();
            Showitem = false;
            itemInfo.SetActive(false);
            itemshow.SetActive(false);
            Howto.SetActive(false);
            inttext.SetActive(false);
            interactable = false;
            //pickup.Play();
            flashlight_hand.SetActive(true);
            flashlight_table.SetActive(false);
            if (Hard == true)
            {
                flashlight.TimeLimet = 10.0f;
            }
            if (Hard == false)
            {
                flashlight.TimeLimet = 20.0f;
            }
        }
    }
    public void StopPlayer()
    {
        PlayerController.runningSpeed = 0f;
        PlayerController.walkingSpeed = 0f;
    }
    public void PlayePlayer()
    {
        PlayerController.runningSpeed = 4f;
        PlayerController.walkingSpeed = 2f;
    }
}


