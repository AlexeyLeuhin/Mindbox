CREATE TABLE categories (
  id INT NOT NULL,
  name VARCHAR (50) NOT NULL,
  PRIMARY KEY (id)
);
 
INSERT INTO categories (id, name) VALUES
    (1, 'Electronics'),
    (2, 'Cars'),
    (3, 'Food');
 
CREATE TABLE products (
  id INT NOT NULL,
  name VARCHAR(50) NOT NULL,
  category_id INT NOT NULL,
  PRIMARY KEY (id)
);
 
INSERT INTO dbo.products (id, name, category_id) VALUES
    (1, 'Milk', 3),
    (2, 'Potato', 3),
    (3, 'BMW', 2),
    (4, 'IPhone', 1),
    (5, 'IPhone', 1),
    (6, 'Mercedes', 2);
 
SELECT products.name AS ProductName, categories.name AS CategoryName FROM products LEFT JOIN categories ON products.category_id = categories.id;