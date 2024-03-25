using Unity.Netcode;
using UnityEngine;

namespace Phyw.Networking
{

  public class Joiner : MonoBehaviour
  {

    #region CustomMethods
    public void JoinAHost()
    {
      NetworkManager.Singleton.StartHost();
    }

    public void JoinAsClient()
    {
      NetworkManager.Singleton.StartClient();
    }
    #endregion

  }
}