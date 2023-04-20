using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{

    public static AudioSource mortePlayer;
    public static AudioSource fineBenzina;
    public static AudioSource proiettiliPlayer;
    public static AudioSource missiliPlayer;
    public static AudioSource proiettiliNemici;
    public static AudioSource morteNemici;
    public static AudioSource distruzioneAsteroidi;
    public static AudioSource fineLivello;
    public static AudioSource gameOver;
    public static AudioSource musicaEsterna;
    public static AudioSource musicaLivelli;

    private static float effetti;
    private static float musica;

    void Start()
    {
        if (!PlayerPrefs.HasKey("volumeEffetti")){
            PlayerPrefs.SetFloat("volumeEffetti",1);
            effetti=1f;
        }else{
            effetti=PlayerPrefs.GetFloat("volumeEffetti");
        }    

        if (!PlayerPrefs.HasKey("volumeMusica")){
            PlayerPrefs.SetFloat("volumeMusica",1);
            musica=1f;
        }else{
            musica=PlayerPrefs.GetFloat("volumeMusica");
        }    
    }

    public static void volumeEffetti (AudioSource s){
        s.volume=s.volume*effetti;
    }

    public void volumeMusica (AudioSource s){
        s.volume=s.volume*musica;
    }

    public static void suonaEffetto (AudioSource s){
        volumeEffetti(s);                                       //aggiorno il volume dell'effetto
        s.Play();
    }

        //!metodi effetti

    public static void playMortePlayer(){
        suonaEffetto(mortePlayer);
    }

    public static void playFineBenzina(){
        suonaEffetto(fineBenzina);
    }

    public static void playProiettiliPlayer(){
        suonaEffetto(proiettiliPlayer);
    }

    public static void playMissiliPlayer(){
        suonaEffetto(missiliPlayer);
    }

    public static void playProiettiliNemici(){
        suonaEffetto(proiettiliNemici);
    }

    public static void playMorteNemici(){
        suonaEffetto(morteNemici);
    }

    public static void playDistruzioneAsteroidi(){
        suonaEffetto(distruzioneAsteroidi);
    }

    public static void playFineLivello(){
        suonaEffetto(fineLivello);
    }

    public static void playGameOver(){
        suonaEffetto(gameOver);
    }
}
