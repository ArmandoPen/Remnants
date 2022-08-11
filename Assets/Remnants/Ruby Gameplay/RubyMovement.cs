
using UnityEngine;

public class RubyMovement : MonoBehaviour
    {
        /// <summary>
        /// Max horizontal speed of the player.
        /// </summary>
        public float maxSpeed = 7;
        /// <summary>
        /// Initial jump velocity at the start of a jump.
        /// </summary>
        public float jumpTakeOffSpeed = 7;

        private Rigidbody2D ridigbody2D;

        bool jump;
        Vector2 move;
        SpriteRenderer spriteRenderer;
        internal Animator animator;
        public  LayerMask mask;
        public Transform feetCheck;


        void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
            ridigbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            jump = Physics2D.OverlapBox(feetCheck.position, new Vector2(0.8f, 0.12f), 0, mask);
            move.x = maxSpeed * Input.GetAxis("Horizontal");

        if (jump)
        {
            animator.SetBool("IsJumping", false);
        }

            if (move.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (move.x > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);

            }

            if (move.x != 0)
            {
                animator.SetBool("IsWalking", true);
            }
            else
            {
                animator.SetBool("IsWalking", false);

            }

            if (Input.GetAxis("Vertical") > 0 && jump)
            {
                move.y = jumpTakeOffSpeed;
                animator.SetBool("IsJumping", true);
            }
            else
            {
                move.y = ridigbody2D.velocity.y;
            }


            ridigbody2D.velocity = move;
        }

    }