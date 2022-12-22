using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMager : MonoBehaviour
{
    public GameObject InteractNotification;
    public int keyCount = 0;
    public int Paper = 0;
    public GameObject DoorLock;



    public void PickupKey()
    {
        keyCount = keyCount + 1;
        Debug.Log("Pickup Key");
    }

    public void UseKey()
    {
        Debug.Log("Use Key");
    }

    public void FindKey()
    {
        DoorLock.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (keyCount == 2)
        //{
        //    keyCount = 1;
        //    Paper = 1;
        //}
    }

    public void NotifyPlayer()
    {
        InteractNotification.SetActive(true);
        Debug.Log("Show");
    }

    public void DeNotifyPlayer()
    {
        InteractNotification.SetActive(false);
        Debug.Log("Dont Show");
    }
}
