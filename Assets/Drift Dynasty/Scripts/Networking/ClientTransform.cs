using Unity.Netcode.Components;

namespace Phyw.Networking
{

  public class ClientTransform : NetworkTransform
  {
    #region Variables

    #endregion

    #region UnityMethods

    protected override bool OnIsServerAuthoritative()
    {
      return false;
    }

    #endregion

    #region CustomMethods

    #endregion

  }
}