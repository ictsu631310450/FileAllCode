using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public static float walkingSpeed = 2f;
    public static float runningSpeed = 4f;
    //public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;

    CharacterController characterController;
    public static bool characterControllerint;
    internal static Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    public float TimeRun = 100.0f;
    public Slider RunSlider;

    [HideInInspector]
    public bool canMove = true;
    public static bool canMoveint = true;

    public static int Battery = 0;
    public int Battery_show;

    public bool crouching;
    private Vector3 crouchScale = new Vector3(1, 0.5f, 1);
    private Rigidbody rb;
    public bool grounded;
    private Vector3 playerScale;

    public GameObject AreaSound;
    BoxCollider col;

    public static bool Hideing;

    public static bool Warpint = false;

    void Start()
    {
        //GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
        characterController = GetComponent<CharacterController>();
        playerScale = transform.localScale;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        col = GetComponent<BoxCollider>();
        //transform.position = Warp.position;
    }

    private void StartCrouch()
    {
        transform.localScale = crouchScale;
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        //if (rb.velocity.magnitude > 0.5f)
        //{
        //    if (grounded)
        //    {
        //        rb.AddForce(orientation.transform.forward * slideForce);
        //    }
        //}
    }

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Locker"))
    //    {
    //        characterController = other.gameObject.GetComponent<CharacterController>();
    //    }
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Locker"))
    //    {
    //        gameObject.tag = "Locker";
    //        //StartCoroutine(StartCooldown());
    //    }
    //}
    //public IEnumerator StartCooldown()
    //{
    //    yield return new WaitForSeconds(3);
    //    gameObject.tag = "Locker";
    //}
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Locker"))
    //    {
    //        gameObject.tag = "Player";
    //    }
    //}

    public void OncharacterController()
    {
        characterController.enabled = true;
    }
    public void OFFcharacterController()
    {
        characterController.enabled = false;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void StopCrouch()
    {
        transform.localScale = playerScale;
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
    }

    void Update()
    {
        if (Hideing == true)
        {
            gameObject.tag = "Locker";
        }
        if (Hideing == false)
        {
            gameObject.tag = "Player";
        }
        Battery_show = Battery;
        RunSlider.value = TimeRun;
        ChangeBoxcold.PlayerMove = canMove;

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        // Run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        crouching = Input.GetKey(KeyCode.LeftControl);
        if (Input.GetKeyDown(KeyCode.LeftControl))
            StartCrouch();
        if (Input.GetKeyUp(KeyCode.LeftControl))
            StopCrouch();

        //if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        //{
        //    moveDirection.y = jumpSpeed;
        //}
        //else
        //{
        //    moveDirection.y = movementDirectionY;
        //}
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.W))
            {
                TimeRun = TimeRun - Time.deltaTime * 2;
            }
            if (Input.GetKey(KeyCode.A))
            {
                TimeRun = TimeRun - Time.deltaTime * 2;
            }
            if (Input.GetKey(KeyCode.S))
            {
                TimeRun = TimeRun - Time.deltaTime * 2;
            }
            if (Input.GetKey(KeyCode.D))
            {
                TimeRun = TimeRun - Time.deltaTime * 2;
            }
        }
        else
        {
            TimeRun = TimeRun + Time.deltaTime / 2;
        }
        if (TimeRun >= 100)
        {
            TimeRun = 100;
        }
        if (RunSlider.value >= 70 && RunSlider.value <= 100)
        {
            Color color = new Color(146f / 255f, 255f / 255f, 61f / 255f);
            RunSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
        }
        if (RunSlider.value >= 40 && RunSlider.value <= 70)
        {
            Color color = new Color(252f / 255f, 255f / 255f, 61f / 255f);
            RunSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
        }
        if (RunSlider.value >= 0 && RunSlider.value <= 40)
        {
            Color color = new Color(233f / 255f, 79f / 255f, 55f / 255f);
            RunSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
        }


        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        //{
        //    TimeRun = TimeRun - Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        //{
        //    TimeRun = TimeRun - Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        //{
        //    TimeRun = TimeRun - Time.deltaTime;
        //}
        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime * 100;
        }
        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Player and Camera rotation
        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }

    }
}
