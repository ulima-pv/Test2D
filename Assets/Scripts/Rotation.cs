using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //  Rota
            transform.rotation *= Quaternion.Euler(
                0f, 0f, 45f
            );
        }
    }
}
