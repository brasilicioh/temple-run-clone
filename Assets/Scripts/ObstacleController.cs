using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void CreateObstacle()
    {
        //O SpawnObstacle está no prefab do chão
        string[] obstacles = { "Up", "Down", "None", "None" };
        int tamanho = obstacles.Length;
        int position = Random.Range(0, tamanho);
        string obstaclePosition = obstacles[position];
        float positionY = 5f; //Altura temporaria
        switch (obstaclePosition)
        {
            case "Up":
                Instantiate(
                    obstacle,
                    new Vector3(0f, positionY, transform.position.z),
                    Quaternion.identity
                );
                break;
            case "Down":
                Instantiate(
                    obstacle,
                    new Vector3(0f, transform.position.y, transform.position.z),
                    Quaternion.identity
                );
                break;
        }
    }
    
}
