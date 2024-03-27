using UnityEngine;

namespace Phyw.Car
{

  public class TriggerDetection : MonoBehaviour
  {
    #region Variables

    #endregion

    #region UnityMethods

    private void OnTriggerEnter(Collider other)
    {
      if (other.tag == "Waypoint")
      {
        print("A waypoint is reached");
        Destroy(other.gameObject);
        //other.GetComponent<Waypoint>().RemoveRef();
      }
    }



    #endregion

    #region CustomMethods

    #endregion

  }
}