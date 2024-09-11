BEGIN 
	-- Определение таблиц


	DROP TABLE IF EXISTS #t_category;
	-- Категории
	CREATE TABLE #t_category (
		category_ID INT PRIMARY KEY NOT NULL,
		category_Name VARCHAR(1000) NOT NULL
	);

	DROP TABLE IF EXISTS #t_product;
	-- Товары
	CREATE TABLE #t_product (
		product_ID INT PRIMARY KEY NOT NULL,
		product_Name VARCHAR(1000) NOT NULL
	);

	DROP TABLE IF EXISTS #t_prod_cat_link;
	-- Связь товара с категорией
	CREATE TABLE #t_prod_cat_link (
		product_ID INT NOT NULL,
		category_ID INT NOT NULL,
		CONSTRAINT UQ_prod_cat UNIQUE (product_id, category_ID),
		CONSTRAINT FK_product FOREIGN KEY (product_ID) REFERENCES #t_product (product_ID) ON DELETE CASCADE ON UPDATE CASCADE, -- не работают на времянках
		CONSTRAINT FK_category FOREIGN KEY (category_ID) REFERENCES #t_category (category_ID) ON DELETE CASCADE ON UPDATE CASCADE -- не работают на времянках
	);
END

BEGIN 
	-- Заполнение и вывод данных

	INSERT INTO #t_category
	VALUES	(1, 'Еда'),
			(2, 'Бытовая химия');

	INSERT INTO #t_product
	VALUES	(10, 'Торт'),
			(11, 'Хлеб'),
			(20, 'Мыло'),
			(30, 'Вилка')

	INSERT INTO #t_prod_cat_link
	VALUES	(10, 1),
			(11, 1),
			(20, 2),
			(20, 1)

	SELECT P.*, C.*
	FROM #t_product AS P
	LEFT JOIN 
		(	#t_prod_cat_link AS L
			JOIN #t_category AS C 
				ON c.category_ID = L.category_ID
		) ON L.product_ID = P.product_ID
END