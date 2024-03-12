using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class FireOnActivate : MonoBehaviour
{
    public AudioSource sound;
    public ParticleSystem watersprays;
    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabs=GetComponent<XRGrabInteractable>();
        grabs.activated.AddListener(startspray);
        grabs.deactivated.AddListener(stopspray);

    }

    private void stopspray(DeactivateEventArgs arg0)
    {
        sound.Stop();   
        watersprays.Stop();

    }

    private void startspray(ActivateEventArgs arg0)
    {
        sound.Play();   
        watersprays.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

}

