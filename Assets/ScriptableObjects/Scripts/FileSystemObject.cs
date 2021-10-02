using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FileSystemType
{
    File,
    Folder,
    Empty
}

public abstract class FileSystemObject : ScriptableObject
{
    public GameObject prefab;
    public string objectName;

    protected FileSystemType type;

    public FileSystemType GetFileSystemType()
    {
        return type;
    }
}
