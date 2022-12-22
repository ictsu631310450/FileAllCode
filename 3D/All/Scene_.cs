using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_ : MonoBehaviour
{
    public GameObject SelectMode;
    public GameObject FadeOut;

    public void StartButton()
    {
        SelectMode.SetActive(true);
    }

    public void EasyButton()
    {
        pickupBaterly.Hard = false;
        pickupflashlight.Hard = false;
        FadeOut.SetActive(true);
        StartCoroutine(StartCooldown());
    }
    public void HadeButton()
    {
        pickupBaterly.Hard = true;
        pickupflashlight.Hard = true;
        FadeOut.SetActive(true);
        StartCoroutine(StartCooldown());
    }

    public IEnumerator StartCooldown()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Scene1");

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
