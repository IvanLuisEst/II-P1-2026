using UnityEngine;

public class PositionSphere : MonoBehaviour
{
    private Vector3 posicionEsfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionEsfera = transform.position;
        Debug.Log("Posición de la esfera: " + posicionEsfera);
    }
}
