using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimiter : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed;
    private Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody2d.velocity.magnitude > maxSpeed)
        {
            rigidbody2d.velocity = rigidbody2d.velocity.normalized * maxSpeed;
        }
    }
}
