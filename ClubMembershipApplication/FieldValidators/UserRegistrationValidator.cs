using ClubMembershipApplication.Data;
using FieldValidatorAPI;
using System;
using System.Collections.Generic;
using System.Text;
namespace ClubMembershipApplication.FieldValidators
{
    public class UserRegistrationValidator:IFieldValidator
	{
        const int FirstName_Min_Length = 2;
        const int FirstName_Max_Length = 100;
        const int LastName_Min_Length = 2;
        const int LastName_Max_Length = 100;
        delegate bool EmailExistsDel(string emailAddress);
        FieldValidatorDel _fieldValidatorDel = null;

        string[] _fieldArray = null;

        public string[] FieldArray
        {
            get
            {
                if (_fieldArray == null)
                    _fieldArray = new string[Enum.GetValues(typeof(FieldConstants.UserRegistrationField)).Length];
                return _fieldArray;
            }
        }
        public FieldValidatorDel ValidatorDel => _fieldValidatorDel;

        public UserRegistrationValidator(IRegister register)
        {
            _register = register;
        }

        public void InitialiseValidatorDelegates()
        {

        }

        private bool ValidField(int fieldIndex, string fieldValue, string[] fieldArray, out string fieldInvalidMessage)
        {
            fieldInvalidMessage = "";
            FieldConstants.UserRegistrationField userRegistrationField = (FieldConstants.UserRegistrationField)fieldIndex;
            switch (userRegistrationField)
            {
                case FieldConstants.UserRegistrationField.EmailAddress:
                    break;
                case FieldConstants.UserRegistrationField.FirstName:
                    break;
                case FieldConstants.UserRegistrationField.LastName:
                    break;
                case FieldConstants.UserRegistrationField.Password:
                    break;
                case FieldConstants.UserRegistrationField.PasswordCompare:
                    break;
                case FieldConstants.UserRegistrationField.DateOfBirth:
                    break;
                case FieldConstants.UserRegistrationField.PhoneNumber:
                    break;
                case FieldConstants.UserRegistrationField.AddressFirstLine:
                    break;
                case FieldConstants.UserRegistrationField.AddressSecondLine:
                    break;
                case FieldConstants.UserRegistrationField.AddressCity:
                    break;
                case FieldConstants.UserRegistrationField.PostCode:
                    break;
                default:
                    throw new ArgumentException("This field does not exists");
            }
            return (fieldInvalidMessage == "");
        }
    }
}

