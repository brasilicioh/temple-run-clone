using UnityEngine;

public class GroundRotate : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 position = groundPrefab.transform.position;
                groundPrefab.transform.position = new Vector3(0f, position.y, position.z);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                ...
            }
        }
    }
}
