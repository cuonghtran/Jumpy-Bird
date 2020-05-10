using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [SerializeField] private Pipe _pipePrefab;
    private float _timer = 2f;
    private float _canSpawn = 2.3f;
    Vector2 _initialPos;
    private float _newY = 0f;
    private float _defaultX = 3.3f;
    private float _margin = 1.8f;

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
        {
            if (Time.timeSinceLevelLoad >= _canSpawn)
            {
                _canSpawn += _timer;
                _newY = Random.Range(-1.6f, 3.6f);
                Pipe newPipe = Instantiate(_pipePrefab, new Vector3(_defaultX, _newY, 0), Quaternion.identity);
                Destroy(newPipe.gameObject, 5f);
            }
        }
    }
}
