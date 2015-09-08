using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duckhunt.ViewModel
{
    class GameVM
    {
        Boolean playable = true;
        
        public void Play()
        {
            Initialise();
            LoadGraphicsContent();
            while (playable)
            {
                Update();

                try
                {
                    Thread.Sleep(20);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

	          
        }

        private void Initialise()
        {

        }
        private void Update()
        {

        }
        private void LoadGraphicsContent()
        {

        }

    }
}
