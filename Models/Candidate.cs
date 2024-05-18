using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace SIGMA.Models
{
    public class Candidate
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        [Required(ErrorMessage = "First Name is required")]
        public required string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        [Required(ErrorMessage = "Last Name is required")]

        public required string LastName { get; set; }

        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        public string? PhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public required string Email { get; set; }


        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        public string? TimeToCall { get; set; }


        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        public string? LinkedIn { get; set; }


        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        public string? Github { get; set; }


        /// <summary>
        /// Gets or sets the program name.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        [Required(ErrorMessage = "Comments is required")]
        public required string FreeText { get; set; }
    }
}
