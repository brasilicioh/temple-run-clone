using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private GameObject obstacleUp;
    [SerializeField] private GameObject obstacleDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Obstacle()
    {
        string[] obstacles = { "Up", "Down" };
        int position = Random.Range(0, 2);
        string obstaclePosition = obstacles[position];
        switch (obstaclePosition)
        {
            case "Up":
                Instantiate(
                    obstacleUp,
                    new Vector3(0f, 0.5f, transform.position.z),
                    Quaternion.identity
                );
                Debug.Log("Up");
                break;
            case "Down":
                Instantiate(
                    obstacleDown,
                    new Vector3(0f, -1.5f, transform.position.z),
                    Quaternion.identity
                );
                Debug.Log("Down");
                break;
        }
    }
}
