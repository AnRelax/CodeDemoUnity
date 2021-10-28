using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AmThanh : MonoBehaviour
{

    public static AmThanh instance;
    public GameObject prefab;

    public AudioClip menu;
    private AudioSource menusource;
    public AudioClip Thunder;
    private AudioSource Thundersource;
    public AudioClip theme;
    private AudioSource themesource;


    //khoi tao am thanh
    private void Awake()
    {
        instance = this;
    }

    //goi phuong thuc thuc hien am thanh
    public void PlaySound(AudioClip clip, float volume, bool isLoopback)
    {
        if(clip == this.theme)
        {
            
            Play(clip, ref themesource, volume,isLoopback);
        }
    }

    //am thanh menu
    public void PlaySound(AudioClip clip, float volume)
    {
        if(clip == this.menu)
        {
            Play(clip, ref menusource, volume);
            return;
        }
        if (clip == this.Thunder)
        {
            Play(clip, ref Thundersource, volume);
            return;
        }
    }


    private void Play(AudioClip clip, ref AudioSource audioSouce, float volume, bool isLoopback = false)
    {
        //kiem tra neu am thanh dang thuc hien thi thoi
        if(audioSouce != null && audioSouce.isPlaying)
        {
            return;
        }
        //tao doi tuong
        audioSouce = Instantiate(instance.prefab).GetComponent<AudioSource>();

        audioSouce.volume = volume;//xac dinh am thanh
        audioSouce.loop = isLoopback;//xac dinh lap lai am thanh hay khong
        audioSouce.clip = clip;
        audioSouce.Play();//chay am thanh
        Destroy(audioSouce.gameObject, audioSouce.clip.length);//huy am thanh
    }

    //Stop am thanh
    public void StopSound(AudioClip clip)
    {
        if(clip == this.menu)
        {
            //neu am thanh menu khac null thi thuc hien stop am thanh
            menusource?.Stop();
            return;
        }
        if (clip == this.Thunder)
        {
            //neu am thanh menu khac null thi thuc hien stop am thanh
            menusource?.Stop();
            return;
        }

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
