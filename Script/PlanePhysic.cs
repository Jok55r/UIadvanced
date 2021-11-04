using UnityEngine;
using UnityEngine.UI;

public class PlanePhysic : MonoBehaviour
{
    public GameObject spawner;
    public GameObject plane;

    private void Start()
    {
        InvokeRepeating("StartFlying", 2f, 2f);
    }
    
    void StartFlying()
    {
        Vector2 spawnPoint= new Vector2(spawner.transform.position.x, spawner.transform.position.y);
        Instantiate(plane, spawnPoint, Quaternion.identity);
    }
}