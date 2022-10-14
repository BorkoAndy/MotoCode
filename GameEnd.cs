using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{   
    public void OnRestartClick() => SceneManager.LoadScene(0);
}
