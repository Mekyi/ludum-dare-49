using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    RectTransform rectTransform;
    CanvasGroup canvasGroup;
    public Vector2 lastPosition;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (GetComponent<FileSystemObject>().GetFileSystemType() == FileSystemType.Empty)
        {
            eventData.pointerDrag = null;
            return;
        }

        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;
        lastPosition = GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        FileSystemObject fileSystemObject = GetComponent<FileSystemObject>();

        if (fileSystemObject == null || eventData.pointerDrag == null)
        {
            return;
        }

        if (fileSystemObject.GetFileSystemType() == FileSystemType.Folder)
        {
            GameObject draggedObject = eventData.pointerDrag;
            FileSystemObject fileSystemProperties = draggedObject.GetComponent<FileSystemObject>();

            fileSystemObject.AddFileSystemObject(
                fileSystemProperties.objectName,
                fileSystemProperties.GetFileSystemType(),
                newFolderContent: fileSystemProperties.folderContent

            );

            if (draggedObject.GetComponent<FileSystemObject>().type == FileSystemType.File)
            {
                draggedObject.transform.parent = gameObject.transform;
            }
        }
        else if (fileSystemObject.GetFileSystemType() == FileSystemType.Empty)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragAndDrop>().lastPosition;
        }
        else
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragAndDrop>().lastPosition;
        }
    }
}
