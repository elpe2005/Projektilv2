using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }
    void Update()
    {
        var horizontalMove = Input.GetAxis("Horizontal");
        var verticalMove = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * speed * Time.deltaTime;
    }
}
