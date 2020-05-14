using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _speed = 3.5f;
    private Rigidbody2D _rigidBody;
    private GameManager _gManager;
    private UIManager _uiManager;
    private Animator _anim;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _gManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_gManager.isGameOver == false)
        {
            // handle touch
            int i = 0;
            while (i < Input.touchCount)
            {
                _rigidBody.velocity = Vector2.up * _speed;
                
                ++i;
            }
        }

        // for testing
        #if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Space))
                _rigidBody.velocity = Vector2.up * _speed;
        
        #endif
    }

    public void AddScore()
    {
        score++;
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        _anim.StopPlayback();
        _gManager.isGameOver = true;
        _uiManager.GameOverSequence();
    }
}
