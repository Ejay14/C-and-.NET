    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace PetSystem.Business
    {
        using System;
        class Supplier
        {
   

                #region data members
                private string supplierID, name, phone;
                private string address, zipcode, cityID;

                #endregion

                #region Properties
                public string getSupplierID
                {
                    get { return  supplierID; }
                    set { supplierID = value; }
                }

                public string getName
                {
                    get { return name; }
                    set { name = value; }
                }
                public string Telephone
                {
                    get { return phone; }
                    set { phone = value; }
                }

                public string getAddress
                {
                     get { return address; }
                     set { address = value; }
                 }

                public string getZipcode
            {
                get { return zipcode; }
                set { zipcode = value; }
            }

            public string getCityID
            {
                get { return cityID; }
                set { cityID = value; }
            }
            #endregion

                #region Construtor
                public Supplier()
                    {
                        supplierID = "";
                        name = "";
                        phone = "";
                        address = "";
                        zipcode = "";
                        cityID = "";
                    }

                public Supplier(string pID, string pName, string pPhone, string pAddress,string pZipcode, string cityid)
                {
                    supplierID = pID;
                    name = pName;
                    phone = pPhone;
                    address = pAddress;
                    zipcode = pZipcode;
                    cityID = cityid;
                }
                #endregion

                #region ToStringMethod
                public override string ToString()
                {
                    return name + '\n' + phone + address;
                }

                #endregion
        }
    }
