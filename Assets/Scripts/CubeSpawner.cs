using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _cubePrefab;
    [SerializeField]
    private int _count;
    [SerializeField]
    private float _maxX, _minX, _maxZ, _minZ;
    [SerializeField]
    private float _maxSize, _minSize;

    private void Start() 
    {
        for(int i = 0; i < _count; i++)
        {
            float size = Random.Range(_minSize, _maxSize);
            GameObject obj = Instantiate(_cubePrefab, new Vector3(Random.Range(_minX, _maxX), size / 2, Random.Range(_minZ, _maxZ)), Quaternion.identity, this.transform);
            obj.transform.localScale = new Vector3(size, size, size);
        }   
    }
}
