using UnityEngine;


public class GameData : MonoBehaviour
{
    public int GridSize { get; private set; }
    public int IndX { get; private set; }
    public int IndY { get; private set; }

    [SerializeField] private int _gridSize;

    private int _minInd = 0, _maxInd = 100;


    private void OnValidate()
    {
        GridSize = _gridSize;
    }


    public void MoveX(int delta) => IndX += delta;

    public void MoveY(int delta) => IndY += delta;

    public void Init()
    {
        IndX = UnityEngine.Random.Range(_minInd, _maxInd);
        IndY = UnityEngine.Random.Range(_minInd, _maxInd);
    }
}
