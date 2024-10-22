namespace MyApp.Models;

public class PriceQuotation
{
    public decimal Subtotal { get; set; }
    public decimal DiscountPercent { get; set; }

    // Calculated properties
    public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);
    public decimal Total => Subtotal - DiscountAmount;
}
