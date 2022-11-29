using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    // Start is called before the first frame update
    void FixedUpdate()
    // Called every physics step
    // FixedUpdate intervals are consistent
    // Used for regular updates such as:
    // Adjusting physics (Rigidbody) objects
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
