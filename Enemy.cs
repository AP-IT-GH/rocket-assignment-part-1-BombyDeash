using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float moveDistance;

    private float distanceTravelled;
    private float nextPosition;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        distanceTravelled = 0;
        nextPosition = 0;
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        nextPosition = speed * Time.deltaTime * direction;
        distanceTravelled += nextPosition;
        if (distanceTravelled > moveDistance || distanceTravelled < 0)
        {
            direction *= -1;
            nextPosition = speed * Time.deltaTime * direction;
        }
        transform.Translate(Vector3.up * nextPosition);
        Debug.Log(distanceTravelled);
    }
}
