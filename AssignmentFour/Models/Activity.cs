﻿using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentFour.Models
{
    public class Activity
    {
        public int ID { get; set; }

        [Display(Name = "Activity Name")]
        public String ActivityName { get; set; }

        [Display(Name = "Activity Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ActivityDate { get; set; }

        [Display(Name = "Title")]
        public String ActivityTitle { get; set; }

        [Display(Name = "Participants")]
        public String ActivityParticipants { get; set; }

        [Display(Name = "Category")]
        public String ActivityCategory { get; set; }

        [Display(Name = "Description")]
        public String ActivityDescription { get; set; }

        [Display(Name = "Length in Hours")]
        public decimal ActivityLengthHours { get; set; }

        [Display(Name = "More")]
        public String ActivityText { get; set; }
    }

    public class ActivityDBContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }//take activity just defined and put it in a set called activities and give it the ability to read and write
                                                //need Using.System.Data.Entity
    }

}