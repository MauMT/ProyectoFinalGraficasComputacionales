using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float Cooldown=1f;
    private float cd;
    public GameObject pea;
    Vector3 posicionInicial;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown;
        posicionInicial = transform.position;
        //Debug.Log(posicionInicial);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cd > 0){
            cd -= Time.deltaTime;
        }
        else{
            RaycastHit hit; 
            Vector3 newPosition = posicionInicial;
            newPosition.z = newPosition.z - 1.35f;
            Debug.Log(newPosition);
            if(Physics.Raycast(newPosition, Vector3.right, out hit, Mathf.Infinity)){
                Debug.Log("entra raycast"+hit.collider.name);
                
                if(hit.transform.tag == "Zombie"){
                    cd = Cooldown;
                    Debug.Log("entra zombie");
                    audioSource.Play();
                    Instantiate(pea, newPosition, Quaternion.identity).GetComponent<GuisanteProyectil>().velocidad = 1f;
                    

                }
            } 
            
        
        }
    }
}
