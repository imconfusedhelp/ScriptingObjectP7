using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    private void FixedUpdate()
        /* called every physics update
         * FixedUpdate intervals are consistent
         * used for regular updates such as:
         * adjusting physics (Rigidbody) objects
         */
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
