using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody rbGround;
    private Vector3 vetor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vetor = Vector3.back;
        rbGround = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rbGround.transform.Translate(vetor * moveSpeed * Time.deltaTime, Space.World);
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }

    public void setVetor(Vector3 vetor)
    {
        Debug.Log("aaaaaaaaa");
        this.vetor = vetor;
    }
}
