using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Prototype
{



    internal class ImageHandler
    {
        private Bitmap _currentBitmap;
        //private Stack<Bitmap> _bitmapHistory;
        private Bitmap _previousBitmap;

        public ImageHandler()
        {

        }

        //
        // Getters and Setters
        //
        public Bitmap CurrentBitmap
        {
            get
            {
                if (_currentBitmap == null)
                {
                    _currentBitmap = new Bitmap(1, 1);
                }

                return _currentBitmap;
            }

            set
            {
                _currentBitmap = value;
            }
        }
        public Bitmap PreviousBitmap
        {
            get { if (_previousBitmap == null) { _previousBitmap = _currentBitmap; } return _previousBitmap; }
            set { _previousBitmap = value; }
        }


    }
}
