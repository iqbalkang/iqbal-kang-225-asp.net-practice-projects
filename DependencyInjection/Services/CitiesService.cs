namespace Services
{
    public class CitiesService
    {
        private List<string> _cities;

        public CitiesService()
        {
            _cities = new List<string>()
            {
                "Paris", "London", "Delhi", "Sacramento", "Auckland"
            };
        }

        public List<string> GetCities()
        {
            return _cities;
        }

        //public List<string> GetCities { get; }

    }
}