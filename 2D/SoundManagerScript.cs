using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip UblockDoorSound, walkSound, runSound, UblockDoorSound2, ghostsound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        UblockDoorSound = Resources.Load<AudioClip>("UblockDoor");
        walkSound = Resources.Load<AudioClip>("walk");
        runSound = Resources.Load<AudioClip>("run");
        UblockDoorSound2 = Resources.Load<AudioClip>("UblockDoor2");
        ghostsound = Resources.Load<AudioClip>("ghost");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "UblockDoor":
                audioSrc.PlayOneShot(UblockDoorSound);
                break;
            case "walk":
                audioSrc.PlayOneShot(walkSound);
                break;
            case "run":
                audioSrc.PlayOneShot(runSound);
                break;
            case "UblockDoor2":
                audioSrc.PlayOneShot(UblockDoorSound2);
                break;
            case "ghost":
                audioSrc.PlayOneShot(ghostsound);
                break;
        }
    }

    public void PlayUblockDoor()
    {
       audioSrc.PlayOneShot(UblockDoorSound);
    }

    public void PlayUblockDoor2()
    {
        audioSrc.PlayOneShot(UblockDoorSound2);
    }
}
