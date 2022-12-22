using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlay : MonoBehaviour
{
    public int _FirstPlay;
    public GameObject imgFirstPlay;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (_FirstPlay == 1)
            {
                Time.timeScale = 0;
                imgFirstPlay.SetActive(true);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1;
            Destroy(GameObject.Find("FirstPlay2"));
            if (_FirstPlay == 1)
            {
                imgFirstPlay.SetActive(false);
            }
        }
    }
}
