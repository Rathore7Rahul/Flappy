using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class flappyb : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float flapstrenth = 5;
    public logicscript logic;
    public bool birdisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive)
        {
            myrigidbody2D.velocity= Vector3.up * flapstrenth;
        }
       
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive=false;
    }
}
