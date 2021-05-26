using System;
using System.ComponentModel.DataAnnotations;

namespace ExperianHealth.Api.Helper
{
    public class ValidationPatient : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (Convert.ToInt32(value) > 0)
                return true;
            else
                return false;
        }
    }
}
