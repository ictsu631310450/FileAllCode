using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC1 : MonoBehaviour
{
    public bool isChatOpen;
    public GameObject Story1;
    public GameObject Story2;
    public GameObject Story3;

    private GameObject currentTeleporter;

    public int st;
    public bool _Time = true;

    //Open Ob
    public int OpenOb = 0;
    public GameObject OpenOb_On;
    public GameObject OpenOb_Off;

    public void OpenChat1_Chat()
    {
        if (!isChatOpen)
        {
            isChatOpen = true;
            Debug.Log("Chat NPC OPEN");
        }
        if (Input.GetKey(KeyCode.E))
        {
            st = st + 1;
        }
        if (st == 1)
        {
            Story1.SetActive(true);
        }
        if (st > 1)
        {
            Story1.SetActive(false);
            CheckOpenOB();
            st = 0;
            Time.timeScale = 1;
        }

    }

    public void OpenChat2_Chat()
    {
        if (!isChatOpen)
        {
            isChatOpen = true;
            Debug.Log("Chat NPC OPEN");
        }
        if (Input.GetKey(KeyCode.E))
        {
            st = st + 1;
        }
        if (st == 1)
        {
            Story1.SetActive(true);
        }
        if (st == 2)
        {
            Story1.SetActive(false);
            Story2.SetActive(true);
        }
        if (st > 2)
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            CheckOpenOB();
            st = 0;
            Time.timeScale = 1;
        }

    }

    public void OpenChat3_Chat()
    {
        if (!isChatOpen)
        {
            isChatOpen = true;
            Debug.Log("Chat NPC OPEN");
        }
        if (Input.GetKey(KeyCode.E))
        {
            st = st + 1;
        }
        if (st == 1)
        {
            Story1.SetActive(true);
            Story2.SetActive(false);
            Story3.SetActive(false);
        }
        if (st == 2)
        {
            Story1.SetActive(false);
            Story2.SetActive(true);
            Story3.SetActive(false);
        }
        if (st == 3)
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            Story3.SetActive(true);
        }
        if (st > 3)
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            Story3.SetActive(false);
            st = 0;
            Time.timeScale = 1;
        }

    }

    public void OpenChat_Tawan()
    {
        if (!isChatOpen)
        {
            isChatOpen = true;
            Debug.Log("Chat NPC OPEN");
        }
        if (Input.GetKey(KeyCode.E))
        {
            st = st + 1;
        }
        if (st == 1)
        {
            Story1.SetActive(true);
        }
        if (st == 2)
        {
            Story1.SetActive(false);
            Story2.SetActive(true);
        }
        if (st > 2)
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            st = 0;
            Time.timeScale = 1;
            SceneManager.LoadScene("GameLV2");
        }
    }

    public void OpenChat_Bicicle()
    {
        if (!isChatOpen)
        {
            isChatOpen = true;
            Debug.Log("Chat NPC OPEN");
        }
        if (Input.GetKey(KeyCode.E))
        {
            st = st + 1;
        }
        if (st == 1)
        {
            Story1.SetActive(true);
        }
        if (st == 2)
        {
            Story1.SetActive(false);
            Story2.SetActive(true);
        }
        if (st == 3)
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            st = 0;
            Time.timeScale = 1;
            SceneManager.LoadScene("GameLV3");
        }
        if (st == 4)
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            st = 0;
            Time.timeScale = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Story1.SetActive(false);
            Story2.SetActive(false);
            st = 0;
            Time.timeScale = 1;
        }
        if (_Time == true && st == 1)
        {
            Time.timeScale = 0;
        }
        if (_Time == true && st == 2)
        {
            Time.timeScale = 0;
        }
    }

    
    public void CheckOpenOB()
    {
        if (OpenOb == 2)
        {
            OpenOb_On.SetActive(false);
            OpenOb_Off.SetActive(false);
        }
        if (OpenOb == 1)
        {
            OpenOb_On.SetActive(true);
            OpenOb_Off.SetActive(false);
        }
    }

    public void Goto_Pool()
    {
        SceneManager.LoadScene("EndPool");
        Time.timeScale = 1;
    }

    public void Goto_Music()
    {
        SceneManager.LoadScene("EndMusic");
        Time.timeScale = 1;
    }

    public void Goto_2haft()
    {
        SceneManager.LoadScene("2haft");
        Time.timeScale = 1;
    }

    public void Goto_EndMusic2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("EndMusic2");
    }

    public GameObject[] Levels;
    int currentLevel;

    public void Correct()
    {
        if (currentLevel +1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
    }
}
