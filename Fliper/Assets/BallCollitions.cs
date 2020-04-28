
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollitions : MonoBehaviour
{
    public int score = 0;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "CylinderPoint")
        {
            score += 10;
            Debug.Log("Score: " + score);
        }

        else if (collision.collider.tag == "CapsulePoint")
        {
            score += 20;
            Debug.Log("Score: " + score);
        }

        else if (collision.collider.tag == "CubePoint")
        {
            score += 50;
            Debug.Log("Score: " + score);
        }
        else if (collision.collider.tag == "GameOverPlate")
        {
            score = 0;
            Debug.Log("Score: " + score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
        }

    }
}
