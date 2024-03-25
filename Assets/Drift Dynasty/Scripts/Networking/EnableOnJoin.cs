using Unity.Netcode;
using UnityEngine;

namespace Phyw.Networking
{

  public class EnableOnJoin : NetworkBehaviour
  {
    #region Variables
    [SerializeField] private GameObject[] objs;
    [SerializeField] private MonoBehaviour[] behaviors;
    #endregion

    #region UnityMethods
    private void Start()
    {
      if (!IsOwner) return;
      foreach (GameObject obj in objs)
      {
        obj.SetActive(true);
      }

      foreach (MonoBehaviour item in behaviors)
      {
        item.enabled = true;
      }
    }
    #endregion

    #region CustomMethods

    #endregion

  }
}