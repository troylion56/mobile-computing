using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class soundManager : MonoBehaviour
{   
    [Header("       -----Player----")]
    public AudioSource mortePlayer;
    public AudioSource dannoPlayer;
    public AudioSource fineBenzina;
    public AudioSource proiettiliPlayer;
    public AudioSource missiliPlayer;
    public AudioSource raccoltaCollezionabili;

    [Header("       -----Enemy----")]
    public AudioSource proiettiliNemici;
    public AudioSource dannoNemici;
    public AudioSource morteNemici;

    [Header("       -----livello----")]
    public AudioSource distruzioneAsteroidi;
    public AudioSource fineLivello;
    public AudioSource gameOver;
    public AudioSource pausa;

    [Header("       -----Musica----")]
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

        if(SceneManager.GetActiveScene().name=="PrimoLivello" || SceneManager.GetActiveScene().name=="SecondoLivello" || SceneManager.GetActiveScene().name=="tutorial") {
            suonaMusica(musicaLivelli);
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

    public void suonaMusica (AudioSource m){
        volumeMusica(m);                                       //aggiorno il volume della musica
        m.Play();
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

    public void cambiaVolume(float vol){
        musicaLivelli.volume=vol;
    }
}
