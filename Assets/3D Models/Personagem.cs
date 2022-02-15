using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    public float moveForce;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Move(Vector2 input)
    {
        rb.AddForce(new Vector3(input.x, 0, 0) * moveForce);
    }
     void FixedUpdate()
    {
        
    }
}
