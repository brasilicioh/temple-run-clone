using UnityEngine;

public class GroundRotate : MonoBehaviour
{
    [SerializeField] private GameObject Character, Ground;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                Debug.Log("aaaaa");
                Character.transform.rotation = Ground.transform.rotation;
            }
        }
    }
}
