namespace ServicesContract;
public interface ICitiesService
{
    List<string> GetCities();
    Guid InstanceID {  get; }
}

