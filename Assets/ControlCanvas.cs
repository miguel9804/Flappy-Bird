using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCanvas : MonoBehaviour
{
    public GameObject[] canvas;

    public void Puntaje()
    {
        canvas[0].SetActive(false);
        canvas[1].SetActive(false);
        canvas[2].SetActive(true);
    }
    public void Back()
    {
        canvas[3].SetActive(false);
        canvas[2].SetActive(false);
        canvas[1].SetActive(true);
        canvas[0].SetActive(true);
    }

    public void Name()
    {
        canvas[0].SetActive(false);
        canvas[1].SetActive(false);
        canvas[3].SetActive(true);
    }
}
