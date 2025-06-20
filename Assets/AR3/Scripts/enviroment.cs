using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class enviroment : MonoBehaviour
{

    public AudioMixerSnapshot snapshotIndoor;
    public AudioMixerSnapshot snapshotOutdoor;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "indoor") 
        {
            snapshotIndoor.TransitionTo(0.5f);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        snapshotOutdoor.TransitionTo(0.5f);
    }
}
