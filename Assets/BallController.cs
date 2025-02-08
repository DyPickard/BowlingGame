using UnityEngine;
using UnityEngine.Events;

public class BallManager : MonoBehaviour
{
    private bool isBallLaunched;
    [SerializeField] private float force = 1f;
    private InputManager inputManager;
    private Rigidbody ballRB;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
