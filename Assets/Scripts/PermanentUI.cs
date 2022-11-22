using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PermanentUI : MonoBehaviour
{
    public int gems = 0;
    public int Health = 3;
    [SerializeField] public Text gemText;
    [SerializeField] public Text HealthAmount;
    
    public static PermanentUI perm;

    void Start()
    {
        if (perm == null)
        {
            perm = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        gemText.text = gems.ToString();
        HealthAmount.text = Health.ToString();
    
        if (gems == 20)
        {
            
            gems = 0;
            Health++;
            HealthAmount.text = Health.ToString();
            gemText.text = gems.ToString();
        }

        if(Health == 0)
        {
            Reset();
        }
    }

    public void Reset ()
    {
        gems = 0;
        Health = 3;
        gemText.text = gems.ToString();
        HealthAmount.text = Health.ToString();
    }
}
