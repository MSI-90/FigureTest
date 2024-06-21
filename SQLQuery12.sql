SELECT Products.product_name AS 'Наименование продукта', Category.category_name AS 'Наименование категории'
FROM ProductCategory
FULL OUTER JOIN Products ON ProductCategory.product_id = Products.id
LEFT JOIN Category ON ProductCategory.category_id = Category.id;