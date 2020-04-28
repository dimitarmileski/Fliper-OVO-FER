
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BallCollitions : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public Rigidbody ball;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "CylinderPoint")
        {
            score += 10;
            ball.velocity *=1;
        }

        else if (collision.collider.tag == "CapsulePoint")
        {
            score += 20;
            ball.velocity *= 3;
        }

        else if (collision.collider.tag == "CubePoint")
        {
            score += 50;
            ball.velocity *= 3;
        }
        else if (collision.collider.tag == "GameOverPlate")
        {
            score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        scoreText.text = score.ToString();
        
    }
}
