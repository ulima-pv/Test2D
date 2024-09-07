using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> Plantillas;
    private int m_SpawnIndex = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //int randomPos = UnityEngine.Random.Range(0, Plantillas.Count);
            Instantiate(
                Plantillas[m_SpawnIndex],
                new Vector3(0f, 0f ,0f),
                Quaternion.identity
            );
        }
    }

    public void SetSpawnIndex(int newIndex)
    {
        m_SpawnIndex = newIndex;
    }
}
