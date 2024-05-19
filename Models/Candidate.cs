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
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name of the candidate.
        /// </value>
        [Required(ErrorMessage = "First Name is required")]
        public required string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name of the candidate.
        /// </value>
        [Required(ErrorMessage = "Last Name is required")]

        public required string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone no.
        /// </summary>
        /// <value>
        /// The phone no of the candidate.
        /// </value>
        public string? PhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email of the candidate.
        /// </value>
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public required string Email { get; set; }


        /// <summary>
        /// Gets or sets the time to call.
        /// </summary>
        /// <value>
        /// The scheduled time to call .
        /// </value>
        public string? TimeToCall { get; set; }


        /// <summary>
        /// Gets or sets the linkedin address.
        /// </summary>
        /// <value>
        /// The linked url.
        /// </value>
        public string? LinkedIn { get; set; }


        /// <summary>
        /// Gets or sets the github address.
        /// </summary>
        /// <value>
        /// The github address.
        /// </value>
        public string? Github { get; set; }


        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        [Required(ErrorMessage = "Comments is required")]
        public required string FreeText { get; set; }
    }
}
