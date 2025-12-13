using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocità del player (privata ma visibile nell’Inspector)
    [SerializeField]
    private float speed = 5f;

    // Direzione di movimento (leggibile, non scrivibile)
    public Vector2 Direction { get; private set; }

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Input fluido (non Raw)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 input = new Vector2(horizontal, vertical);

        // Evita che la diagonale sia più veloce
        if (input.sqrMagnitude > 1f)
        {
            input.Normalize();
        }

        Direction = input;
    }

    private void FixedUpdate()
    {
        // Movimento fisico corretto e fluido
        Vector2 newPosition = rb.position + Direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
