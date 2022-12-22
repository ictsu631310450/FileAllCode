using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoortController : MonoBehaviour
{
    public bool isOpen;
    public Animator DoorAnimator;

    public void OpenDoor(GameObject obj)
    {
        if (!isOpen)
        {
            PlayerMager manager = obj.GetComponent<PlayerMager>();
            if (manager)
            {
                if (manager.keyCount > 0)
                {
                    isOpen = true;
                    manager.UseKey();
                    DoorAnimator.SetBool("IsOpen", isOpen);
                    Debug.Log("Door is unlock");
                }
                if (manager.keyCount == 0)
                {
                    manager.FindKey();
                }
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void OpenSceneKitRoom(GameObject obj)
    {
        if (!isOpen)
        {
            PlayerMager manager = obj.GetComponent<PlayerMager>();
            if (manager)
            {
                if (manager.keyCount > 0)
                {
                    isOpen = true;
                    manager.UseKey();
                    Debug.Log("Door is unlock");
                    SceneKitRoom();
                }
                if (manager.keyCount == 0)
                {
                    manager.FindKey();
                }
            }
        }
    }

    public void SceneKitRoom()
    {
        SceneManager.LoadScene("KetRoom");
    }

    public void OutKetRoom()
    {
        SceneManager.LoadScene("OutKetRoom");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
