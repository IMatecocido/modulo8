using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int intCounter = 0;
    public float floatValue = 1.0f;
    public float multiplier = 1.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intCounter += 1;
        Debug.Log("El valor del IntCounter es" + intCounter);
    }
    private void FixedUpdate()
    {
        floatValue *= multiplier;
        Debug.Log("El valor del floatvalue es"+floatValue);
    }

}
