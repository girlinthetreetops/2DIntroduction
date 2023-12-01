using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * 1 * speed * Time.deltaTime);
        }
    }
}
