using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip CS1, CS2, CS3, CU1, CU2, CU3, SS1, SS2, SS3, ER1, ER2, ER3;

    public void cs1()
    {
        src.clip = CS1;
        src.Play();
    }

    public void cs2()
    {
        src.clip = CS2;
        src.Play();
    }

    public void cs3()
    {
        src.clip = CS3;
        src.Play();
    }

    public void cu1()
    {
        src.clip = CU1;
        src.Play();
    }

    public void cu2()
    {
        src.clip = CU2;
        src.Play();
    }

    public void cu3()
    {
        src.clip = CU3;
        src.Play();
    }

    public void ss1()
    {
        src.clip = SS1;
        src.Play();
    }

    public void ss2()
    {
        src.clip = SS2;
        src.Play();
    }

    public void ss3()
    {
        src.clip = SS3;
        src.Play();
    }

    public void er1()
    {
        src.clip = ER1;
        src.Play();
    }

    public void er2()
    {
        src.clip = ER2;
        src.Play();
    }

    public void er3()
    {
        src.clip = ER3;
        src.Play();
    }


}
