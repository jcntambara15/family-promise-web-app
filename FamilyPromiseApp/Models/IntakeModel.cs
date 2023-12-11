using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;


namespace FamilyPromiseApp.Models
{
    
    public enum AdultNum
    {
        Yes, No
    }
    public enum WorkStudy
    {
        Yes, No
    }
     public enum HouseType
    {
        Apartment, House, MobileHome
    }
    public enum RecentHousing
    {
        Renting, Purchased, Outside, Shelter, Car, Hotel
    }
    public class IntakeModel
    {
        [Display(Name = "Client ID")]
        public int ID { get; set; }
        // [Key]
        // public int CaseID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Substance Issues")]
        public string SubstanceIss { get; set; }

        [Display(Name = "Have you ever lived in a shelter before?")]
        public string ShelterBefore { get; set; }

        [Display(Name = "Income source: state the amount and if you are currently receiving, applied for, or received in past employment: TANF, Social Security, SSI/SSDI, Unemployment Benefits, Workers Compensation, Veterans Benefits, Food Stamps, Child Support, Vocational Rehab, Health Department, Medicaid, Child care, Public housing, Employment Assistance, Child Support-CSE, Child Support- Direct, Mental Health Services, CHANPUS, other")]
        public string Income { get; set; }
        [Display(Name = "Do you live alone with chidren or the father of your children? If so, explain.")]
        public string FatherChild { get; set; }


        [Display(Name = "Gender Identity?")]
        public string Gender { get; set; }




        [Display(Name = "Referral taken by:")]
        public string TakenByNow { get; set; }

        [DataType(DataType.Time)]
        public DateTime TimeNow { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateToday { get; set;}

        [Display(Name = "If over 16: Highest Form of Education: High School Dropout, High School, GED, Started College, Completed Degree, Post High School Vocational Completion, etc.")]
        public string Education { get; set; }

        [Display(Name = "Referring Agency / Source:")]
        public string ReferralAgency { get; set;}
        [Display(Name = "What is their phone number?")]
        public string EmployerPhone { get; set;}

        [Display(Name = "What is the job description? Are you full-time / part-time / day laborer / temp?")]
        public string JobDescription { get; set;}

        [Display(Name = "If unemployed, what keeps you from working?")]
        public string Unemployed { get; set;}

        [Display(Name = "Have you ever been terminated from a job?")]
        public string Fired { get; set;}

        [Display(Name = "What is your longest length of employment?")]
        public string LengthOfEmploy { get; set;}

        [Display(Name = "What skills do you have?")]
        public string Skills { get; set;}

        [Display(Name = "Have you ever been arrested? If so, what were your charges? Are any still pending? On what day were you charged?")]
        public string Arrest { get; set;}

        [Display(Name = "Where were you arrested?")]
        public string ArrestLoc { get; set;}

        [Display(Name = "Do you have any convictions? On what day were you convicted??")]
        public string Convictions { get; set;}
        [Display(Name = "Who is your parole officer?")]
        public string Parole { get; set;}

        [Display(Name = "What is their phone number?")]
        public string ParolePhone { get; set;}

        [Display(Name = "What is their email?")]
        public string ParoleEmail { get; set;}
        


        [Display(Name = "Are you employed? If so, where?")]
        public string EmployedWhere { get; set;}

        [Display(Name = "Has the family ever filed for bankruptcy?")]
        public string Bankruptcy { get; set;}

        [Display(Name = "Employment/Income")]
        public string IsEmployed { get; set; }

        [Display(Name = "Monthly Rent, if applicable.")]
        public int IsHoused { get; set; }

        [Display(Name = "Relationship")]
        public string Relationships { get; set; }


        [Display(Name = "Were you or are you a part of the Work Study Program?")]
        public string WorkStudy { get; set; }

        [Display(Name = "How many adults?")]
        public string AdultNum { get; set; }

        
        [Display(Name = "SSN")]
        public int SSN { get; set; }

        [Display(Name = "What is your main reason for being homeless? Eviction, Kicked Out, Diasaster, Moved, Other")]
        public string Reason { get; set; }

        [Display(Name = "What is your secondary reason for being homeless? Lost Job, Family Dissolution (Death, Divorce, etc.), Benefits Stopped, Medical Problems, Other")]
        public string Reason2 { get; set; }

        [Display(Name = "ID Number")]
        public int IDNum { get; set; }
        
        [Display(Name = "Race")]
        public string Race { get; set; }

        [Display(Name = "Gender Identity")]
        public string ChildGender { get; set; }

        [Display(Name = "Do you own any methods of transportation? If so, how many? What is the make/model/year? What is/are the license plate(s)?")]
        public string Transportation { get; set; }

        public string FirstName { get; set; }
        [Column("First Name")]
        [Display(Name = "First Name")]

        public string FirstMidName { get; set; }
        [Display(Name = "Marital Status- if so, where are they located?")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Are any children in school? If so, where and what grade?")]
        public string ChildSchool { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        

        [Display(Name = "Are you or have you ever been involved in the Department for Children and Families (DCF)? Explain. ")]
        public string DCF { get; set; }
        
        [Display(Name = "Date Admitted")]
        public int DateAdmitted { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        


        
        [Display(Name = "Completion Date")]
        public int CompletionDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        
        [Display(Name = "Cell Number")]
        public string CellPhoneNum { get; set; }

        [Display(Name = "Work Number")]
        public string WorkPhoneNum { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAdd { get; set;}

        [Display(Name = "Address")]
        public string HomeAddress { get; set;}

        [Display(Name = "Do you or have you ever had substance abuse? If so, what substance? Have you received treatment or do you plan to? Are you clean/dry now?")]
        public string SubstanceAbuse { get; set;}
        
        [Display(Name = "Are there any additional adults in the household?")]
        public AnyHouseHold? HouseHoldMemberExists { get; set; }

        [Display(Name = "Name")]
        public string AdultName { get; set; }

        [Display(Name = "Assets (Total Amount). Include cars, savings, checking, real estate, and vehicles.")]
        public int Assets { get; set; }

        [Display(Name = "Age")]
        public int AdultAge { get; set; }

        [Display(Name = "Debts (Total Amount) List type and amount.")]
        public int Debts { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime AdultDateOfBirth { get; set; }

        [Display(Name = "Cell Phone")]
        public string AdultCellPhone { get; set; }

        [Display(Name = "Work Phone")]
        public string AdultWorkPhone { get; set; }
        [Display(Name = "Email")]
        public string AdultEmail { get; set; }
        
        [Display(Name = "Are there any additional children in the household?")]
        public AnyChildren? HouseHoldChildrenExists { get; set; }

        [Display(Name = "Most Recent Housing")]
        public RecentHousing? RecentHousing { get; set; }

        [Display(Name = "What type of housing were you living in?")]
        public HouseType? HouseType { get; set; }

        [Display(Name = "Number of children in household")]
        public int ChildNum { get; set; }

        [Display(Name = "Name")]
        public string ChildName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime ChildDateOfBirth { get; set; }
        [Display(Name = "Age")]
        public int ChildAge { get; set; }

    }
}
