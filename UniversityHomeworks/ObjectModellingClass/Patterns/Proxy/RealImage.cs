namespace UniversityHomeworks.ObjectModellingClass.Patterns.Proxy
{
    public class RealImage : Image
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("DisplayingReal " + fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("LoadingReal " + fileName);
        }
    }
}
