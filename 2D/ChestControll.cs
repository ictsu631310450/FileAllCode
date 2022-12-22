using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestControll : MonoBehaviour
{
    public bool isChestOpen;
    public Animator ChestAnimator;
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject infomation;
    public bool _Time = true;

    public GameObject objectToAccess;

    public void OpenChest()
    {
        if (!isChestOpen)
        {
            isChestOpen = true;
            _Time = true;
            Debug.Log("Chest OPEN");
            ChestAnimator.SetBool("IsOpen", isChestOpen);
            infomation.SetActive(true);
        }
        else
        {
            infomation.SetActive(false);
            isChestOpen = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }


    // Update is called once per frame
    void Update()
    {
        if (_Time == true && isChestOpen == true)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.G) && isChestOpen == true && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    PlayerMager scriptToAccess = objectToAccess.GetComponent<PlayerMager>();
                    scriptToAccess.PickupKey();
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    infomation.SetActive(false);
                    Destroy(gameObject);
                    break;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }


}
