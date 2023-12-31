﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopStoreMvc01.Models;

public class Product
{
   public int Id { get; set; }
   [Required]
   [StringLength(200, MinimumLength = 2)]
   public string Title { get; set; } = string.Empty;
   public string Description { get; set; } = string.Empty;
   [Required]
   [Column(TypeName = "decimal(9,2)")]
   public decimal Quantity { get; set; }
   [Required]
   [Column(TypeName = "decimal(9,2)")]
   public decimal Price { get; set; }
   [ForeignKey(("ProductId"))]
   public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
   [ForeignKey(("ProductId"))]
   public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}