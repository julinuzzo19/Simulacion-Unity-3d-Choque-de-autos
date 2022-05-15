using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    private Vector3 PosicionInicial;
    private Vector3 PosicionFinal;
    public Vector3 PosicionDestino;

    public float speed= 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosicionInicial = transform.position;
        PosicionFinal = PosicionInicial + PosicionDestino * Time.deltaTime * speed;
        transform.position = PosicionFinal;
    }
}
