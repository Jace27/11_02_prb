using System;
using System.Collections.Generic;

namespace _11_02_21_prb.DBEntities
{
    public class Patient
    {
        private string full_nameField;

        private string loginField;

        private string pwdField;

        private string guidField;

        private string emailField;

        private uint social_sec_numberField;

        private string einField;

        private string social_typeField;

        private string phoneField;

        private ushort passport_sField;

        private uint passport_nField;

        private long birthdate_timestampField;

        private ushort idField;

        private string countryField;

        private string insurance_nameField;

        private string insurance_addressField;

        private uint insurance_innField;

        private string ipadressField;

        private uint insurance_pcField;

        private uint insurance_bikField;

        private string uaField;

        /// <remarks/>
        public string full_name
        {
            get
            {
                return this.full_nameField;
            }
            set
            {
                this.full_nameField = value;
            }
        }

        /// <remarks/>
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }

        /// <remarks/>
        public string pwd
        {
            get
            {
                return this.pwdField;
            }
            set
            {
                this.pwdField = value;
            }
        }

        /// <remarks/>
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public uint social_sec_number
        {
            get
            {
                return this.social_sec_numberField;
            }
            set
            {
                this.social_sec_numberField = value;
            }
        }

        /// <remarks/>
        public string ein
        {
            get
            {
                return this.einField;
            }
            set
            {
                this.einField = value;
            }
        }

        /// <remarks/>
        public string social_type
        {
            get
            {
                return this.social_typeField;
            }
            set
            {
                this.social_typeField = value;
            }
        }

        /// <remarks/>
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public ushort passport_s
        {
            get
            {
                return this.passport_sField;
            }
            set
            {
                this.passport_sField = value;
            }
        }

        /// <remarks/>
        public uint passport_n
        {
            get
            {
                return this.passport_nField;
            }
            set
            {
                this.passport_nField = value;
            }
        }

        /// <remarks/>
        public long birthdate_timestamp
        {
            get
            {
                return this.birthdate_timestampField;
            }
            set
            {
                this.birthdate_timestampField = value;
            }
        }

        /// <remarks/>
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string insurance_name
        {
            get
            {
                return this.insurance_nameField;
            }
            set
            {
                this.insurance_nameField = value;
            }
        }

        /// <remarks/>
        public string insurance_address
        {
            get
            {
                return this.insurance_addressField;
            }
            set
            {
                this.insurance_addressField = value;
            }
        }

        /// <remarks/>
        public uint insurance_inn
        {
            get
            {
                return this.insurance_innField;
            }
            set
            {
                this.insurance_innField = value;
            }
        }

        /// <remarks/>
        public string ipadress
        {
            get
            {
                return this.ipadressField;
            }
            set
            {
                this.ipadressField = value;
            }
        }

        /// <remarks/>
        public uint insurance_pc
        {
            get
            {
                return this.insurance_pcField;
            }
            set
            {
                this.insurance_pcField = value;
            }
        }

        /// <remarks/>
        public uint insurance_bik
        {
            get
            {
                return this.insurance_bikField;
            }
            set
            {
                this.insurance_bikField = value;
            }
        }

        /// <remarks/>
        public string ua
        {
            get
            {
                return this.uaField;
            }
            set
            {
                this.uaField = value;
            }
        }
    }
}
