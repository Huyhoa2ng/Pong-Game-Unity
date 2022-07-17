using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPLayer1 : MonoBehaviour
{
    public float ballMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * ballMovement;
    }
}
