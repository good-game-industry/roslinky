using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridGenerator : MonoBehaviour
{
    public GameObject itemPrefab; // Перетягніть сюди ваш префаб об'єкта
    public Transform object1; // Перетягніть сюди перший об'єкт
    public Transform object2; // Перетягніть сюди другий об'єкт
    public int numRows = 5; // Кількість рядків в сітці
    public int numCols = 5; // Кількість стовпців в сітці
    public float spacing = 1.0f; // Відстань між об'єктами у сітці

    private List<GameObject> gridItems = new List<GameObject>();

    private void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        Vector3 startPoint = (object1.position + object2.position) / 2; // Стартова точка між об'єктами

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Vector3 offset = new Vector3(col * spacing, row * spacing, 0);
                Vector3 position = startPoint + offset;

                GameObject newItem = Instantiate(itemPrefab, position, Quaternion.identity);
                gridItems.Add(newItem);
            }
        }
    }
}