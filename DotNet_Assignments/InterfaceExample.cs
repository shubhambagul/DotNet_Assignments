using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal interface IPlayble
    {
        void Play(string playingAction);
    }
    class videoPlayer : IPlayble
    {
        public void Play(string playingAction)
        {
            Console.WriteLine($"We Are {playingAction}");
        }
    }
    class musicPlayer : IPlayble
    {
        public void Play(string playingAction)
        {
            Console.WriteLine($"We Are {playingAction}");
        }
    }

    internal class InterfaceExample
    {
        static void Main()
        {
            videoPlayer obj1 = new videoPlayer();
            obj1.Play("Playing Video");
            musicPlayer obj2 = new musicPlayer();
            obj2.Play("Playing Music");
        }
    }
}
