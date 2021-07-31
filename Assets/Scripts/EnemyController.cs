using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.0f;
    public bool vertical = true;
    public float changeTime = 3.0f;

    bool broken = true;
    float timer;
    int direction = 1;

    Animator animator;
    GameObject ruby;
    RubyController controller;
    Rigidbody2D rgdbdy2D;
    public ParticleSystem smokeEffect;
    public AudioClip iAmFixed;

    // Start is called before the first frame update
    void Start()
    {
        rgdbdy2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
        ruby = GameObject.Find("ruby");
        controller = ruby.GetComponent<RubyController>();
    }

    void Update()
    {
        if(!broken)
        {
            return;
        }
        
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;

            if (vertical == true)
            {
                vertical = false;
            }
            else if (vertical == false)
            {
                vertical = true;
            }
        }
    }
    
    void FixedUpdate()
    {
        if(!broken)
        {
            return;
        }

        Vector2 position = rgdbdy2D.position;
        
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
        }
        
        rgdbdy2D.MovePosition(position);
    }

    public void Fix()
    {
        broken = false;
        GetComponent<Rigidbody2D>().simulated = false;
        animator.SetTrigger("Fixed");
        smokeEffect.Stop();
        controller.PlaySound(iAmFixed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController >();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
}
//public class EnemyController : MonoBehaviour
//{
//    public float speed = 3.0f;
//    public bool vertical;
//    public float changeTime = 3.0f;
    
//    Rigidbody2D rgdbdy2D;

//    float timer;
//    int direction = 1;
    
//    // Start is called before the first frame update
//    void Start()
//    {
//        rgdbdy2D = GetComponent<Rigidbody2D>();
//        timer = changeTime;
//    }

//    void Update()
//    {
//        if (Input.GetAxis("Vertical") != 0)
//        {
//            vertical = true;
//        }

//        timer -= Time.deltaTime;

//        if (timer < 0)
//        {
//            direction = -direction;
//            timer = changeTime;
//        }
//    }
    
//    void FixedUpdate()
//    {
//        Vector2 position = rgdbdy2D.position;
        
//        if (vertical)
//        {
//            position.y = position.y + Time.deltaTime * speed;
//        }
//        else
//        {
//            position.x = position.x + Time.deltaTime * speed;
//        }
        
//        rgdbdy2D.MovePosition(position);
//    }
//}
