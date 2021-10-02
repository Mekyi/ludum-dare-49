using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New File Object", menuName = "File System/File")]
public class FileObject : FileSystemObject
{
    public void Awake()
    {
        type = FileSystemType.File;
    }
}
