﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WhiteLabel.Data.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateAfterTodayAttribute : ValidationAttribute
    {
        public DateAfterTodayAttribute()
        {
            ErrorMessage = "Date must be on or after today";
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (value != null && DateTime.TryParse(value.ToString(), out date))
            {
                date = DateTime.Parse(value.ToString()); // assuming it's in a parsable string format
                return (date >= DateTime.Now);
            }
            return true;
        }
    }
}
