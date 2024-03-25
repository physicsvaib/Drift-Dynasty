using Cinemachine;
using UnityEngine;

namespace Phyw.Utils
{

  public class CamReference : MonoBehaviour
  {
    #region Variables
    public static CamReference instance;
    [SerializeField] private CinemachineVirtualCamera cam;
    #endregion

    #region UnityMethods
    private void Awake()
    {
      if (instance != null)
        Destroy(instance.gameObject);
      instance = this;
    }
    #endregion

    #region CustomMethods
    public void AddTransformRef(Transform follow)
    {
      cam.Follow = follow;
      cam.LookAt = follow;
    }
    #endregion

  }
}