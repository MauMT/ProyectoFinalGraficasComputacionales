using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuisanteProyectil : MonoBehaviour
{
    public float velocidad = 0f;
    int daño = 10;
    public Vector3 posicionInicial;
    


    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);

        // destroys projectiles when they go out of the screen
        if(Vector3.Distance(transform.position, posicionInicial) > 10)
        {
            Destroy(gameObject);
            //Debug.Log("se salió de la pantalla");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Zombie")
        {
            
            Debug.Log(other.GetComponent<Health>().health);
            other.GetComponent<Health>().health -= daño;
            Debug.Log(other.GetComponent<Health>().health);
            Destroy(gameObject);
        }
    }
}
