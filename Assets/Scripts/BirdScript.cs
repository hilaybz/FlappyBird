using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    [SerializeField] private float jumpScaler = 5f;
    [SerializeField] private GameManager gameManager;
    public bool isAlive = true;

    private float topLimit;
    private float bottomLimit;

    void Start()
    {
        // Get camera bounds in world units
        Camera cam = Camera.main;
        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;

        topLimit = cam.transform.position.y + halfHeight;
        bottomLimit = cam.transform.position.y - halfHeight;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive){
            myRigidBody.linearVelocity = Vector2.up * jumpScaler;
        }

        if (isAlive && (transform.position.y > topLimit || transform.position.y < bottomLimit))
        {
            gameManager.GameOver();
            isAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Any collision = game over
        gameManager.GameOver();
        isAlive = false;

    }

}
