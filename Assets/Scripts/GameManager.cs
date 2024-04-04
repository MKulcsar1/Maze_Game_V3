using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public void EndGame()
    {
        if(gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
        }
        
    }
}
