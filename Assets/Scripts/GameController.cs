using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    [SerializeField] private GameObject Ground, SpawnSource;
    private int Score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore()
    {
        Score += 1;
        Debug.Log("Score: " + Score);
    }

    public void SpawnGround(){
        Vector3 Spawn = SpawnSource.transform.position;
        Instantiate(Ground, Spawn, Quaternion.identity);
    }
}
