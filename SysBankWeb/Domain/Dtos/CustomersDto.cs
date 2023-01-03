using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
	public class CustomersDto
	{
		public int IdClient {get;set;}
		public string UserName {get;set;}
        public string Password { get; set; }
		public int IdentificationNumber { get; set; }
		public string NameClient { get; set; }
        public string LastNameClient { get; set; }
		public string EmailClient { get; set; }    
		public int PhoneClient { get; set; }
    }
}
