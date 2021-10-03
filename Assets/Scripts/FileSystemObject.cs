using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FileSystemType
{
    File,
    Folder,
    Empty
}

public class FileSystemObject : MonoBehaviour
{
    [SerializeField]
    public FileSystemType type;

    [SerializeField]
    public string objectName = "";

    [SerializeField]
    [Tooltip("Use only for folder types")]
    public List<GameObject> folderContent;

    [SerializeField]
    public GameObject newFileSystemObjectPrefab;

    public FileSystemType GetFileSystemType()
    {
        return type;
    }

    public void AddFileSystemObject(string name, FileSystemType newFolderContentType, int index = -1, List<GameObject> newFolderContent = null)
    {
        GameObject newFileSystemObject = GameObject.Instantiate(newFileSystemObjectPrefab);
        FileSystemObject fileSystemObject = newFileSystemObject.GetComponent<FileSystemObject>();

        fileSystemObject.objectName = name;
        fileSystemObject.name = name;
        fileSystemObject.type = newFolderContentType;
        Debug.Log(newFileSystemObject.GetComponent<FileSystemObject>().type);

        if (index >= 0)
        {
            folderContent[index] = newFileSystemObject;
        }
        else
        {
            folderContent.Add(newFileSystemObject);
        }
    }
}
