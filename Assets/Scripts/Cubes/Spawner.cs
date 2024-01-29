using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _startSpawnPoint;
    [SerializeField] private Mediator _mediator;
    [SerializeField, Range(0.1f, 10f)] private float _spawnShift;

    public void SpawnCubes(int gridSize)
    {
        for (int i = 0; i < gridSize; ++i)
        {
            for (int j = 0; j < gridSize; ++j)
            {
                Vector3 position = _startSpawnPoint.position;
                position.x += _spawnShift * j;
                position.z -= _spawnShift * i;

                MeshRenderer cubeRenderer = Instantiate(_cubePrefab, position, Quaternion.identity)
                    .GetComponent<MeshRenderer>();
                _mediator.AddCubeRenderer(cubeRenderer);
            }
        }
    }
}
