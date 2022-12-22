using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bag : MonoBehaviour
{
    bool isClosed;
    public GameObject Bag;

    public void OpenCloseBag()
    {
        if (isClosed == true)
        {
            Bag.SetActive(true);
            isClosed = false;
        }
        else
        {
            Bag.SetActive(false);
            isClosed = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isClosed == true)
        {
                Bag.SetActive(true);
                isClosed = false;
        }
        else if(Input.GetKeyDown(KeyCode.I) && isClosed == false)
        {
                Bag.SetActive(false);
                isClosed = true;
        }
    }
}
