using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{

    protected Rigidbody2D _rigidbody;
    [SerializeField] private SpriteRenderer PlayerRenderer;
    [SerializeField] private Transform PokePivot;
    [Range(1f, 20f)][SerializeField] private float speed = 3;
    public float Speed
    {
        get => speed;
        set => speed = Mathf.Clamp(value, 0, 20);
    }
    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection { get { return movementDirection; } }
    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }


    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }



    private void Movement(Vector2 direction)
    {
        direction = direction * Speed;
        _rigidbody.velocity = direction;
            
    }
    protected virtual void FixedUpdate()
    {
        Movement(movementDirection);
        
    }

}
