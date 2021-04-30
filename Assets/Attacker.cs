using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.z = position.z + speed * Time.deltaTime;
        
        //할당을 잊지 말도록!
        transform.position = position;

        //두번째
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
