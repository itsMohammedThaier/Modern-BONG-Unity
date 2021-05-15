using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    public GameManager gameManager;
    public GameObject GoalEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.tag);
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(Instantiate(GoalEffect, collision.transform.position, Quaternion.Euler(Vector2.zero)), 1f);
            Destroy(collision.transform.parent.gameObject);

            gameManager.StartNewRound(!isPlayer1Goal);

            Camera.main.GetComponent<CameraManager>().ShakeTheCamera();
        }
    }
}
