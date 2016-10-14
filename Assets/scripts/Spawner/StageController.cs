using UnityEngine;
using System.Collections;

public class StageController : MonoBehaviour {

    public ObstacleSpawner obstacleSpawner;
    public SpawnData spawnData;
    [SerializeField]private int currentStage;
    [SerializeField]private int nextStage;
    [SerializeField]private GameObject player;

    private int nextStageHeight;

    void Start()
    {
        obstacleSpawner = GetComponent<ObstacleSpawner>();
        spawnData = GetComponent<SpawnData>();
       // player = GetComponent<GameObject>();
        SetupNextStage();
    }

    void Update()
    {
        nextStage = currentStage + 1;
        CheckStage();
    }

    void CheckStage()
    {
        if(player.transform.position.y >= nextStageHeight){ ChangeStage(); SetupNextStage(); }
    }

    void ChangeStage()
    {
        currentStage++;
    }

    void SetupNextStage()
    {
        
    }
}
