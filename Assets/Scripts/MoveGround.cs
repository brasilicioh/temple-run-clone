using UnityEngine;

public class MoveGround : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public bool EraseGround;
    [SerializeField] private float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EraseGround = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
}
