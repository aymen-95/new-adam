using UnityEngine;

public class BasicTouchSensor : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("HotWall"))
        {
            Debug.Log("🔥 NewAdam touched a hot wall! Pain perceived.");
            // مستقبلاً يمكننا ربط هذا بإحساس الألم أو العاطفة
        }
        else
        {
            Debug.Log("🟢 Touched: " + hit.gameObject.name);
        }
    }
}
