﻿namespace Core
{
	public class BaseEntity<T>
	{
		public T Id { get; set; }	
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }	
		public DateTime DeletedAt { get; set; }
	}
}
