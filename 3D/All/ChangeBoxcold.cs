using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBoxcold : MonoBehaviour
{
    BoxCollider col;
    public static bool toggle;
    public static bool PlayerMove = false;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (enemyMonsterAI.Lighting == false && toggle == false)
        //{
        //    col.GetComponent<BoxCollider>().enabled = false;
        //    col.GetComponent<BoxCollider>().enabled = true;
        //    toggle = true;
        //}
        if (Input.GetKey(KeyCode.LeftControl))
        {
            col.size = new Vector3(3f, 1f, 3f);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            col.size = new Vector3(20f, 1f, 20f);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            col.size = new Vector3(10f, 1f, 10f);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            col.size = new Vector3(10f, 1f, 10f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            col.size = new Vector3(10f, 1f, 10f);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            col.size = new Vector3(10f, 1f, 10f);
        }
        else
        {
            col.size = new Vector3(5f, 1f, 5f);
        }
    }
}
