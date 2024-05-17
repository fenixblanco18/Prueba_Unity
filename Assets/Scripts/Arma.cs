using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int capacidad = 100;
    public int municion = 0; 
    public float fuerza = 10;
    public GameObject prefabBala;
    public Transform transformSpawner;

    public AudioClip audioShoot;

    public AudioClip audioFail;

    public void Start(){
        municion = capacidad;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IntentarDisparo();
        }
    }
    public void IntentarDisparo(){
        if (municion>0){
            Disparar();
        } else {
            GetComponent<AudioSource>().PlayOneShot(audioFail);
        }
    }
    private void Disparar(){
        GetComponent<AudioSource>().PlayOneShot(audioShoot);
        municion--;
        GameObject bala = Instantiate(prefabBala,transformSpawner.position, transformSpawner.rotation);
        bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerza);
    }

    public void Reload(){
        municion = capacidad;
    }
}
