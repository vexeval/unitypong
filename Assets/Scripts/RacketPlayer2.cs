using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    public float movementSpeed;
    public RacketPlayer2AI obj;
    
    private void FixedUpdate()
    {
        if (!obj.active)
        {
            float v = Input.GetAxisRaw("Vertical2");

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
        }
            
    }
}
