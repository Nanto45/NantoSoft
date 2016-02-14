using NantoSoft.SalesManagement.Metier;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.DataBase
{
	public class DbInitializer : CreateDatabaseIfNotExists<SalesManagementContext>
	{
		protected override void Seed(SalesManagementContext smContext)
		{
			base.Seed(smContext);
		}
	}
}
