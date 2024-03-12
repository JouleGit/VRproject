using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbywater : MonoBehaviour
{
    public int hitcount = 0;
    public GameObject stuff;
    public int targetHitCount;
    public ParticleSystem targetspray;


    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.name == targetspray.name)
        {
            hitcount++;
        }
        
        if (hitcount == targetHitCount) {
            gameObject.SetActive(false);
        }
        

    }
}
