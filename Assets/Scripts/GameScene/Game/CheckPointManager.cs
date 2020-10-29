using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{

    [SerializeField] private List<CheckPointData> checkPoints = new List<CheckPointData>();

    private void Start()
    {
        for(int i = 0; i < checkPoints.Count; i++)
        {
            checkPoints[i].checkPointController.checkPointManager = this;

            if (i == 0) checkPoints[i].checkPointController.isMyTurn = true;
        }
    }
}

[System.Serializable]
public class CheckPointData
{
    public int checkPointID;
    public bool isChecked;
    public CheckPointController checkPointController;
}

