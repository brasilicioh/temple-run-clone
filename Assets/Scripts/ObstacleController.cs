using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Obstacle", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Obstacle()
    {
        string[] obstacles = { "Up", "Down", "None"};
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
                    Quaternion.identity //esse Quaternion identity n deveria estar dentro do parenteses? não lembro como ele funciona
                );
                Debug.Log("Up");
                break;
            case "Down":
                Instantiate(
                    obstacle,
                    new Vector3(0f, transform.position.y, transform.position.z),
                    Quaternion.identity
                );
                //Rotaciona obstaculo há 90°
                Debug.Log("Down");
                break;
        }
    }
}
