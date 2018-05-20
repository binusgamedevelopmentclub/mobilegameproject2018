using UnityEngine;

public class ButtonMap : MonoBehaviour {

	private int angryPar;
    private int NoisePar;

    void GameOver()
    { }

	void Update () {
        angryPar = 1;
        NoisePar=0;
        while (angryPar < 4) {


        }

        if (angryPar == 4) {
            GameOver();
        }

	}
}
