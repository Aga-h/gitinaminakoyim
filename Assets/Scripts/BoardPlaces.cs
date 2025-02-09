using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class BoardPlaces : MonoBehaviour
{
     
    void Start()
    {
        List<BuyableProperties> buyableProperties = new List<BuyableProperties>();

        buyableProperties.Add(new BuyableProperties("Sedefoglu", 60));
        buyableProperties.Add(new BuyableProperties("Prep", 60));
        buyableProperties.Add(new BuyableProperties("Gastronomi", 100));
        buyableProperties.Add(new BuyableProperties("FagotOdasi", 100));
        buyableProperties.Add(new BuyableProperties("Revir", 120));
        buyableProperties.Add(new BuyableProperties("Tekcan", 140));
        buyableProperties.Add(new BuyableProperties("Helivel", 140));
        buyableProperties.Add(new BuyableProperties("Lab", 160));
        buyableProperties.Add(new BuyableProperties("EdebiyatBinasi", 180));
        buyableProperties.Add(new BuyableProperties("FenBinasi", 180));
        buyableProperties.Add(new BuyableProperties("PrepBinasi", 200));
        buyableProperties.Add(new BuyableProperties("Arikan", 220));
        buyableProperties.Add(new BuyableProperties("Bilginer", 220));
        buyableProperties.Add(new BuyableProperties("Lojmanlar", 240));
        buyableProperties.Add(new BuyableProperties("Hasret", 260));
        buyableProperties.Add(new BuyableProperties("AnaBina", 260));
        buyableProperties.Add(new BuyableProperties("MudurOdasi", 280));
        buyableProperties.Add(new BuyableProperties("Antoinette", 300));
        buyableProperties.Add(new BuyableProperties("Pulak", 300));
        buyableProperties.Add(new BuyableProperties("EdebiyatZumresi", 320));
        buyableProperties.Add(new BuyableProperties("Temple", 350));
        buyableProperties.Add(new BuyableProperties("MudurMalikanesi", 400));
    }

    // Update is called once per frame\
    void Update()
    {
        
    }
}
