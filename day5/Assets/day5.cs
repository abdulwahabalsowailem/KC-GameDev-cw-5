using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day5 : MonoBehaviour
{
    float playerinput;
    public int speed;

    Rigidbody2D RD;



    // Start is called before the first frame update
    void Start()
    {
        RD = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerinput = Input.GetAxis("Horizontal");
        RD.velocity = new Vector2(playerinput * speed, 0);


    }
}
