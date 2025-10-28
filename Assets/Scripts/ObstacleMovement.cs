using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float ObstacleSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * ObstacleSpeed * Time.deltaTime);

        //obstacles are destroyed after exiting the game camera
        if (transform.position.z < - 13)
        {
            Destroy(gameObject);
        }
    }
}
