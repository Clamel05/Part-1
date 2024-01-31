using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (door.activeInHierarchy == false)
        {
            door.SetActive (true);
        }
        else
        {
            door.SetActive (false);
        }
    }

}
