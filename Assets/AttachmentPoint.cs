using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentPoint : MonoBehaviour
{
    [SerializeField] private AttachmentManager attachmentManager;
    [SerializeField] private Collider attachCollider;
    public Collider AttachCollider { get { return attachCollider; } set { attachCollider = value; } }
    private void OnTriggerEnter(Collider other)
    {
        Attachments attachment = other.GetComponent<Attachments>();
        if (attachment == null)
            return;
        if (attachment.isAttachable)
        {
            attachment.Attach(this);
            attachmentManager.Attachments.Add(attachment);
        }

    }
}
