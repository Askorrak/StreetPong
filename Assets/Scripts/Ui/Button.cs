using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public AudioSource SoundSource1;
    public AudioSource SoundSource2;
    public AudioSource SoundSource3;
    public AudioSource SoundSource4;
    public AudioSource SoundSource5;
    public int r;

    public void sound()
    {
        r=Random.Range(1, 4);
        if (r==1)
        {
            SoundSource1.Play();
        }
        if (r==2)
        {
            SoundSource2.Play();
        }
        if (r==3)
        {
            SoundSource3.Play();
        }
        if (r==4)
        {
            SoundSource4.Play();
        }
    }

    public void transition()
    {
        SoundSource5.Play();
        StartCoroutine(Wait());        
    }

        IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.55f);
        r=Random.Range(1, 4);
        if (r==1)
        {
            SoundSource1.Play();
        }
        if (r==2)
        {
            SoundSource2.Play();
        }
        if (r==3)
        {
            SoundSource3.Play();
        }
        if (r==4)
        {
            SoundSource4.Play();
        }
    }


}