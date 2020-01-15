using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject waterDrop;
    [SerializeField]
    [Range(1,100)]
    [Min(1)]
    private float rate = 1;
    [SerializeField]
    private int quantity;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        Instantiate(waterDrop, transform.position + Vector3.right * Random.Range(-0.05f, 0.05f), Quaternion.identity);
        if(--quantity>0)
            Invoke("Spawn", 1/rate);
    }
}
