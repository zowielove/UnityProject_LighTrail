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

        // CSV파일을 읽어올수 있게 파일경로를 알려줌
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
        // obj 가 없을때 
        if ( obj == "" )
            return;

        // CSV에서 데이터를 불러와서 생성할 때 사용
        // PlayTime을 이용해서 게임시간 체크
        PooledObject mapObj = Manager.Pool.GetPool(
        prefabs [( int )csv [( int )PlayTime] ["MapType"]].GetComponent<PooledObject>(),
        point [( int )csv [( int )PlayTime] ["MapPos"]].position,
        point [( int )csv [( int )PlayTime] ["MapPos"]].rotation);
        mapObj.transform.SetParent(gameObject.transform);
    }

}

