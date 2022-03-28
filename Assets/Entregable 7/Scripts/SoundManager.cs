using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource controlAudio;
    [SerializeField] private AudioClip[] Audios;
    public float volumen = 2;

    // Start is called before the first frame update
    void Start()
    {
        controlAudio = GetComponent<AudioSource>();
    }

    public void SeleccionAudio (int indice, float volumen)
    {
        controlAudio.PlayOneShot(Audios[indice], volumen);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
