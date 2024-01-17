using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missile : MonoBehaviour
    
{
    public float speed = 10f;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // Transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + direction);

    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("missile collision");
        Destroy(gameObject);
    }
}
