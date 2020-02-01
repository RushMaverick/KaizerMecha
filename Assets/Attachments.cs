using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachments : MonoBehaviour
{
    public Rigidbody rigidBody;
    public bool isAttachable;
    public float attachCooldown=0.5f;
    public Vector3 localAttachRotation;
    private AttachmentPoint attachedTo;
    public Quaternion LocalAttachRotation { get { return Quaternion.Euler(localAttachRotation); } }

    public void Attach(AttachmentPoint attachmentPoint)
    {
        attachedTo = attachmentPoint;
        rigidBody.useGravity = false;
        transform.parent = transform;
        transform.localPosition = Vector3.zero;
        transform.localRotation = LocalAttachRotation;
        attachedTo.AttachCollider.enabled = false;
    }
    public void Detach()
    {
        isAttachable = false;
        transform.parent = null;
        rigidBody.useGravity = true;
        attachedTo.AttachCollider.enabled = true;
        attachedTo = null;
    }

    private IEnumerable EnableAttaching()
    {
        yield return new WaitForSeconds(attachCooldown);
        isAttachable = true;
        yield return null;
    }
}
