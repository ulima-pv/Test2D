using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float SpeedX = 0.5f;
    public float SpeedY = 0.5f;
    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3(SpeedX, SpeedY, 0f);
        transform.position += mov * Time.deltaTime;
    }
}
