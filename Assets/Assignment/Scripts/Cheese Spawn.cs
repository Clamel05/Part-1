using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawn : MonoBehaviour
{
    public GameObject CheesePrefab;
    public Transform Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
          Instantiate(CheesePrefab, Spawnpoint.position, Spawnpoint.rotation);
         
        }
    }
}
