namespace PhotoBookExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBookDefault = new PhotoBook(24);
            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
            SmallPhotoAlbum smallPhotoAlbum = new SmallPhotoAlbum();

            Console.WriteLine($"The Default Photo book has {photoBookDefault.NumPages} pages.");
            Console.WriteLine($"The Big Photo book has {bigPhotoAlbum.NumPages} pages.");
            Console.WriteLine($"The Small Photo book has {smallPhotoAlbum.NumPages} pages.");


            Console.ReadKey();
        }
    }

    public class PhotoBook
    {
        private int _numPages;

        public int NumPages
        {
            get
            {
                return _numPages;
            }
            private set
            {
                _numPages = value;
            }
        }

        public PhotoBook()
        {
            _numPages = 16;
        }

        public PhotoBook(int numPages) 
        {
            _numPages = numPages;
        }
    }

    public class BigPhotoAlbum : PhotoBook
    {
        public BigPhotoAlbum() : base(64)
        {

        }
    }
    public class SmallPhotoAlbum : PhotoBook
    {
        public SmallPhotoAlbum() : base(16)
        {

        }
    }

}
