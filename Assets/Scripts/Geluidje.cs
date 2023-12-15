using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geluidje : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;

    public void Playsound()
    {
        source.PlayOneShot(clip);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
