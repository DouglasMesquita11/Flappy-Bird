using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject message, duck;
    [SerializeField] private GameObject pipes, Source;
    private float timeToSpawn = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0f, timeToSpawn);
        
    }
    private void SpawnPipes()
    {
            Instantiate(
                pipes,
                Source.transform.position,
                Quaternion.identity
            );
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            duck.SetActive(true);
            Destroy(message);
        }
    }
}
