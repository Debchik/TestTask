using UnityEngine;


public class Mediator : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private CubeColors _cubesLogic;
    [SerializeField] private Spawner _spawner;

    private ColorsData _colorsData;


    private void Awake()
    {
        _colorsData = new ColorsData();
    }

    private void Start()
    {
        _gameData.Init();
        _spawner.SpawnCubes(_gameData.GridSize);
        _colorsData.InitData();
        _colorsData.ReadColorsData();
        UpdateCubes(_gameData.IndX, _gameData.IndY, _gameData.GridSize);
    }


    public void AddCubeRenderer(MeshRenderer meshRenderer)
    {
        _cubesLogic.AddCube(meshRenderer);
    }


    public void MoveUpDown(int y)
    {
        _gameData.MoveY(y);
        UpdateCubes(_gameData.IndX, _gameData.IndY, _gameData.GridSize);
    }

    public void MoveLeftRight(int x)
    {
        _gameData.MoveX(x);
        UpdateCubes(_gameData.IndX, _gameData.IndY, _gameData.GridSize);
    }


    private void UpdateCubes(int indX, int indY, int gridSize)
    {
        int[] colors = _colorsData.GetColorsData(indX, indY, gridSize);
        _cubesLogic.UpdateColors(colors, gridSize);
    }
}
