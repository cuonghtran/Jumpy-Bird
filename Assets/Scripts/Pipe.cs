using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float _speed = 1.5f;
    private GameManager _gManager;

    // Start is called before the first frame update
    void Start()
    {
        _gManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_gManager.isGameOver == false)
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
