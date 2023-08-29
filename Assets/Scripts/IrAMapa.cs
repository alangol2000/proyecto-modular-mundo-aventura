using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class IrAMapa : MonoBehaviour
{
    private void OnMouseDown()
    {
        

        Transform camara = GameObject.Find("Camara").GetComponent<Transform>();
        camara.transform.position = new Vector3(7, 0, -10);
    }
}
