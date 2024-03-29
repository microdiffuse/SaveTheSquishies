﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldParticles : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.transform.Find("MiddleParticles-Burst").GetComponent<ParticleSystem>().Play();
        /*gameObject.GetComponent<ParticleSystem>().Play();*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "BluePlat")
        {
            gameObject.transform.Find("MiddleParticles-Burst").GetComponent<ParticleSystem>().Play();
        }
    }
}
