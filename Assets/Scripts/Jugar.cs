using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Jugar : MonoBehaviour
{
    public Text texto;
    public string letra;
    public Image animal1, animal2, animal3;
    public List<Sprite> animales;
    public List<Sprite> respuestas;
    public GameObject canvas, r1,r2,r3;
    
    
    private void OnMouseDown()
    {
        Transform camara = GameObject.Find("Camara").GetComponent<Transform>();
        camara.transform.position = new Vector3(14, 0, -10);
        texto.GetComponent<Text>().text = "Selecciona el animal que empiece con la letra: " + letra;
        canvas.SetActive(true);
        if(letra == "A")
        {
            animal1.GetComponent<Image>().sprite = animales[0];
            animales.Remove(animales[0]);
            animal2.GetComponent<Image>().sprite = animales[Random.Range(0,animales.Count)];
            animal3.GetComponent<Image>().sprite = animales[Random.Range(0, animales.Count)];

            r1.GetComponent<Image>().sprite = respuestas[0];
            r2.GetComponent<Image>().sprite = respuestas[1];
            r3.GetComponent<Image>().sprite = respuestas[1];

            
        }
        if (letra == "B")
        {
            animal2.GetComponent<Image>().sprite = animales[1];
            animales.Remove(animales[1]);
            animal1.GetComponent<Image>().sprite = animales[Random.Range(0, animales.Count)];
            animal3.GetComponent<Image>().sprite = animales[Random.Range(0, animales.Count)];

            r1.GetComponent<Image>().sprite = respuestas[1];
            r2.GetComponent<Image>().sprite = respuestas[0];
            r3.GetComponent<Image>().sprite = respuestas[1];


        }


    }
    public void esRespuestaCorrecta()
    {
        if(letra == "A")
        {
            if(EventSystem.current.currentSelectedGameObject.name == "animal1")
            {
                r1.SetActive(true);
                texto.GetComponent<Text>().text = "¡Bien hecho!";
            }
            if (EventSystem.current.currentSelectedGameObject.name == "animal2")
            {
                r2.SetActive(true);
            }
            if (EventSystem.current.currentSelectedGameObject.name == "animal3")
            {
                r3.SetActive(true);
            }
        }
        if (letra == "B")
        {
            if (EventSystem.current.currentSelectedGameObject.name == "animal1")
            {
                r1.SetActive(true);
            }
            if (EventSystem.current.currentSelectedGameObject.name == "animal2")
            {
                r2.SetActive(true);
                texto.GetComponent<Text>().text = "¡Bien hecho!";

            }
            if (EventSystem.current.currentSelectedGameObject.name == "animal3")
            {
                r3.SetActive(true);
            }
        }
    }
}
