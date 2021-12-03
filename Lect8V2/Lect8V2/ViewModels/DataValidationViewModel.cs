using Lect8.Validations;
using Lect8V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lect8.ViewModels
{
    public class DataValidationViewModel : BaseViewModel
    {
        #region fields
        private ValidatableObject<string> _userName = new();
        private ValidatableObject<string> _password = new();

        #endregion
        #region properties
        public ValidatableObject<string> UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public ValidatableObject<string> Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
            }
        }
        #endregion
        #region methods
        private bool Validate()
        {
            bool isValidUser = ValidateUserName();
            bool isValidPassword = ValidatePassword();
            return isValidUser && isValidPassword;
        }

        private bool ValidateUserName()
        {
            return _userName.Validate();
        }

        private bool ValidatePassword()
        {
            return _password.Validate();
        }
        private void AddValidations()
        {
            _userName.Validations.Add(new EmailRule<string>
            {
                ValidationMessage = "Invalid email."
            });
            _password.Validations.Add(new PasswordRule<string>
            {
                ValidationMessage = "The password length should greater than 8,and contains at least 1 upper char and 1 digit."
            });
        }
        #endregion
        #region Commands
        public ICommand ValidateEmailCommand => new Command(() =>
        {
            ValidateUserName();
        });
        public ICommand ValidatePasswordCommand => new Command(() =>
        {
            ValidatePassword();
        });
        #endregion


        public DataValidationViewModel()
        {
            AddValidations();
        }

        
    }
}
