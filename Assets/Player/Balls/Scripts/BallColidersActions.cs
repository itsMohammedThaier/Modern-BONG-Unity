using UnityEngine;

public class BallColidersActions : MonoBehaviour
{
    public GameObject collisionEffect;
    void OnCollisionEnter2D(Collision2D coll)
    {
        ContactPoint2D contact = coll.GetContact(0);
        Destroy(Instantiate(collisionEffect, contact.point, Quaternion.Euler(Vector2.zero)), 2f);
    }
}
