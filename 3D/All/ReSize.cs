using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSize : MonoBehaviour
{

    private Vector3 flashlightScale = new Vector3(6, 1, 3);
    private Vector3 flashlightScaleold = new Vector3(3, 3, 3);
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.localScale = flashlightScale;
        }
        else
        {
            transform.localScale = flashlightScaleold;
        }
    }
}