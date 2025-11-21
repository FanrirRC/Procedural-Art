using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateAssetMenu (menuName = "Buildings/Building")]
public class Building : ScriptableObject
{

    public List<GameObject> buildingBase = new List<GameObject>();
    public List<GameObject> buildingMiddle = new List<GameObject>();
    public List<GameObject> buildingRoof = new List<GameObject>();


    public void Spawner(Vector3 buildingPosition, Quaternion buildingRotation, int buildingHeight, GameObject buildingParent, LayerMask m_LayerMask, BuildingGenerator buildGenerator)
    {
        GameObject baseBuilding = buildingBase[Random.Range(0, buildingBase.Count)];
        int tempHeight = buildingHeight + 1;
        if (buildingRoof.Count != 0)
        {
            tempHeight ++;
        }
        buildGenerator.Segments.Add(new TempBuilding(baseBuilding, buildingPosition, buildingRotation, tempHeight));
        buildingPosition.y += baseBuilding.GetComponent<BuildingSegment>().segmentHeight;


        for (int i = 0; i <= buildingHeight; i++)
        {
          
            GameObject middleBuilding = buildingMiddle[Random.Range(0, buildingMiddle.Count)];
            buildGenerator.Segments.Add(new TempBuilding(middleBuilding, buildingPosition, buildingRotation));
            buildingPosition.y += middleBuilding.GetComponent<BuildingSegment>().segmentHeight;



        }
        if (buildingRoof.Count != 0)
        {
            GameObject roofBuilding = buildingRoof[Random.Range(0, buildingRoof.Count)];
            buildGenerator.Segments.Add(new TempBuilding(roofBuilding, buildingPosition, buildingRotation));
        }

    }


}



