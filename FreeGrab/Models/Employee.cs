//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeGrab.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Comments = new HashSet<Comment>();
            this.HistoryPosts = new HashSet<HistoryPost>();
        }

        public int Id { get; set; }
        [DisplayName("Upload file")]
        public string Avatar { get; set; }
        public HttpPostedFileBase ImageName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DateOfBirth { get; set; }

        [Required]

        public byte Gender { get; set; }

        [Required]
        [MaxLength(60)]
        [MinLength(1)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(8)]
        public string Phone { get; set; }
        public int RoleID { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(6)]
        public string Password { get; set; }

        [MaxLength(250)]
        [MinLength(6)]

        public string NewPassword { get; set; }

        [MaxLength(250)]
        [MinLength(6)]
        public string OldPassword { get; set; }

        [MaxLength(250)]
        [MinLength(6)]
        [NotMapped] // Does not effect with your database
        [Compare("NewPassword")]

        public string ConfirmPassword { get; set; }
        private DateTime _createdOn = DateTime.MinValue;
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        public DateTime DateCreate
        {
            get
            {
                return (_createdOn == DateTime.MinValue) ? DateTime.Now : _createdOn;
            }
            set { _createdOn = value; }
        }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        public DateTime DateUpdate
        {
            get
            {
                return (_createdOn == DateTime.MinValue) ? DateTime.Now : _createdOn;
            }
            set { _createdOn = value; }
        }
        public Nullable<bool> IsActive { get; set; }
        public bool IsEmailVerified { get; set; }
        public System.Guid ActivationCode { get; set; }
        public string ResetPasswordCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryPost> HistoryPosts { get; set; }
    }
}
