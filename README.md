#Tiraggo.EF#
##The Tiraggo Dynamic Query API for the Entity Framework##

By: Mike Griffin (http://www.tiraggo.com)

License: [MIT](http://www.opensource.org/licenses/mit-license.php)

##Tired of LINQ and Lamba?##
Tired of writing complex, unintuitive Linq and Lambda expressions? Why not tap into your knowledge of writing SQL queries. Now you can have the best of both worlds, the Tiraggo Dynamic Query API and your Entity Framework entities.

##Intuitive and Familiar SQL API##
Full Intellisense Support
```csharp

EmployeeQuery q = new EmployeeQuery("e");
EmployeeQuery q1 = new EmployeeQuery("e1");

q.Select(q.EmployeeID, q.LastName)  // To bind to combobox
	.Where(q.LastName.Like("%a%"))
	.InnerJoin(q1).On(q.EmployeeID == q1.ReportsTo)
	.OrderBy(q.LastName.Descending);

using(NorthwindEntities context = new NorthwindEntities())
{
	IList<Employee> employees = q.ToList<Employee>(context);
}
```

Yep, you can actually only select the columns you desire and the SQL is extremely lean.

```sql

SELECT
   e.[EmployeeID],
   e.[LastName]  
FROM
   [Employees] e 
INNER JOIN [Employees] e1 
   ON e.[EmployeeID] = e1.[ReportsTo] 
WHERE
   e.[LastName] LIKE @LastName1 
ORDER BY
   e.[LastName] DESC
```

Compare that to a Entity Framwork query which does the same thing and you'll be shocked.

Requires a single .NET assembly. NuGet package on the way ...

