using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    private bool jumping;
    private bool isGrounded;
    [SerializeField] private float jumpForce;
    [SerializeField] private float velocity;
    

    void Start()
    {
        isGrounded = true;
        jumping = false;
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumping = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Slide();
        }

        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move * velocity * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (jumping)
        {
            jumping = false;
            animator.SetBool("Jump", true);
            rigidbody.linearVelocity = Vector3.up * jumpForce;
        }
    }

    public void Slide()
    {
        animator.SetBool("Slide", true);
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void StopSlide()
    {
        animator.SetBool("Slide", false);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            animator.SetBool("Jump", false);
            isGrounded = true;
        }
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("GroundSpawn")){
            GameController.instance.SpawnGround();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
