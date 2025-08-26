using UnityEngine;

public class MovePipesScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed at which the pipes move left
    [SerializeField] private float destroyXPosition = -10f; // X position at which pipes are destroyed


    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
