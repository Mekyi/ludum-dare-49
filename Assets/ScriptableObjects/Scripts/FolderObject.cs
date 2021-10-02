using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Folder Object", menuName = "File System/Folder")]
public class FolderObject : FileSystemObject
{
    [SerializeField]
    public List<FileSystemObject> folderContent;

    private void Awake()
    {
        type = FileSystemType.Folder;
    }
}
