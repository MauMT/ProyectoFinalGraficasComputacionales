using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteZombie : MonoBehaviour
{
    private Health hscr;
    // Start is called before the first frame update
    void Start()
    {
        hscr = gameObject.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hscr.health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
