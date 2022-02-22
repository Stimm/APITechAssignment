if not exists (select 1 from dbo.[ProductType])
begin
	insert into dbo.[ProductType] (TypeId, Description, Stock)
	values (1,"Powers", 1),
	(2, "Writers Tears", 2),
	(3, "Bushmills", 3);

	insert into dbo.Product(ProductId, TypeId)
	values ("a92142ad-99db-4c25-9567-180cd0e25a2b", 1),
	("ac3235a6-8aa6-4b2e-ba26-1efe9c3b36a7",2),
	("90236dad-e22c-4aec-81bf-f88e6c9cea66",2),
	("7c050368-901f-43d9-8a75-21f17f668c98",3),
	("3df89945-7b9f-4fa2-9a27-4db397880693",3),
	("ed254a23-5c1e-4dfa-b688-aa11f64dcf51",3)

end