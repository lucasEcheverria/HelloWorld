using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    private Transform transformacion;    

    // Start is called before the first frame update
    void Start()
    {
        transformacion = this.getComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        Debug.Logformat("La transoformación del objeto es: {0}", transformacion.localPosition.x);   
        Debug.Logformat("La transoformación del objeto es: {0}", transformacion.localPosition.y); 
        Debug.Logformat("La transoformación del objeto es: {0}", transformacion.localPosition.z); 
    }
}
