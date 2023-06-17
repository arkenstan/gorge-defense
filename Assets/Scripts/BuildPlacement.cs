using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlacement : MonoBehaviour
{

  Transform currentBuilding;
  Camera cam;

  bool hasPlaced;

  public LayerMask mouseColliderLayerMask;

  // Start is called before the first frame update
  void Start()
  {
    cam = GetComponent<Camera>();
  }

  // Update is called once per frame
  void Update()
  {

    if (currentBuilding != null && !hasPlaced)
    {
      Vector3 mousePosition = GetMouseWorldPosition();
      currentBuilding.position = mousePosition;
      if (Input.GetMouseButtonDown(0))
      {
        hasPlaced = true;
      }

    }
  }

  public Vector3 GetMouseWorldPosition()
  {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    if (Physics.Raycast(ray, out RaycastHit raycastHit, Mathf.Infinity, mouseColliderLayerMask))
    {
      return raycastHit.point;
    }
    else
    {
      return Vector3.zero;
    }
  }

  public void SetItem(GameObject b)
  {
    hasPlaced = false;
    currentBuilding = ((GameObject)Instantiate(b)).transform;
  }


}
