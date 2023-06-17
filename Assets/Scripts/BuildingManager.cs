using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

  public GameObject[] buildings;
  private BuildPlacement buildPlacement;

  // Start is called before the first frame update
  void Start()
  {

    buildPlacement = GetComponent<BuildPlacement>();

  }

  // Update is called once per frame
  void Update()
  {

  }

  /// <summary>
  /// OnGUI is called for rendering and handling GUI events.
  /// This function can be called multiple times per frame (one call per event).
  /// </summary>
  void OnGUI()
  {

    for (int i = 0; i < buildings.Length; ++i)
    {
      if (GUI.Button(new Rect(Screen.width / 20, Screen.height / 15 + Screen.height / 12 * i, 100, 30), buildings[i].name))
      {
        buildPlacement.SetItem(buildings[i]);
      }
    }

  }

}
