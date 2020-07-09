using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float rotateSpeed = 6.0f;
    private float jumpSpeed = 9f;
    public float gravity = 18f;
    private Transform cam;

    Vector3 velocity;
    private Vector3 direction = Vector3.zero;
    private Vector3 startPosition;
 
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    Animator anim;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        cam = GetComponent<Transform>();
        startPosition = cam.position;
       
    }
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (controller.isGrounded)
        {
            Debug.Log("TIERRA ON");

            direction = new Vector3(horizontal, 0, vertical).normalized;
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            direction = cam.right * direction.x + cam.forward * direction.z;
            direction.y = 0f;
            direction *= speed;

            if(Input.GetButtonDown("Jump"))
            {
                direction.y = jumpSpeed;
            }
            
        }
        else
        {
            Debug.Log("TIERRA OFF");
            direction = new Vector3(horizontal, direction.y, vertical);
            direction = transform.TransformDirection(direction);


            direction.x *= speed;
            direction.z *= speed;
           
        }
        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);


        //if fall restart from sky
        if (cam.position.y < -20)
        {
           cam.position = new Vector3(startPosition.x, startPosition.y + 15, startPosition.z);
        }
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run",false);
        }
    }    
}