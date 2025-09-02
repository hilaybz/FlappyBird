using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    [SerializeField] private float jumpScaler = 5f;
    [SerializeField] private GameManager gameManager;
    public bool isAlive = true;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive){
            myRigidBody.linearVelocity = Vector2.up * jumpScaler;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Any collision = game over
        gameManager.GameOver();
        isAlive = false;

    }

}
