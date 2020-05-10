using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _gameOverText;
    [SerializeField] private Button _restartButton;
    private Bird _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Bird").GetComponent<Bird>();
    }

    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// It is called after all Update functions have been called.
    /// </summary>
    void LateUpdate()
    {
        _scoreText.text = _player.score.ToString();
    }

    public void GameOverSequence()
    {
        _gameOverText.gameObject.SetActive(true);
        _restartButton.gameObject.SetActive(true);
    }
}
