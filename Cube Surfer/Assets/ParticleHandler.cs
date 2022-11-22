using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHandler : MonoBehaviour
{
    [SerializeField] private GameObject childParticle;

    public void Hit()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
        childParticle.SetActive(true);
    }

    private IEnumerator DestroyAfterParticles()
    {
        yield return new WaitForSecondsRealtime(childParticle.GetComponent<ParticleSystem>().main.duration);
        Destroy(this.gameObject);
    }
}
