using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umiranje : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    void Start()
    {
        Destroy(gameObject, time); 
    }
}