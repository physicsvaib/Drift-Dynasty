using System.Collections.Generic;
using UnityEngine;

namespace Phyw.GameModes
{

  public class WayPointManager : MonoBehaviour
  {
    #region Variables

    [SerializeField] private List<Waypoint> waypoints;

    #endregion

    #region UnityMethods
    private void Start()
    {
      foreach (Waypoint waypoint in waypoints)
      {
        waypoint.SetManager(this);
        //waypoints.Add(waypoint);
      }
    }
    #endregion

    #region CustomMethods
    public void RemoveReference(Waypoint waypoint)
    {
      waypoints.Remove(waypoint);
    }
    #endregion

  }
}