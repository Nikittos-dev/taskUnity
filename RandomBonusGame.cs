using UnityEngine;

public class RandomBonusGame : MonoBehaviour
{
    [SerializeField] private GameObject Bon1;
    [SerializeField] private GameObject Bon2;

    public void RandomBounsGamee()
    {
        int _bonusRange;
        _bonusRange = Random.RandomRange(0, 2);
        if (_bonusRange == 0)
        {
            Bon1.SetActive(true);
        }
        else
        {
            Bon2.SetActive(true);
        }
    }
}
