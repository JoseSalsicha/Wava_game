using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] private float speed;
    [SerializeField] private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        if(Input.GetKey(KeyCode.A))
        {
            PlayerAnimated("Run");
            transform.localScale = new Vector3(-.4f, .4f, .4f);
        } else if(Input.GetKey(KeyCode.D))
        {
            PlayerAnimated("Run");
            transform.localScale = new Vector3(.4f, .4f, .4f);
        } else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            PlayerAnimated("Run");
        } else
        {
            PlayerAnimated("Idle");
        }

        transform.position = transform.position + movement * speed * Time.deltaTime ;
    }

    public void PlayerAnimated(string animationName)
    {
        anim.Play(animationName);
    }
}

