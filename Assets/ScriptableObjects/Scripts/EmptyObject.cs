using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stupid hack for making desktop view to support empty spaces between file system items
[CreateAssetMenu(fileName = "New Empty Object", menuName = "File System/Empty")]
public class EmptyObject : FileSystemObject
{
    private void Awake()
    {
        type = FileSystemType.Empty;
    }
}
