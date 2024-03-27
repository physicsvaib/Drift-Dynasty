using UnityEngine;

namespace Phyw.GameModes
{

  public class Waypoint : MonoBehaviour
  {
    #region Variables
    private WayPointManager manager;
    #endregion

    #region UnityMethods

    private void OnDestroy()
    {
      RemoveRef();
    }

    #endregion

    #region CustomMethods
    public void RemoveRef()
    {
      manager.RemoveReference(this);
    }

    public void SetManager(WayPointManager manager)
    {
      this.manager = manager;
    }
    #endregion

  }
}