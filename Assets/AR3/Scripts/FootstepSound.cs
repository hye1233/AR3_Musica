using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;

    public string material;

    // Start is called before the first frame update
    void PlayFootstepSFX()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = Random.Range(0.9f, 1.0f);
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);

        AudioClip myClip;
        

        switch (material) 
        {
            case "grass":
                myClip = footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)];
                break;
            case "wood":
                myClip = footstepsOnWood[Random.Range(0, footstepsOnGrass.Length)];
                break;
            default:
                myClip = footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)];
                break;
        }
        myAudioSource.PlayOneShot(myClip);
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag) 
        {
            case "grass":
                material = collision.gameObject.tag;
                break;
            case "wood":
                 material = collision.gameObject.tag;
                break;
        }
    }

}
