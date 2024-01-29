using System.Collections.Generic;
using UnityEngine;


public class CubeColors : MonoBehaviour
{
    [SerializeField] private Colors _colors;
    private List<MeshRenderer> _cubes = new List<MeshRenderer>();

    public void AddCube(MeshRenderer cubeMesh) => _cubes.Add(cubeMesh);

    public void UpdateColors(int[] colorsData, int gridSize)
    {
        for (int i = 0; i < gridSize * gridSize; ++i)
        {
            Color color = _colors.GetColor(colorsData[i]);
            _cubes[i].material.color = color;
        }
    }
}
