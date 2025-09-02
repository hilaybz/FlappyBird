using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;  // reference to your PipePair prefab

    [SerializeField] private float spawnInterval = 2f; // tweakable delay
    [SerializeField] private float verticalRange = 2f; // how much pipes can vary up/down

    private float timer = 0f;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0f;
            spawnPipe();
        }

    }

    void spawnPipe()
    {
        float verticalOffset = Random.Range(-verticalRange, verticalRange);
        Instantiate(pipePrefab, new Vector3(transform.position.x, transform.position.y + verticalOffset, 0), transform.rotation);
    }
}
