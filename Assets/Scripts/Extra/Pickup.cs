using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject weaponPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        Transform player = other.transform;

        Instantiate(
            weaponPrefab,
            player.position,
            Quaternion.identity,
            player
        );

        Destroy(gameObject);
    }
}
