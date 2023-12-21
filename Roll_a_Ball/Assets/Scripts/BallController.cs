using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int Speed;
    public Rigidbody Physical;
  
    void Start()
    {
        Physical = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vektor = new Vector3(horizontal, 0, vertical);

        Physical.AddForce(vektor*Speed);
    }
    void Update()
    {
        
    }

    
}
