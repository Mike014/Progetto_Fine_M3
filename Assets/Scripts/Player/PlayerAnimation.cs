using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerController playerController;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        // Vector2 direction = playerController.Direction;

        // bool isMoving = direction.sqrMagnitude > 0.01f;

        // animator.SetBool("isMoving", isMoving);

        // if (isMoving)
        // {
        //     animator.SetFloat("moveX", direction.x);
        //     animator.SetFloat("moveY", direction.y);
        // }
    }
}
