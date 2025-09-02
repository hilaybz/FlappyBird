using UnityEngine;

public class MovePipesScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed at which the pipes move left
    [SerializeField] private float destroyXPosition = -10f; // X position at which pipes are destroyed
    private bool isMoving = true; // flag to control movement


    void Start()
    {
        
    }

    void Update()
    {
        if (!isMoving) return;
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }

    public void Stop()
    {
        isMoving = false;
    }
}
