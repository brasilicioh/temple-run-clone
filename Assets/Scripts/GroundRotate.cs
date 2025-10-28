using UnityEngine;

public class GroundRotate : MonoBehaviour
{
    [SerializeField] private GameObject Player, ground;
    private float rotY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRot(float rotY)
    {
        this.rotY = rotY;
    }

    void OnTriggerStay(Collider other)
    {
        // NÃO TA FUNCIONANDOOOOOOOOOOOOOOOOOOO
        MoveGround script = ground.GetComponent<MoveGround>();
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                Player.transform.rotation = Quaternion.Euler(0, rotY*-1, 0);
                switch (rotY) {
                    case 0f:
                        script.setVetor(Vector3.back);
                        break;
                    case -90f:
                        script.setVetor(Vector3.right);
                        break;
                    case 90f:
                        script.setVetor(Vector3.left);
                        break;
                }
            }
        }
    }
}
