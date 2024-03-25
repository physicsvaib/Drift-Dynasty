using Phyw.Utils;
using Unity.Netcode;
using UnityEngine;

namespace Phyw.Car
{

  public class CameraOnSpawn : NetworkBehaviour
  {
    #region Variables
    [SerializeField] private Transform carMesh;
    #endregion

    #region UnityMethods

    private void Start()
    {
      if (IsOwner)
      {
        CamReference.instance.AddTransformRef(carMesh);
      }
    }


    #endregion

    #region CustomMethods

    #endregion

  }
}