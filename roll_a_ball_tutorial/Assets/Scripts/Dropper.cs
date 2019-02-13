using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    public Transform droppercube;
    private float x = 10;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("TimeWait", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void TimeWait()
    {
        Instantiate(droppercube, new Vector3(x, 20, 0), Quaternion.identity);
        x = x * -1;
    }
}