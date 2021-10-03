using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayFolder : MonoBehaviour
{
    [SerializeField]
    int horizontalSpacing = 10;

    [SerializeField]
    int verticalSpacing = 10;

    [SerializeField]
    int numberOfColumns = 10;

    [SerializeField]
    GameObject folderPrefab;

    [SerializeField]
    int xStart = 175;

    [SerializeField]
    int yStart = 175;

    float xStartOffset;
    float yStartOffset;


    List<GameObject> folderContent;

    private void Awake()
    {
        folderContent = folderPrefab.GetComponent<FileSystemObject>().folderContent;
    }

    void Start()
    {
        var panel = GetComponent<RectTransform>();
        xStartOffset = panel.rect.xMin + xStart;
        yStartOffset = panel.rect.yMax - yStart;
        CreateDisplay();
    }

    private void Update()
    {
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {

    }

    private void CreateDisplay()
    {
        for (int i = 0; i < folderContent.Count; i++)
        {
            var obj = Instantiate(folderContent[i], Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = folderContent[i].GetComponent<FileSystemObject>().objectName;
        }
    }

    private Vector3 GetPosition(int i)
    {
        return new Vector3(xStartOffset + horizontalSpacing * (i % numberOfColumns), yStartOffset + -verticalSpacing * (i / numberOfColumns), 0f);
    }
}
