using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMMIS.Models
	{
	public class DemoContext : DbContext
		{
			public DbSet<ServiceCentreModel> ServiceCentre { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder options)
				=>options.UseSqlite(@"Data Source=C:\\Users\\rahee\\Desktop\\ICT2106_P3-2\\RMMIS\\RMMIS.db");
			


	}
}
