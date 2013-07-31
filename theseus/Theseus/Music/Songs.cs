using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus.Music
{
   public class Songs
    {


      public  static String Tetris()
        {
            string song = string.Empty;

            song += "E-5-4,B-4-8,C-5-8,D-5-4,C-5-8,B-4-8,";
            song += "A-4-4,A-4-8,C-5-8,E-5-4,D-5-8,C-5-8,";
            song += "B-4-4.5,C-5-8,D-5-4,E-5-4,";
            song += "C-5-4,A-4-4,A-4-8,A-4-8,B-4-8,C-5-8,";

            song += "D-5-4.5,F-5-8,A-5-4,G-5-8,F-5-8,";
            song += "E-5-4.5,C-5-8,E-5-4,D-5-8,C-5-8,";
            song += "B-4-4,B-4-8,C-5-8,D-5-4,E-5-4,";
            song += "C-5-4,A-4-4,A-4-4,P-4,";

            song += "E-5-2,C-5-2,D-5-2,B-4-2,C-5-2,A-4-2,";
            song += "GS-4-2,B-4-4,P-4,E-5-2,C-5-2,D-5-2,B-4-2,";
            song += "C-5-4,E-5-4,A-5-2,GS-5-2";

            return song;
        }

      public static void playWav( String path)
      {
          System.Media.SoundPlayer player = new System.Media.SoundPlayer();
          player.SoundLocation = path;
          player.PlayLooping(); 

      }
    }
}
