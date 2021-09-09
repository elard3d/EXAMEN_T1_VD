using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFemaleController : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private int piso = 0;
    private int direccion = 0;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if ( piso == 1)
        {
            if (direccion == 0)
            {
                _renderer.flipX = false;
                Debug.Log("false");
                
                _rigidbody.velocity = Vector2.up * 5f;
                _rigidbody.velocity = new Vector2(10,_rigidbody.velocity.y);
                piso = 0;
                direccion = 1;
                Debug.Log(direccion);
            }
            else
            {
                _renderer.flipX = true;
                Debug.Log("true");
                
                _rigidbody.velocity = Vector2.up * 5f;
                _rigidbody.velocity = new Vector2(-10, _rigidbody.velocity.y);
                piso = 0;
                direccion = 0;
                Debug.Log(direccion);
            }
            
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso" )
        {
            piso = 1;
        }
    }
}
