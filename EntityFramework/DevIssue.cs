//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DevIssue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DevIssue()
        {
            this.DevIssueComments = new HashSet<DevIssueComment>();
            this.DevIssueLabelTypes = new HashSet<DevIssueLabelType>();
            this.DevIssueUploadedFiles = new HashSet<DevIssueUploadedFile>();
            this.DevIssueVotes = new HashSet<DevIssueVote>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int VisibilityOptionID { get; set; }
        public int Day { get; set; }
        public System.DateTime Time { get; set; }
        public int CreatedByID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevIssueComment> DevIssueComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevIssueLabelType> DevIssueLabelTypes { get; set; }
        public virtual VisibilityOption VisibilityOption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevIssueUploadedFile> DevIssueUploadedFiles { get; set; }
        public virtual Citizen Citizen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevIssueVote> DevIssueVotes { get; set; }
    }
}