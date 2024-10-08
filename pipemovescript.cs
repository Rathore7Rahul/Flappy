using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pipemovescript : MonoBehaviour
{
    public float movespeed = 10;
    public float deadzone =-10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position + (Vector3.left *movespeed) * Time.deltaTime;
        if (transform.position.x < deadzone) 
        {
            Destroy(gameObject);
        }
    }
}
