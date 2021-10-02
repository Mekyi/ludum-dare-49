using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderContent : MonoBehaviour
{
    public string Name { get; set; }
    public FileSystemType Type { get; set; }
    public bool IsMovable { get; set; }

    [SerializeField]
    public GameObject prefab;

    public FolderContent(string name)
    {
        this.Name = name;
    }

    public FileSystemType GetFileSystemType()
    {
        return Type;
    }
}

public class File : FolderContent
{
    public File(string name) : base (name)
    {
        Name = name;
        Type = FileSystemType.File;
        IsMovable = true;
    }
}

public class Folder : FolderContent
{
    public List<FolderContent> Content { get; set; }

    public Folder(string name, List<FolderContent> content) : base(name)
    {
        Name = name;
        Type = FileSystemType.Folder;
        IsMovable = true;
        Content = content;
    }
}

public class Empty : FolderContent
{
    public Empty(string name) : base(name)
    {
        Name = name;
        Type = FileSystemType.Empty;
        IsMovable = false;
    }
}
