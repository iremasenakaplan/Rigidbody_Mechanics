using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public Rigidbody Physical;

    public int Speed;
    public int counter;
    public int objectsOfNumber;

    public Text scoreText;
    public Text winnerText;
  
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

     void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        counter++;

        scoreText.text = "Score:" + counter;

        if(counter == objectsOfNumber)
        {
            winnerText.gameObject.SetActive(true);
        }
    }

}
