﻿namespace Cosmetics.Products
{
	using Cosmetics.Contracts;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Common;

	public abstract class Product : IProduct
	{
		private const int ProductNameMinLength = 3;
		private const int ProductNameMaxLength = 10;
		private const int BrandNameMinLength = 2;
		private const int BrandNameMaxLength = 10;
		protected decimal price;
		protected string name;
		protected string brand;
		protected GenderType gender;

		public Product(string name, string brand, decimal price, GenderType gender)
		{
			this.Name = name;
			this.Brand = brand;
			this.Price = price;
			this.Gender = gender;
		}

		public string Brand
		{
			get
			{
				return this.brand;
			}
			protected set
			{
				Validator.CheckIfStringLengthIsValid(value,
					BrandNameMaxLength,
					BrandNameMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Brand name", BrandNameMinLength, BrandNameMaxLength));

				this.brand = value;
			}
		}

		public GenderType Gender
		{
			get
			{
				return this.gender;
			}
			protected set
			{
				this.gender = value;
			}
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			private set
			{
				Validator.CheckIfStringLengthIsValid(value,
					ProductNameMaxLength,
					ProductNameMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", ProductNameMinLength, ProductNameMaxLength));

				this.name = value;
			}
		}

		public abstract decimal Price { get; protected set; }		

		public virtual string Print()
		{
			StringBuilder text = new StringBuilder();
			text.AppendLine($"- {this.Brand} – {this.Name}:");
			text.AppendLine($"  * Price: ${this.Price}");
			text.AppendLine($"  * For gender: {this.Gender}");

			return text.ToString();
		}
	}
}
