using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterScript : MonoBehaviour
{
    public Toggle watchCheckbox;
    public Toggle jewelryCheckbox;
    public Toggle clothCheckbox;
    public Toggle maleCheck;
    public Toggle femaleCheck;
    public Toggle kidsCheck;
    public List<GameObject> maleWatches;
    public List<GameObject> femaleWatches;
    public List<GameObject> kidsWatches;
    public List<GameObject> maleCloths;
    public List<GameObject> femaleCloths;
    public List<GameObject> kidsCloths;
    public List<GameObject> maleJewelry;
    public List<GameObject> femaleJewelry;
    public List<GameObject> kidsJewelry;
   

    public GameObject subPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    
    public void EnableSubPanel()
    {
        if(watchCheckbox.isOn || clothCheckbox.isOn || jewelryCheckbox.isOn)
        {
            subPanel.SetActive(true);

        }
        else
        {
            subPanel.SetActive(false);
        }
    }
    public void ApplyFilter()
    {
        
        if (watchCheckbox.isOn)
        {


            if (maleCheck.isOn)
            {

                foreach (GameObject mw in maleWatches)
                {
                    mw.SetActive(true);
                }
            }
            if (femaleCheck.isOn)
            {
                foreach (GameObject fw in femaleWatches)
                {
                    fw.SetActive(true);
                }

            }
            if (kidsCheck.isOn)
            {

                foreach (GameObject kw in kidsWatches)
                {
                    kw.SetActive(true);
                }
            }
        }
        if (clothCheckbox.isOn)
        {


            if (maleCheck.isOn)
            {
                foreach (GameObject mc in maleCloths)
                { 
                    mc.SetActive(true);
            }
        }
        if (femaleCheck.isOn)
        {
            foreach (GameObject fc in femaleCloths) { 

                fc.SetActive(true);
        }
    }

            if (kidsCheck.isOn)
            {
                foreach (GameObject kc in kidsCloths) { 

                kc.SetActive(true);
            }
        } 
            
        }

        if (jewelryCheckbox.isOn)
        {


            if (maleCheck.isOn)
            {

                foreach (GameObject mj in maleJewelry)
                {
                    mj.SetActive(true);
                }
            }
            if (femaleCheck.isOn)
            {
                foreach (GameObject fj in femaleJewelry)
                {
                    fj.SetActive(true);
                }

            }
            if (kidsCheck.isOn)
            {

                foreach (GameObject kj in kidsJewelry)
                {
                    kj.SetActive(true);
                }
            }
        }
    }

    public void ResetFilter()
    {
        watchCheckbox.isOn = false;
        clothCheckbox.isOn = false;
        jewelryCheckbox.isOn = false;
        maleCheck.isOn = false;
        femaleCheck.isOn = false;
        kidsCheck.isOn = false;

    }
    
}
