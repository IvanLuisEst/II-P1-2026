using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Vector3 colorVector;
    public int framesEspera;
    private int contadorFrames = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorVector = new Vector3(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );
    }

    // Update is called once per frame
    void Update()
    {
        contadorFrames++;
        if (contadorFrames >= framesEspera)
        {
            int posicionAleatoria = Random.Range(0, 3);
            if (posicionAleatoria == 0)
            {
                colorVector.x = Random.Range(0.0f, 1.0f);
            }
            else if (posicionAleatoria == 1)
            {
                colorVector.y = Random.Range(0.0f, 1.0f);
            }
            else
            {
                colorVector.z = Random.Range(0.0f, 1.0f);
            }

            Color nuevoColor = new Color(
                colorVector.x,
                colorVector.y,
                colorVector.z
            );
            GetComponent<Renderer>().material.color = nuevoColor;
            contadorFrames = 0;
        }
    }
}
