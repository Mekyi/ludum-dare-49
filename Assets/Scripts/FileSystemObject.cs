using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FileSystemType
{
    File,
    Folder,
    Empty
}

public abstract class FileSystemObject : MonoBehaviour
{
    protected FileSystemType type;

    [SerializeField]
    public string objectName = "";
}
