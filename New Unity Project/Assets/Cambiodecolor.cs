using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiodecolor : MonoBehaviour
{
    public string colortexto = "rojo";
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (colortexto)
        {
            case "rojo":
                rend.material.color = Color.red;
                break;

            case "verde":
                rend.material.color = Color.green;
                break;

            case "azul":
                rend.material.color = Color.blue;
                break;

            default:
                rend.material.color = Color.white;
                break;

        }

    }
}
