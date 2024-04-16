using System.Collections.Generic;
using UnityEngine.Pool;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] PooledObject [] prefabs;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float delay;
    private float delayTime;
    public float PlayTime { get; private set; }

    [SerializeField] Transform [] point;

    private List<Dictionary<string, object>> csv;

    private void Awake()
    {
        for ( int i = 0; i < prefabs.Length; i++ )
        {
            Manager.Pool.CreatePool(prefabs [i], 5, 5);
        }

        // CSV������ �о�ü� �ְ� ���ϰ�θ� �˷���
        csv = CSVReader.Read("Data/CSV/MapCSV");
    }
    private void Start()
    {
        delayTime = 0f;      
    }
    private void Update()
    {
        delayTime += Time.deltaTime;
        PlayTime += Time.deltaTime;
        if ( delayTime > delay )
        {
            delayTime = 0f;
            Generate();
        }
    }
    void Generate()
    {
        if ( csv.Count <= ( int )PlayTime )
            return;


        csv [( int )PlayTime].TryGetValue("MapType", out object obj);
        // obj �� ������ 
        if ( obj == "" )
            return;

        // CSV���� �����͸� �ҷ��ͼ� ������ �� ���
        // PlayTime�� �̿��ؼ� ���ӽð� üũ
        PooledObject mapObj = Manager.Pool.GetPool(
        prefabs [( int )csv [( int )PlayTime] ["MapType"]].GetComponent<PooledObject>(),
        point [( int )csv [( int )PlayTime] ["MapPos"]].position,
        point [( int )csv [( int )PlayTime] ["MapPos"]].rotation);
        mapObj.transform.SetParent(gameObject.transform);
    }

}

