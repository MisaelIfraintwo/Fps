using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;


            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }

    }
    public void SceneChange(int Indexscene) 
    {
        SceneManager.LoadScene(Indexscene);
    }
}
