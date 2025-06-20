using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicChange : MonoBehaviour
{

    public AudioMixerSnapshot baseSnapshot;
    public AudioMixerSnapshot calmSnapshot;
    public AudioMixerSnapshot combatSnapshot;

    public float transitionTime = 2.0f;
    public float transitionTimeCombat = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tensionArea")
        {
            calmSnapshot.TransitionTo(transitionTime);
        }
        else if (other.gameObject.tag == "indoor") 
        {
        combatSnapshot.TransitionTo(transitionTimeCombat);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "tensionArea")
        {
            baseSnapshot.TransitionTo(transitionTime);
        }
        else if (other.gameObject.tag == "indoor")
        {
            calmSnapshot.TransitionTo(transitionTimeCombat);
        }
    }
}
