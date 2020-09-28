using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFX : MonoBehaviour
{
    public ParticleSystem shootParticle;
    public GameObject playerGun;

    public void ShotsFired()
    {
        Instantiate(shootParticle, playerGun.transform.position, Quaternion.identity);
    }
}
