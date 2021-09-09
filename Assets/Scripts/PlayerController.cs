using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private int murio = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (murio == 0)
        {
            setRunAnimation();
            _rigidbody.velocity = new Vector2(15,_rigidbody.velocity.y);
        }
        
        
        if (Input.GetKeyDown(KeyCode.UpArrow)  || Input.GetKeyDown(KeyCode.Space) )
        {
            var upSpeed = 30f;
            _rigidbody.velocity = Vector2.up * upSpeed;

            setJumpAnimation();
            
        }

        if (murio == 1)
        {
            setDeadAnimation();
        }

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" )
        {
          //  Destroy(collision.gameObject);
            murio = 1;
        }
    }
    
    
    private void setRunAnimation(){
        _animator.SetInteger("Estado",0);
    }
    
    private void setJumpAnimation(){
        _animator.SetInteger("Estado",1);
    }
    
    private void setDeadAnimation(){
        _animator.SetInteger("Estado",2);
    }

    


}
