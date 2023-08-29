using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public void mueveCamara(int x, int y, int z)
    {
        Transform camara = GameObject.Find("Camara").GetComponent<Transform>();
        camara.transform.position = new Vector3(x, y, z);
    }
    
}
