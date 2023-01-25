using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] Rigidbody2D spawnPlace;
    [SerializeField] private float timeLeft,originalTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft<= 0 )
        {
            SpawnBlock();
            timeLeft = originalTime;
        }
    }

    private void SpawnBlock()
    {
        GameObject spawnedBlock = Instantiate(block,spawnPlace.position,Quaternion.identity);
        
    }

    
}
