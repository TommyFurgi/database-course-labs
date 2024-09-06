using System.ComponentModel.DataAnnotations;

public class InvoiceItem
{
    public int InvoiceItemID { get; set; }
    public int InvoiceNumber { get; set; }
    public int ProductID { get; set; }
    public virtual Invoice? Invoice { get; set; }
    public virtual Product? Product { get; set; }
    public int Quantity { get; set; } = 1;
}
