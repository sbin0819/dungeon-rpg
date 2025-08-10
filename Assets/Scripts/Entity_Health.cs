using UnityEngine;

public class Entity_Health : MonoBehaviour
{
    [SerializeField] protected float maxHealth = 100f;
    [SerializeField] protected bool isDead = false;

    public virtual void TakeDamage(float damage)
    {
        if (isDead) return;

        ReduceHp(damage);
    }

    protected void ReduceHp(float damage)
    {
        maxHealth -= damage;

        if (maxHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        Debug.Log(gameObject.name + " is dead");
    }
}
