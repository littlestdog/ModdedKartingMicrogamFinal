using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_burst : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public bool once = true;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player") && once){
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

            once = false;
        }
    }
}
