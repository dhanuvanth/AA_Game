
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
