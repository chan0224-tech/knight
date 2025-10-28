using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    public KeyCode attackKey = KeyCode.Space;
    public GameObject hitbox;
    public float attackDuration = 0.1f;
    bool attacking = false;

    void Start()
    {
        hitbox.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(attackKey) && attacking == false)
        {
            StartCoroutine(DoAttack());
        }
    }

    IEnumerator DoAttack()
    {
        attacking = true;
        hitbox.SetActive(true);
        yield return new WaitForSeconds(attackDuration);
        hitbox.SetActive(false);
        attacking = false;
    }
}
