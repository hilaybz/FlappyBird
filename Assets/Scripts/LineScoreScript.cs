using UnityEngine;

public class LineScoreScript : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))   // only the bird triggers
        {
            gameManager?.RaiseScore();
        }
    }

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
