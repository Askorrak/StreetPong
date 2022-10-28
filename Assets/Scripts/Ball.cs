using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    public AudioSource tickSource1;
    public AudioSource tickSource2;
    public AudioSource tickSource3;
    public float Speed;
    public Rigidbody Rigidbody;
    public Vector3 startPosition;
    public float x;
    public int r;
    public Image img;
    public TextMeshProUGUI GO;
    
    [Header("Score UI")]
    public GameObject temps;
    
    private int decompte;

    void Start()
    {
        StartCoroutine(Cooldown());
        startPosition = transform.position;
    }

    IEnumerator Cooldown()
    {
        decompte=3;
        yield return new WaitForSeconds(1);
        decompte--;
        temps.GetComponent<TextMeshProUGUI>().text=decompte.ToString();
        yield return new WaitForSeconds(1);
        decompte--;
        temps.GetComponent<TextMeshProUGUI>().text=decompte.ToString();
        yield return new WaitForSeconds(1);
        decompte--;
        temps.GetComponent<TextMeshProUGUI>().text=decompte.ToString();
        yield return new WaitForSeconds(1);
        img.gameObject.SetActive(false);
        GO.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        GO.gameObject.SetActive(false);
        launch();
    }

    void OnCollisionEnter(Collision collision)
    {
        r=Random.Range(1, 3);
        if (r==1)
        {
            tickSource1.Play();
        }
        if (r==2)
        {
            tickSource2.Play();
        }
        if (r==3)
        {
            tickSource3.Play();
        }
    }

    public void Reset()
    {
        Rigidbody.velocity = Vector2.zero;
        transform.position = startPosition;
        launch();
    }

    private void launch()
    {
        float x=Random.Range(0, 2)==0 ? -1 : 1;
        float y=Random.Range(0, 2)==0 ? -1 : 1;
        Rigidbody.velocity= new Vector2(Speed*x, Speed*y);
    }
}
