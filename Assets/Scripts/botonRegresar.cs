using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonRegresar : MonoBehaviour
{
    public GameObject canvas, r1, r2, r3;
    private void OnMouseDown()
    {
        Transform camara = GameObject.Find("Camara").GetComponent<Transform>();
        camara.transform.position = new Vector3(7, 0, -10);
        r1.SetActive(false);
        r2.SetActive(false);
        r3.SetActive(false);
        canvas.SetActive(false);
    }
}
