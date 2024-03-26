using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorCrash : MonoBehaviour
{
    public AudioClip horrorHitSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       


    } 

    private void OnTriggerEnter(Collider other)
    {
         Debug.Log("boo");
         GetComponent<AudioSource>().PlayOneShot(horrorHitSound);
    }
}
