using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashlight : MonoBehaviour
{
    public GameObject light_;
    public bool toggle;
    public AudioSource toggleSound;

    public static float TimeLimet = 0.0f;
    public Slider LightSlider;

    public float CheckTime;
    

    public GameObject bat100;
    public GameObject bat50;
    public GameObject bat10;

    public GameObject Battery;
    public static bool Show = false;

    void Start()
    {
        if (toggle == false && TimeLimet > 0)
        {
            light_.SetActive(false);
        }
        if (toggle == true && TimeLimet > 0)
        {
            light_.SetActive(true);
        }
    }

    void Update()
    {
        CheckTime = TimeLimet;
        LightSlider.value = TimeLimet * 10;
        if (Show == true)
        {
            Battery.SetActive(true);
        }
        if (Show == false)
        {
            Battery.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            //toggleSound.Play();
            if (toggle == false && TimeLimet > 0)
            {
                light_.SetActive(false);
                enemyMonsterAI.Lighting = false;
                enemyMonsterAI.idle = false;
                enemyMonsterAI.walking = true;

                enemyMonsterAI2.Lighting = false;

            }
            if (toggle == true && TimeLimet > 0)
            {
                light_.SetActive(true);
            }
        }
        if (toggle == true)
        {
            TimeLimet = TimeLimet - Time.deltaTime;
        }
        if (TimeLimet <= 0)
        {
            enemyMonsterAI.Lighting = false;
            enemyMonsterAI.idle = false;
            Show = false;
            toggle = false;
            light_.SetActive(false);
            TimeLimet = 0;
            bat100.SetActive(false);
            bat50.SetActive(false);
            bat10.SetActive(false);
        }
        if (TimeLimet > 5 * 2 && TimeLimet <= 10 * 2)
        {
            Color color = new Color(146f / 255f, 255f / 255f, 61f / 255f);
            LightSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
            Show = true;
            bat100.SetActive(true);
            bat50.SetActive(false);
            bat10.SetActive(false);
        }
        if (TimeLimet > 2 * 2 && TimeLimet <= 5 * 2)
        {
            Color color = new Color(252f / 255f, 255f / 255f, 61f / 255f);
            LightSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
            bat100.SetActive(false);
            bat50.SetActive(true);
            bat10.SetActive(false);
        }
        if (TimeLimet > 0 && TimeLimet <= 2 * 2)
        {
            Color color = new Color(233f / 255f, 79f / 255f, 55f / 255f);
            LightSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
            bat100.SetActive(false);
            bat50.SetActive(false);
            bat10.SetActive(true);
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        TimeLimet = TimeLimet - 1;
    }
}