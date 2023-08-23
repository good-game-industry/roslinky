using UnityEngine;

public class PlantClass : MonoBehaviour
{
    public int Level = 1;
    public enum Group
    {
        A,
        B,
        C
    }

    public Transform UpPosition;
    public Transform DownPosition;
    public Transform LeftPosition;
    public Transform RightPosition;
}
