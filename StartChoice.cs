using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartChoice : MonoBehaviour
{
    [SerializeField] private Image[] choiceImages;

    public void OnPointerEnter(int choice) => choiceImages[choice].gameObject.SetActive(true);
    public void OnPointerExit(int choice) => choiceImages[choice].gameObject.SetActive(false);
    public void OnPoiterClick(int choice)
    {
        BikeSelect.choiceMade = choice;
        SceneManager.LoadScene(1);
    }
}
