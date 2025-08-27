using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _score;
    private int Score 
    {
        get => _score;
        set
        {
            _score = value;
            _scoreText.text = _score.ToString();
        }
    }

    private void Awake()
    {
        StartGame();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RaiseScore()
    {
        Score++;
    }

    private void StartGame()
    {
        Score = 0;
    }
}
