using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteZombie : MonoBehaviour
{
    private VidaZombie vida;
    // Start is called before the first frame update
    void Start()
    {
        vida = gameObject.GetComponent<VidaZombie>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vida.vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
