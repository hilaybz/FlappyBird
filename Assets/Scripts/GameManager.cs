using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _gameOverText;
    [SerializeField] private Button _retryButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private PipeSpawner _spawner;


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
    private void Start()
    {
        // hook up buttons
        _retryButton.onClick.AddListener(RestartGame);
        _exitButton.onClick.AddListener(ExitGame);

        // hide UI at start
        _gameOverText.SetActive(false);
        _retryButton.gameObject.SetActive(false);
        _exitButton.gameObject.SetActive(false);
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    
    }

    void Update()
    {
        
    }

    // Call this when bird dies
    public void GameOver()
    {
        if (_spawner) _spawner.enabled = false;  // stops Update() in the spawner

        foreach (var pipe in FindObjectsOfType<MovePipesScript>())
        {
            pipe.Stop();
        }

        _gameOverText.SetActive(true);
        _retryButton.gameObject.SetActive(true);
        _exitButton.gameObject.SetActive(true);
    }

    public void RaiseScore()
    {
        Score++;
    }

    private void StartGame()
    {
        Score = 0;
    }

    public void reStartGame()
    {

    }
}
