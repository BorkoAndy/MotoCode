using UnityEngine;

public class BikeSelect : MonoBehaviour
{    
    [SerializeField] private GameObject[] playerBikes;
    public static int choiceMade;   

    private void Start() => playerBikes[choiceMade].gameObject.SetActive(true);
}
