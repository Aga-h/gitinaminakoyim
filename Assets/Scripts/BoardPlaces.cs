using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class BoardPlaces : MonoBehaviour
{
     
    void Start()
    {
        List<BuyableProperties> buyableProperties = new List<BuyableProperties>();

        buyableProperties.Add(new BuyableProperties("Sedefoglu", 60, 50, 2, 10, 30, 90, 160, 250, 30));
        buyableProperties.Add(new BuyableProperties("Prep", 60, 50, 4, 20, 60, 180, 320, 450, 30));
        buyableProperties.Add(new BuyableProperties("Gastronomi", 100, 50,    6,   30,  90,  270, 400, 550, 50));
        buyableProperties.Add(new BuyableProperties("FagotOdasi", 100, 50,   6,   30,  90,  270, 400, 550, 50));
        buyableProperties.Add(new BuyableProperties("Revir", 120, 50,    8,   40,  100, 300, 450, 600, 60));
        buyableProperties.Add(new BuyableProperties("Tekcan", 140, 100,  10,  50,  150, 450, 625, 750, 70));
        buyableProperties.Add(new BuyableProperties("Helivel", 140, 100, 10,  50,  150, 450, 625, 750, 70));
        buyableProperties.Add(new BuyableProperties("Lab", 160, 100, 12,  60,  180, 500, 700, 900, 80));
        buyableProperties.Add(new BuyableProperties("EdebiyatBinasi", 180, 100,  14,  70,  200, 550, 750, 950, 90));
        buyableProperties.Add(new BuyableProperties("FenBinasi", 180, 100,   14,  70,  200, 550, 750, 950, 90));
        buyableProperties.Add(new BuyableProperties("PrepBinasi", 200, 100,  16,  80,  220, 600, 800, 1000,    100));
        buyableProperties.Add(new BuyableProperties("Arikan", 220, 150,  18,  90,  250, 700, 875, 1050,    110));
        buyableProperties.Add(new BuyableProperties("Bilginer", 220, 150,    18,  90,  250, 700, 875, 1050,    110));
        buyableProperties.Add(new BuyableProperties("Lojmanlar", 240, 150,   20,  100, 300, 750, 925, 1100,    120));
        buyableProperties.Add(new BuyableProperties("Hasret", 260, 150,  22,  110, 330, 800, 975, 1150,    130));
        buyableProperties.Add(new BuyableProperties("AnaBina", 260, 150, 22,  110, 330, 800, 975, 1150,    130));
        buyableProperties.Add(new BuyableProperties("MudurOdasi", 280, 150,  24,  120, 360, 850, 1025,    1200,    140));
        buyableProperties.Add(new BuyableProperties("Antoinette", 300, 200,  26,  130, 390, 900, 1100,    1275,    150));
        buyableProperties.Add(new BuyableProperties("Pulak", 300, 200,    26,  130, 390, 900, 1100,    1275,    150));
        buyableProperties.Add(new BuyableProperties("EdebiyatZumresi", 320, 200, 28,  150, 450, 1000,    1200,    1400,    160));
        buyableProperties.Add(new BuyableProperties("Temple", 350, 200,  35,  175, 500, 1100,    1300,    1500,    175));
        buyableProperties.Add(new BuyableProperties("MudurMalikanesi", 400, 200, 50,  200, 600, 1400,    1700,    2000,    200));
    }

    // Update is called once per frame\
    void Update()
    {
        
    }
}
