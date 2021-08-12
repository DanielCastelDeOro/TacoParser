namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

           
            var cells = line.Split(','); // .Split will split a string everytime time it sees a coma and turs it into an array of strings

            if (cells.Length < 3)
            {
              
                return null; // TODO Implement
            }

            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var nameFrom = cells[2];
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;
            var tacoBell = new TacoBell();
            tacoBell.Name = nameFrom;
            tacoBell.Location = point;
           
            return tacoBell;
        }
    }
}