using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speedX = 1.0f;
    [SerializeField] private float speedY = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {

        Vector3 dir = Vector3.zero;

        dir.x = Input.acceleration.x;
        dir.y = Input.acceleration.y;
        dir.z = Input.acceleration.z;

        Debug.Log(dir.x.ToString());

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        transform.Translate(new Vector3(dir.x * speedX, dir.y * speedY, 0));
    }
}
