using System;
namespace ClubMembershipApplication.FieldValidators
{
	public class FieldConstants
	{
		public FieldConstants()
		{
		}
		public enum UserRegistrationField
		{
            EmailAddress,
            FirstName,
            LastName,
            Password,
            PasswordCompare,
            DateOfBirth,
            PhoneNumber,
            AddressFirstLine,
            AddressSecondLine,
            AddressCity,
            PostCode
        }
	}
}

