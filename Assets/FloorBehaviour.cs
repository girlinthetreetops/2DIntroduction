using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour
{
    public CollectorScript collectorScript;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ThunderCloud") || collision.gameObject.CompareTag("Cloud"))
        {
            Destroy(collision.gameObject);

            if (collision.gameObject.CompareTag("Cloud"))
            {
                collectorScript.updateScore(-1);
            }
        }
    }
}
