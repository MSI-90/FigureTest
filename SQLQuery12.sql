SELECT Products.product_name AS '������������ ��������', Category.category_name AS '������������ ���������'
FROM ProductCategory
FULL OUTER JOIN Products ON ProductCategory.product_id = Products.id
LEFT JOIN Category ON ProductCategory.category_id = Category.id;