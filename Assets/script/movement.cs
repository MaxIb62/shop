using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movSpeed;
    float speedY, speedX;
    Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedY = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedX = Input.GetAxisRaw("Vertical") * movSpeed;
        rd.velocity = new Vector2(speedY, speedX) * Time.deltaTime;


    }
}
