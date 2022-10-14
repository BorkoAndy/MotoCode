using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject winImage;
    private void OnTriggerEnter2D(Collider2D collision) => winImage.SetActive(true);
}
