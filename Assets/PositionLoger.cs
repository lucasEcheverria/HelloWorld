using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLoger : MonoBehaviour
{

    private GameObject gO;
    public Vector3 posicionAnterior;

    // Start is called before the first frame update
    void Start()
    {
        gO = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Posición: " + gO.transform.position);
        posicionAnterior = gO.transform.position;
    }
}
