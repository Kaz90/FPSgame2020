using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
    public float damage = 10f;
    private void OnTriggerEnter(Collider other)
    
    {
        print("hit " + other.name + '!');
        Destroy(gameObject);
        Target target = other.transform.GetComponent<Target>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }
    }
}
