using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree1DController : MonoBehaviour
{
    public KeyCode keyCodeUP;
    public KeyCode keyCodeDOWN;
    public float speed = 0;
    public float delta;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCodeUP)){
            speed += delta;
        } else if (Input.GetKeyDown(keyCodeDOWN)){
            speed -= delta;
        }
        GetComponent<Animator>().SetFloat("Speed",speed);
    }
}
