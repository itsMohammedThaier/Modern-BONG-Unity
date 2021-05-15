using UnityEngine;

public class Ball : MonoBehaviour
{
    public float launchSpeed;
    public GameObject launchEffect;
    public Rigidbody2D ballRb;

    public void Launch()
    {
        Vector2 direction = new Vector2(
                                        (Random.Range(0, 2) == 0) ? -1 : 1,
                                        (Random.Range(0, 2) == 0) ? -1 : 1
                                       );
        ballRb.velocity = direction * launchSpeed;

        Destroy(Instantiate(launchEffect, transform.position, transform.rotation), 1f);

        Camera.main.GetComponent<CameraManager>().ShakeTheCamera();
    }
}
