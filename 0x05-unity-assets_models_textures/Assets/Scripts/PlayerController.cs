using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public float rotateSpeed = 6.0f;
    private float jumpSpeed = 8.0f;
    private float gravity = 9.0f;

    private Vector3 moveDirection = Vector3.zero;
    public CharacterController playermao;
    private int jumps;

    private void Start()
    {
        playermao = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (playermao.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if(Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        else
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), moveDirection.y, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.x *= speed;
            moveDirection.z *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playermao.Move(moveDirection * Time.deltaTime);
    }    
}