using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IMGUIManager : MonoBehaviour
{
    public bool IsShown = false;
    public string ElementoSpawn = "0";
    public Spawner MySpawner;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsShown = !IsShown;
        }
    }
    private void OnGUI() {
        
        if (IsShown)
        {
            GUI.Box(new Rect(10,10,100,90), "Opciones");
            ElementoSpawn = GUI.TextField (
                new Rect(20,40,80,20), ElementoSpawn
            );
            MySpawner.SetSpawnIndex(int.Parse(ElementoSpawn));
        }
    }
}
