using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Boundary boundary;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        var startingPosition = Random.RandomRange(boundary.min, boundary.max);
        transform.position = new Vector3(startingPosition, 3.0f, 0.0f);

        speed = Random.Range(1.0f, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        var boundaryLength = boundary.max - boundary.min;
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, boundaryLength) - boundary.max, transform.position.y, 0);
    }
}
