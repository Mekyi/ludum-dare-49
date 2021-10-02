using System.Collections.Generic;
using UnityEngine;

public class FolderObject : FileSystemObject
{
    [SerializeField]
    public List<GameObject> folderContent;

    private void Awake()
    {
        objectName = "New Folder";
        type = FileSystemType.Folder;
    }
}
