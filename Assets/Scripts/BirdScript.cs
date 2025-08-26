using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    [SerializeField] private float jumpScaler = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            myRigidBody.linearVelocity = Vector2.up * jumpScaler;
        }
    }
}
