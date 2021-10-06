using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePour : MonoBehaviour {
    private ParticleSystem particle;

    void Awake() {
        particle = GetComponent<ParticleSystem>();
    }

    private void Update() {
        var emission = particle.emission;
        if(transform.parent.up.y < 0.0f){
            emission.enabled = true;
        } else {
            emission.enabled = false;
        }
    }
}
