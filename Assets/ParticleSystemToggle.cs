using UnityEngine;

public class ParticleSystemToggle : MonoBehaviour
{
    public GameObject rainParticleSystem;
    public GameObject fogParticleSystem;

    private int toggleState = 0; // 0 = rain, 1 = fog, 2 = none

    void Start()
    {
        UpdateParticleSystems();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleParticleSystems();
        }
    }

    private void ToggleParticleSystems()
    {
        // Cycle through the three states: 0 (rain), 1 (fog), 2 (none)
        toggleState = (toggleState + 1) % 3;
        UpdateParticleSystems();
    }

    private void UpdateParticleSystems()
    {
        if (rainParticleSystem != null) rainParticleSystem.SetActive(toggleState == 0);
        if (fogParticleSystem != null) fogParticleSystem.SetActive(toggleState == 1);

        // When toggleState is 2, both systems will be inactive
        if (toggleState == 2)
        {
            if (rainParticleSystem != null) rainParticleSystem.SetActive(false);
            if (fogParticleSystem != null) fogParticleSystem.SetActive(false);
        }
    }
}
