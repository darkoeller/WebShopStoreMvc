using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopStoreMvc01.Models;

namespace WebShopStoreMvc01.Data;

public class ApplicationUser : IdentityUser
{
	[StringLength(50)]
	public string FirstName { get; set; } = string.Empty;
	[StringLength(50)]
	public string LastName { get; set; } = string.Empty;
	[StringLength(150)]
	public string Address { get; set; } = string.Empty;
	[ForeignKey("UserId")]
	public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();
}