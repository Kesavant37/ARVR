using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(AudioSource))]
public class ParticleSound : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private AudioSource audioSource;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();

        audioSource.playOnAwake = false;
    }

    void Update()
    {
        
        if (particleSystem.isPlaying && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        
        else if (!particleSystem.isPlaying && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
