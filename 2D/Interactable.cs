using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRane;
    public KeyCode interactKey;
    public UnityEvent interactAction;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInRane)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRane = true;
            collision.gameObject.GetComponent<PlayerMager>().NotifyPlayer();
            Debug.Log("Player in renge");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRane = false;
            collision.gameObject.GetComponent<PlayerMager>().DeNotifyPlayer();
            Debug.Log("Player in renge");
        }
    }

}