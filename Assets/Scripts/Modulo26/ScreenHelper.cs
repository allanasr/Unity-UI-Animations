using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenHelper : MonoBehaviour
{
    public ScreenType screenType;

    public ParticleSystem particleSystem;

    public List<ParticleSystem> particleSystems;

    public void OnClick()
    {
        //ScreenManager.Instance.ShowByType(screenType);
        var newParticleSystem = Instantiate(particleSystem);
        newParticleSystem.transform.position = new Vector3(transform.position.x, transform.position.y, newParticleSystem.transform.position.z);
        particleSystems.Add(newParticleSystem);
        newParticleSystem.Play();
        Destroy(newParticleSystem.gameObject, 3f);
    }

}
