using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GodTouches;

public class PlayerController : MonoBehaviour {

    public PlayerController Instance;
    private float maxSpeed = 15f;
    private Animator animator;
    private Rigidbody2D body2D;
    private float speed = 4f;
    private bool grounded;
    public LayerMask groundLayer;
    public LayerMask blockerLayer;
    bool jump;
    bool nowJumping;
    bool fly;

	// Use this for initialization
	void Start () {
        Instance = this;
        animator = GetComponent<Animator>();
        body2D = GetComponent<Rigidbody2D>();
        jump = false;
        nowJumping = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!(GameManger.Instance.startCount >= 0))
        {
            var phase = GodTouch.GetPhase();
            animator.SetFloat("speed", speed);
            grounded = Physics2D.Linecast(transform.position, transform.position - transform.up * 2f, groundLayer);
            speed += 0.01f;
            fly = GameManger.Instance.playerFly;
            GameManger.Instance.playernowJumping = nowJumping;

            if (( Input.GetKey(KeyCode.Space) || GameManger.Instance.playerTouch) && grounded) {
                jump = true;
            }
            if(grounded && nowJumping)
            {
                nowJumping = false;
                GameManger.Instance.playerFly = false;
                fly = false;
            }
            if (!(grounded))
            {
                nowJumping = true;
            }
        }
    }

    void FixedUpdate()
    {   if (!(GameManger.Instance.startCount >= 0))
        {
            body2D.velocity = new Vector2(speed, body2D.velocity.y);
            if (jump)
            {
                body2D.AddForce(Vector2.up * 1500);
                jump = false;
                nowJumping = true;
            }
        }
        if (fly)
        {
            Debug.Log(fly);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            GameManger.Instance.gameClear = true;
        }
    }
}
