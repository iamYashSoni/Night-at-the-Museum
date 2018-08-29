//using system.collections;
//using system.collections.generic;
//using unityengine;
//using unityengine.ui;
//using unityengine.video;

//public class videocontroller : monobehaviour
//{

//    public rawimage image;
//    public image playicon;

//    public videoclip videotoplay;

//    private videoplayer videoplayer;
//    private videosource videosource;

//    private audiosource audiosource;

//    private bool paused = false;
//    private bool play = true;

//    // use this for initialization
//    // void start () {
//    //  application.runinbackground = true;
//    //  startcoroutine(playvideo());
//    // }

//    ienumerator playvideo()
//    {
//        playicon.gameobject.setactive(false);
//        play = false;

//        //add videoplayer to the gameobject
//        videoplayer = gameobject.addcomponent<videoplayer>();

//        //add audiosource
//        audiosource = gameobject.addcomponent<audiosource>();

//        //disable play on awake for both video and audio
//        videoplayer.playonawake = false;
//        audiosource.playonawake = false;
//        audiosource.pause();

//        //we want to play from video clip not from url

//        videoplayer.source = videosource.videoclip;

//        // vide clip from url
//        //videoplayer.source = videosource.url;
//        //videoplayer.url = "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";


//        //set audio output to audiosource
//        videoplayer.audiooutputmode = videoaudiooutputmode.audiosource;

//        //assign the audio from video to audiosource to be played
//        videoplayer.enableaudiotrack(0, true);
//        videoplayer.settargetaudiosource(0, audiosource);

//        //set video to play then prepare audio to prevent buffering
//        videoplayer.clip = videotoplay;
//        videoplayer.prepare();

//        //wait until video is prepared
//        waitforseconds waittime = new waitforseconds(1);
//        while (!videoplayer.isprepared)
//        {
//            debug.log("preparing video");
//            //prepare/wait for 5 sceonds only
//            yield return waittime;
//            //break out of the while loop after 5 seconds wait
//            break;
//        }

//        debug.log("done preparing video");

//        //assign the texture from video to rawimage to be displayed
//        image.texture = videoplayer.texture;

//        //play video
//        videoplayer.play();

//        //play sound
//        audiosource.play();

//        debug.log("playing video");
//        while (videoplayer.isplaying)
//        {
//            debug.logwarning("video time: " + mathf.floortoint((float)videoplayer.time));
//            yield return null;
//        }

//        debug.log("done playing video");
//    }

//    public void playpause()
//    {
//        if (!play && !paused)
//        {
//            videoplayer.pause();
//            audiosource.pause();
//            playicon.gameobject.setactive(true);
//            paused = true;
//        }

//        else if (!play && !paused)
//        {
//            videoplayer.play();
//            audiosource.play();
//            playicon.gameobject.setactive(false);
//            paused = false;
//        }

//        else
//        {
//            startcoroutine(playvideo());
//        }
//    }

//    // update is called once per frame
//    void update()
//    {

//    }
//}
