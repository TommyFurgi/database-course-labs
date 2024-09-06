using System.ComponentModel.DataAnnotations;

public class Invoice
{
    [Key]
    public int InvoiceNumber { get; set; }
    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}