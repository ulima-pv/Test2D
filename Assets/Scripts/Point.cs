using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Transform Target;
    public float SpeedX = 0.5f;
    public float SpeedY = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if (!HayColisionConTarget())
        {
            Vector3 direction = Target.position - transform.position;
            direction.Normalize();
            Vector3 mov = new Vector3(
                direction.x * SpeedX, 
                direction.y * SpeedY, 
                0f
            );
            transform.position += mov * Time.deltaTime;
        }
    }

    public bool HayColisionConTarget()
    {
        float distancia = Vector3.Distance(
            Target.position, 
            transform.position
        );
        float sumaRadios = 
            transform.GetComponent<Triangulo>().Radio +
            Target.GetComponent<Cuadrado>().Radio;
        
        if (distancia <= sumaRadios)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
