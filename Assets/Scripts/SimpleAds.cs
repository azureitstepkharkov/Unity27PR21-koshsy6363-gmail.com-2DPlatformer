using UnityEngine;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif
public class SimpleAds : MonoBehaviour
{ public void ShowAd()
    {
#if UNITY_ADS
 if (Advertisement.IsReady())
#endif
        {
            //if(PlayerPrefs.GetInt("noads")!=1) 
            {
#if UNITY_ADS
            Advertisement.Show();
#endif
                //PlayerPrefs.SetInt("DC",0); 
            }
        }
    }
}