SELECT Products.product_name AS 'Product_Name', Category.category_name AS 'Category_Name'
FROM ProductCategory
FULL OUTER JOIN Products ON ProductCategory.product_id = Products.id
LEFT JOIN Category ON ProductCategory.category_id = Category.id;
