using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        Door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(Door.activeInHierarchy == true)
        {
            Door.SetActive(false);
            Debug.Log("true - false");
        }
        else
        {
            Door.SetActive(true);
        }

    }


}
