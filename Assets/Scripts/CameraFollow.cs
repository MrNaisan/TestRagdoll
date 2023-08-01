using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _human;
    [SerializeField]
    private Vector3 _offset;
    [SerializeField]
    private LayerMask _hideLayerMask;

    private void Update()
    {
        transform.position = _offset + _human.transform.position;

        CheckIntersection();
    }

    private void CheckIntersection()
    {
        Vector3 cameraToPlayerDirection = (_human.position - this.transform.position).normalized;
        float distanse = Vector3.Distance(_human.position, this.transform.position);

        Ray ray = new Ray(this.transform.position, cameraToPlayerDirection);
        RaycastHit[] hits = Physics.RaycastAll(ray, distanse, _hideLayerMask);

        foreach (RaycastHit hit in hits)
        {
            MaskableObjects hitObject = hit.collider.gameObject.GetComponent<MaskableObjects>();

            hitObject.isHide = true;
        }
    }
}
