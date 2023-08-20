using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SearchManager : MonoBehaviour
{

    public GameObject ContentHol;
    public GameObject[] Contentitem;
    public GameObject Searchbar;

    public int totalEle;

    // Start is called before the first frame update
    void Start()
    {
        totalEle = ContentHol.transform.childCount;

        Contentitem = new GameObject[totalEle];
        for(int i = 0; i < totalEle; i++)
        {
            Contentitem[i] = ContentHol.transform.GetChild(i).gameObject;
        }
    }
    public void SearchItem()
    {
        string Searchitem = Searchbar.GetComponent<TMP_InputField>().text;
        int searchitemlen = Searchitem.Length;
        int searcheditems = 0;
        foreach(GameObject si in Contentitem)
        {
            searcheditems += 1;
            if (si.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Length >= searchitemlen)
            {
                if (Searchitem == si.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Substring(0, searchitemlen).ToLower())
                {
                    si.SetActive(true);

                }
                else
                {
                    si.SetActive(false);
                }
                
            }
        }
    }
}
