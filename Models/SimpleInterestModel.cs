
public class SimpleInterestModel
{
    public decimal Principal { get; set; }
    public decimal Rate { get; set; }      // Annual rate in %
    public decimal Time { get; set; }      // Time in years
    public decimal Interest { get; set; }  // Computed interest
}
