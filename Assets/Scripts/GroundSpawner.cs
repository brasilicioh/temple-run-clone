using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private float zPosition;
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private Transform pivotSpawn;

    private bool canSpawn = true;


    void OnTriggerEnter(Collider other)
    {
        if (!canSpawn)
        {
            return;
        }
        //NECESSARIO FAZER O SPAWNOBSTACLE SE MOVER JUNTO COM O CHÃO
        if (other.CompareTag("Player"))
        {
            Vector3 spawnPosition;
            float[] rotacoesPossiveis = {-90f, 0f, 90f};
            float rotY = rotacoesPossiveis[Random.Range(0, rotacoesPossiveis.Length)];
            Quaternion newRot = Quaternion.Euler(0, rotY, 0);

            if (rotY == 90f) {
                spawnPosition = pivotSpawn.position + new Vector3(-42, 0, 0);
            } 
            else if (rotY == -90f) {
                spawnPosition = pivotSpawn.position + new Vector3(42, 0, 0);
            } else {
                spawnPosition = pivotSpawn.position + new Vector3(0f, 0, zPosition);
            }

            canSpawn = false;
            Instantiate(groundPrefab, spawnPosition, newRot);
        }
    }
}
