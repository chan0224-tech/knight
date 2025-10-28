using UnityEngine;

public class HitboxDamage : MonoBehaviour
{
    public int damage = 5;

    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyAI enemy = other.GetComponent<EnemyAI>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}
