using UnityEngine;

public class DistanceSphere : MonoBehaviour
{
    private Transform transformEsfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject laEsfera = GameObject.FindWithTag("blue_sphere");
        if (laEsfera != null)
        {
            transformEsfera = laEsfera.transform;
            float distancia = Vector3.Distance(transform.position, transformEsfera.position);
            Debug.Log("Distancia entre la esfera y el " + gameObject.name + ": " + distancia);
        }
        else
        {
            Debug.LogWarning("No se encontró ningún objeto con la etiqueta 'blue_sphere'.");
        }
    }
}
