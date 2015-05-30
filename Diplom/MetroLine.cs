
namespace Diplom
{
    public class MetroLine
    {
        public string LineName { get; private set; }

        public string[] StationName;
        
        
        public MetroLine(string lineName, string[] stations)
        {
            LineName = lineName;
            StationName = stations;
        }

        public override string ToString()
        {
            return LineName;
        }
    }
}
   



 
           
            
        