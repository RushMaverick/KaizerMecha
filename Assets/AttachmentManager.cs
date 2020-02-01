using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentManager : MonoBehaviour
{
    private List<Attachments> attachments = new List<Attachments>();
    public List<Attachments> Attachments { get { return attachments; } set { attachments = value; } }
}
