namespace Polat.CarFactory;

public static class CarFactoryDbProperties
{
    public static string DbTablePrefix { get; set; } = "CarFactory";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CarFactory";
}
