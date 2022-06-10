using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuisanteProyectil : MonoBehaviour
{
    public float velocidad;
    public int daño;
    public Vector3 posicionInicial;


    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        if(Vector3.Distance(transform.position, posicionInicial) > 10)
        {
            Destroy(gameObject);
        }
    }

    void onTriggerEnter(Collider other)
    {
        if(other.tag == "Zombie")
        {
            other.GetComponent<VidaZombie>().vida -= daño;
            Destroy(gameObject);
        }
    }
}
