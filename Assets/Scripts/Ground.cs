using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody rbGround;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbGround = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rbGround.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }



    void SpawnGround(){
        
    }
}
