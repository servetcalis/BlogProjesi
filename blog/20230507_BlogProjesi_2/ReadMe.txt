1. Asp.Net Web App (Model-View-Controller) - EF6 ile "20230403_BlogProjesi" oluşturuldu.
2. Class Library .Net Standart - EF6 ile "Entities" projesi oluşturuldu.
	2.1. "Entities - Abstract" klasörü açılır.
		2.1.1. "Entities - Abstract" klasöründe "IEntityBase.cs" dosyası açılır.
		2.1.1. "Entities - Abstract" klasöründe "EntityBase.cs" dosyası açılır.
	2.2. "Entities - Concrete" klasörü açılır.
		2.2.1. "Entities - Concrete - Category.cs" dosyası açılır.
		2.2.2. "Entities - Concrete - Blog.cs" dosyası açılır.
		2.2.3. "Entities - Concrete - AppUser.cs" dosyası açılır.
		2.2.4. "Entities - Concrete - AppRole.cs" dosyası açılır.
		2.2.5. "Entities - Concrete - AppRoleClaim.cs" dosyası açılır.
		2.2.6. "Entities - Concrete - AppUserClaim.cs" dosyası açılır.
		2.2.7. "Entities - Concrete - AppUserLogin.cs" dosyası açılır.
		2.2.8. "Entities - Concrete - AppUserRole.cs" dosyası açılır.
		2.2.9. "Entities - Concrete - AppUserToken.cs" dosyası açılır.
3. Class Library .Net Standart - EF6 ile "DataAccess" projesi oluşturuldu.
	3.1. "DataAccess - Concrete" klasörü açılır.
		3.1.1 "DataAccess - Concrete - EntityFramework" klasörü açılır.
			3.1.1.1 "DataAccess - Concrete - EntityFramework - Context" klasörü açılır.
				3.1.1.1.1 "DataAccess - Concrete - EntityFramework - Context" klasörü içerisinde "BlogDbContext.cs" dosyası açılır.
			3.1.1.2 "DataAccess - Concrete - EntityFramework - Mapping" klasörü açılır.
				3.1.1.2.1 "DataAccess - Concrete - EntityFramework - Mapping" klasörü içerisinde "CategoryMap.cs" dosyası açılır.
				3.1.1.2.2 "DataAccess - Concrete - EntityFramework - Mapping" klasörü içerisinde "UserMap.cs" dosyası açılır.
				3.1.1.2.3 "DataAccess - Concrete - EntityFramework - Mapping" klasörü içerisinde "BlogMap.cs" dosyası açılır.