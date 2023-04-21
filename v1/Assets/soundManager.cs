using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{   public AudioSource mortePlayer;
    public AudioSource dannoPlayer;
    public AudioSource fineBenzina;
    public AudioSource proiettiliPlayer;
    public AudioSource missiliPlayer;
    public AudioSource proiettiliNemici;
    public AudioSource dannoNemici;
    public AudioSource morteNemici;
    public AudioSource distruzioneAsteroidi;
    public AudioSource fineLivello;
    public AudioSource gameOver;
    public AudioSource pausa;
    public AudioSource raccoltaCollezionabili;
    public AudioSource musicaEsterna;
    public AudioSource musicaLivelli;

    private float effetti;
    private float musica;

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

    public void volumeEffetti (AudioSource s){
        effetti=PlayerPrefs.GetFloat("volumeEffetti");
        s.volume=effetti;
    }

    public void volumeMusica (AudioSource s){
        musica=PlayerPrefs.GetFloat("volumeMusica");
        s.volume=musica;
    }

    public void suonaEffetto (AudioSource s){
        volumeEffetti(s);                                       //aggiorno il volume dell'effetto
        s.Play();
    }

        //!metodi effetti

    public void playMortePlayer(){
        suonaEffetto(mortePlayer);
    }
    public void playDannoPlayer(){
        suonaEffetto(dannoPlayer);
    }

    public void playFineBenzina(){
        suonaEffetto(fineBenzina);
    }

    public void playProiettiliPlayer(){
        suonaEffetto(proiettiliPlayer);
    }

    public void playMissiliPlayer(){
        suonaEffetto(missiliPlayer);
    }

    public void playProiettiliNemici(){
        suonaEffetto(proiettiliNemici);
    }

    public void playDannoNemici(){
        suonaEffetto(dannoNemici);
    }
    public void playMorteNemici(){
        suonaEffetto(morteNemici);
    }

    public void playDistruzioneAsteroidi(){
        suonaEffetto(distruzioneAsteroidi);
    }

    public void playFineLivello(){
        suonaEffetto(fineLivello);
    }

    public void playGameOver(){
        suonaEffetto(gameOver);
    }

    public void playPausa(){
        suonaEffetto(pausa);
    }

    public void playRaccoltaCollezionabili(){
        suonaEffetto(raccoltaCollezionabili);
    }
}
