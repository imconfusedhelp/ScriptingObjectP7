using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    private void Awake()
        //Set ammo for the enemy
    {
        Debug.Log("Awake called.");
    }
    // Start is called before the first frame update
    void Start()
        //Allow enemy to shoot
    {
        Debug.Log("Start called");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
