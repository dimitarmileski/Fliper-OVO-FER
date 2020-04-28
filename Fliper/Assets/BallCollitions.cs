
using UnityEngine;

public class BallCollitions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit with something!");
    }
}
