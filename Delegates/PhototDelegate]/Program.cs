using System.Diagnostics;

public class Photo
{
    public static Photo Load(string path)
    {
        return new Photo();
    }

    public void Save()
    {
        Console.WriteLine("Savind the photo");
    }
}

public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);
    public void Process(string path, PhotoFilterHandler filterHandler)
    {
        var photo = Photo.Load(path);

       
        //var filters = new PhotoFilters();
        //filters.ApplyBrightness(photo);
        //filters.ApplyContrast(photo);
        //filters.Resize(photo);

        filterHandler(photo);
    }
}

public class PhotoFilters
{
    public void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Applying Brightness");
    }

    public void ApplyContrast(Photo photo)  
    {
        Console.WriteLine("Applying Constrast");
    }

    public void Resize(Photo photo)
    {
        Console.WriteLine("Resizing photo");
    }

    public class Program
    {
        public static void Main(string[] args) 
        {
            //var processor = new PhotoProcessor();
            //processor.Process("photo.jpg");

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += filters.RedEyeRemovers;
            processor.Process("photo.jpg", filterHandler);


        }
    }

    public void RedEyeRemovers(Photo photo)
    {
        Console.WriteLine("Removing red eye");
    }
}