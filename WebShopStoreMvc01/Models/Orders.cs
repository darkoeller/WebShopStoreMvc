using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopStoreMvc01.Models;

public class Orders
{
   public int Id { get; set; }

   [DataType(DataType.Date)]
   [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
   public DateTime DateCreated { get; set; }

   [Required(ErrorMessage = "Ukupna cijena je traženo")]
   [Column(TypeName = "decimal(7,2)")]
   public decimal Total { get; set; }

   [Required(ErrorMessage = "Ime je traženo.")]
   [StringLength(50)]
   public string BillingFirstName { get; set; } = string.Empty;

   [Required(ErrorMessage = "Prezime je traženo.")]
   [StringLength(50)]
   public string BillingLastName { get; set; } = string.Empty;

   [Required(ErrorMessage = "Telefon je traženo.")]
   [StringLength(50)]
   public string BillingPhone { get; set; } = string.Empty;

   [Required(ErrorMessage = "Email adresa je traženo.")]
   [StringLength(100)]
   [DataType(DataType.EmailAddress, ErrorMessage = "Neispravan e-mail.")]
   public string BillingEmail { get; set; } = string.Empty;

   [Required(ErrorMessage = "Grad je traženo.")]
   [StringLength(50)]
   public string BillingCity { get; set; } = string.Empty;

   [Required(ErrorMessage = "Država je traženo.")]
   [StringLength(50)]
   public string BillingCountry { get; set; } = string.Empty;

   [Required(ErrorMessage = "Poštanski broj je traženo.")]
   [StringLength(20)]
   public string BillingZip { get; set; } = string.Empty;

   public string Message { get; set; } = string.Empty;
   public string UserId { get; set; }
   [ForeignKey("OrderId")]
   public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
   [Required(ErrorMessage = "Ime je traženo.")]
   [StringLength(50)]
   public string ShippingFirstName { get; set; } = string.Empty;

   [Required(ErrorMessage = "Prezime je traženo.")]
   [StringLength(50)]
   public string ShippingLastName { get; set; } = string.Empty;

   [Required(ErrorMessage = "Telefon je traženo.")]
   [StringLength(50)]
   public string ShippingPhone { get; set; } = string.Empty;

   [Required(ErrorMessage = "Email adresa je traženo.")]
   [StringLength(100)]
   [DataType(DataType.EmailAddress, ErrorMessage = "Neispravan e-mail.")]
   public string ShippingEmail { get; set; } = string.Empty;

   [Required(ErrorMessage = "Grad je traženo.")]
   [StringLength(50)]
   public string ShippingCity { get; set; } = string.Empty;

   [Required(ErrorMessage = "Država je traženo.")]
   [StringLength(50)]
   public string ShippingCountry { get; set; } = string.Empty;

   [Required(ErrorMessage = "Poštanski broj je traženo.")]
   [StringLength(20)]
   public string ShippingZip { get; set; } = string.Empty;
}