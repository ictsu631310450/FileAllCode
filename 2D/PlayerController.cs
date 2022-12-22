using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //
    public Animator PlayerAnimator;
    public bool run = false;
    AudioSource audioSrc;
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        run = false;
        if (run != true)
        {
            float dirx/*, diry*/;
            dirx = Input.GetAxis("Horizontal");
            //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            //{
            //    isMoving = true;
            //}
            //else
            //{
            //    isMoving = false;
            //}
            //if (isMoving && Time.timeScale == 1)
            //{
            //    if (!audioSrc.isPlaying)
            //    {
            //        audioSrc.Play();
            //    }
            //}
            //else
            //{
            //    audioSrc.Stop();
            //}
            PlayerAnimator.SetFloat("Speed", Mathf.Abs(dirx));
            transform.Translate(Time.deltaTime * 5 * dirx, 0, 0);
            #region สำหรับการหันซ้ายขวา
            if (dirx > 0) { transform.localScale = new Vector3(1, 1, 1);}
            if (dirx < 0) { transform.localScale = new Vector3(-1, 1, 1); }
            #endregion
            if (Input.GetKey(KeyCode.LeftShift))
            {
                run = true;

            }
        }

        if (run == true && Input.GetKey(KeyCode.A))
        {
            float dirx/*, diry*/;
            dirx = Input.GetAxis("Horizontal");

            PlayerAnimator.SetFloat("Speed", 6);
            transform.Translate(Time.deltaTime * 5 * dirx, 0, 0);

            #region สำหรับการหันซ้ายขวา
            if (dirx > 0) { transform.localScale = new Vector3(1, 1, 1); }
            if (dirx < 0) { transform.localScale = new Vector3(-1, 1, 1); }
            #endregion
        }

        if (run == true && Input.GetKey(KeyCode.D))
        {
            float dirx/*, diry*/;
            dirx = Input.GetAxis("Horizontal");

            PlayerAnimator.SetFloat("Speed", 6);
            transform.Translate(Time.deltaTime * 5 * dirx, 0, 0);

            #region สำหรับการหันซ้ายขวา
            if (dirx > 0) { transform.localScale = new Vector3(1, 1, 1); }
            if (dirx < 0) { transform.localScale = new Vector3(-1, 1, 1); }
            #endregion
        }
    }
}
