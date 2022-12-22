using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Story : MonoBehaviour
{
    public int inStory;
    public GameObject Story1;
    public GameObject Story2;

    //รุ่นพี่ปี2
    public int Npc = 0;
    public GameObject NpcOff;
    public GameObject NpcOn;

    //OpenSorty
    public int OpenSorty = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            inStory = inStory + 1;
            if (inStory == 1 && OpenSorty == 0)
            {
                Time.timeScale = 0;
                Story1.SetActive(true);
                UpdateNPC();
            }
            if (inStory == 2 && OpenSorty == 0)
            {
                Time.timeScale = 0;
                Story2.SetActive(true);
            }



            if (OpenSorty == 1)
            {
                Story1.SetActive(true);
                Story2.SetActive(true);
            }
            if (inStory > 4)
            {
                SoundManagerScript.PlaySound("ghost");
                Story1.SetActive(true);
                NextScene();
                //SceneManager.LoadScene("GameLV4");
            }
        }
    }

    public void NextScene()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.7f); //ปรับเวลา
        SceneManager.LoadScene("GameLV4");
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
            if (inStory > 0)
            {
                Story1.SetActive(false);
                Story2.SetActive(false);
            }
        }
    }

    public void UpdateNPC()
    {
        if (Npc == 1)
        {
            NpcOff.SetActive(false);
            NpcOn.SetActive(true);
        }
        if (Npc == 2)
        {
            NpcOff.SetActive(true);
            NpcOn.SetActive(true);
        }
        if (Npc == 3)
        {
            NpcOff.SetActive(false);
            Time.timeScale = 1;
        }
        if (Npc == 4)
        {
            NpcOn.SetActive(true);
            Time.timeScale = 1;
        }
    }

    public GameObject[] Levels;
    int currentLevel;

    public void Correct()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
    }
}
