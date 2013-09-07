#The Tiraggo Dynamic Query API for the EntityFramework#
==========
By: Mike Griffin] (http://www.tiraggo.com)
License: [MIT](http://www.opensource.org/licenses/mit-license.php)

##Linq & Lamba? NOT!!##
Tired of writing complex, unintuitive Linq and Lambda expressions? Why not tap into your already well honed SQL experience and write intuitive queries. Now you can have the best of both worlds, the Tiraggo Dynamic Query API which will load your Entity Framework entities.

##Intuitive API##
```csharp

	EmployeeQuery q = new EmployeeQuery("e");
	EmployeeQuery q1 = new EmployeeQuery("e1");

	q.Select(q.EmployeeID, q.LastName)
		.Where(q.LastName.Like("%a%"))
		.InnerJoin(q1).On(q.EmployeeID == q1.ReportsTo)
		.OrderBy(q.LastName.Descending);

	using(NorthwindEntities context = new NorthwindEntities())
	{
		IList<Employee> employees = q.ToList<Employee>(context);
	}
```