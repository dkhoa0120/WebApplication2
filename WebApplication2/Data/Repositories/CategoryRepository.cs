﻿using WebApplication2.Models;

namespace WebApplication2.Data.Repositories
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		private ApplicationDbContext _context;
		public CategoryRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(Category category)
		{
			var categoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
			if (categoryDB != null)
			{
				categoryDB.Name = category.Name;
				categoryDB.DisplayOrder = category.DisplayOrder;
			}
		}
	}
}
