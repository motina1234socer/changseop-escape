using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour
{
    public GameObject player;
    public GameObject snd_obj;
    public AudioSource src;
    public AudioClip cncrt;
    public AudioClip gravl;
    public AudioClip metal;
    public AudioClip slosh;
    private bool on_air = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void footfoot(int what_flr)
    {
        if (what_flr == 1)
        {
            src.clip = cncrt;
        }
        if (what_flr == 2)
        {
            src.clip = gravl;
        }
        if (what_flr == 3)
        {
            src.clip = metal;
        }
        if (what_flr == 4)
        {
            src.clip = slosh;
        }
    }
    void OnCollisionStay(Collision collision)
    {
        on_air = false;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            src.pitch = 1.5f;
        }
        else
        {
            src.pitch = 1.2f;
        }
        if (!on_air && gichan1())
        {
            snd_obj.SetActive(true);
        }
        else
        {
            snd_obj.SetActive(false);
        }
        if (collision.collider.gameObject.tag == "Concrete")
        {
            footfoot(1);
        }
        else if (collision.collider.gameObject.tag == "Gravel")
        {
            footfoot(2);
        }
        else if (collision.collider.gameObject.tag == "Metal")
        {
            footfoot(3);
        }
        else if (collision.collider.gameObject.tag == "Slosh")
        {
            footfoot(4);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Concrete" || collision.collider.gameObject.tag == "Gravel" || collision.collider.gameObject.tag == "Metal" || collision.collider.gameObject.tag == "Slosh")
        {
            on_air = true;
            snd_obj.SetActive(false);
        }
    }
    
    private bool gichan1() {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
    }
}
