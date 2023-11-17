﻿namespace Employee_Management_System.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string? FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string?  LastName { get; set; }
		public string? Email { get; set; }
		public string? PhoneNo { get; set; }
		public string? City { get; set; }
		public string? FullName => "{FirstName} {MiddleName} {LastName}";
	}
}
