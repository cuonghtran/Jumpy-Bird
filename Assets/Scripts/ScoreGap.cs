using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGap : MonoBehaviour
{
    private Bird _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Bird").GetComponent<Bird>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            _player.AddScore();
        }
    }
}
