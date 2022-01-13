﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteScrollView : MonoBehaviour
{
    [SerializeField] private GameObject Content;
    public List<Image> fffs;
    public GameObject image;

    private void Update()
    {

        foreach (Image fff in fffs)
        {
            if (fff.gameObject.activeInHierarchy)
            {
                if (!fff.GetComponent<RectTransform>().IsVisibleFrom(Camera.main))
                {

                    fff.gameObject.SetActive(false);

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            asdf();
        }

    }
    private void asdf()
    {
        fffs.Add(Instantiate(image, Content.transform.position, Quaternion.identity, Content.transform).GetComponent<Image>());
    }
}