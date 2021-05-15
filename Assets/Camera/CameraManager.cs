using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private Animator CameraAnimator;

    void Start()
    {
        CameraAnimator = GetComponent<Animator>();
    }

    public void ShakeTheCamera()
    {
        int randomShake = Random.Range(1, 5);
        CameraAnimator.SetTrigger("Shake"+randomShake);
    }
}
