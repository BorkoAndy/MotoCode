using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject[] bikes;    
    [SerializeField] private Vector3 offset = new Vector3(10, 4.5f, -20);

    public Transform targetObject;
    private void Start() => targetObject = bikes[BikeSelect.choiceMade].transform;

    private void LateUpdate() => transform.position = targetObject.position + offset;   
}
