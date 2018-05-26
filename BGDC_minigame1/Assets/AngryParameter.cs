using UnityEngine;

public class AngryParameter : MonoBehaviour {

    private int noisePar=0;
    public TimerScript Timer;
    private int random;
    private int score=0;
    private float angryTimer;
    private bool canCount=true;
    private bool doOnce=false;
    private bool nambahscore;
    int x;
    void GameOver() { Debug.Log("GameOver!"); }

    void NoiseStudent(int time) {
        /*Mekanik jika belum di tap dalam 5 detiknya blm ada. Tolong dibantu*/
        TimerMahasiswa();
        if(Input.GetKey("a")){
            ResetTimerMahasiswa();
         score =+ 5000;
        }

        if (time == 0) {

            ResetTimerMahasiswa();
            noisePar++;
       }
		if (time == 5) {
			//Change Lecturer state to Angry
			//AngryLecturer();
			//SpreadOut();
		}
  
    }

    void SpawnNoisystudent() {
        Debug.Log("noisy student spawned!!"); //mau ngetest function
    }
    void TimerMahasiswa() {
        if (angryTimer >= 0.0f && canCount) {
            angryTimer -= Time.deltaTime;
        }
        else if(angryTimer <= 0.0f && !doOnce)
        {

            canCount = false;
            doOnce = true;
            angryTimer = 0;
        }

    }

    void ResetTimerMahasiswa() {
        canCount = true;
        doOnce = false;
        angryTimer = 5;
    }
    public void Mechanics() {
        
        switch (random) {
            case 1:
                if (Timer.t % 3 == 0) { 
					SpawnNoisystudent();
                    NoiseStudent(x);
                    x = 0;
                    Debug.Log(score);
                    Debug.Log(noisePar);

                }  break;
             case 2: if (Timer.t % 2 == 0) { 
					SpawnNoisystudent();
                    NoiseStudent(x);
                    x = 0;
                    Debug.Log(score);
                    Debug.Log(noisePar);
                } break;

        }

        if (Timer.t == 0 || noisePar > 5) {   //akan gameover jika waktu sudah habis atau mahasiswa yang keluar 5
            GameOver();
        }
    }
    void Start()
    {
        Timer.startTime = Time.deltaTime;
    }

    void Update () {
        random = Random.Range(1, 2);
        Mechanics();

    }
}
