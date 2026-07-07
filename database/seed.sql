INSERT INTO school_classes(name) VALUES
('1AD'),
('2AD'),
('3AD'),
('4AD'),
('5AD'),
('1AK'),
('2AK'),
('3AK'),
('4AK'),
('5AK'),
('1BK'),
('2BK'),
('3BK'),
('4BK'),
('5BK'),
('1CK'),
('2CK'),
('3CK'),
('4CK'),
('5CK'),
('1DK'),
('2DK'),
('3DK'),
('4DK'),
('5DK'),

('1BL'),
('2BL'),
('3BL'),
('4BL'),
('5BL');

INSERT INTO class_leaders(first_name, last_name, password_hash, password_salt, class_leader_end_date, school_class_id) VALUES
('John', 'Doe', 'hashed_password_1', 'salt_1', '2024-06-30', 1),
('Jane', 'Smith', 'hashed_password_2', 'salt_2', '2024-06-30', 2),
('Alice', 'Johnson', 'hashed_password_3', 'salt_3', '2024-06-30', 3),
('Bob', 'Brown', 'hashed_password_4', 'salt_4', '2024-06-30', 4),
('Charlie', 'Davis', 'hashed_password_5', 'salt_5', '2024-06-30', 5);

INSERT INTO homeroom_teachers(first_name, last_name, password_hash, password_salt, academic_title, school_class_id) VALUES
('Dr. Emily', 'Clark', 'hashed_password_6', 'salt_6', 'PhD', 1),
('Prof. Michael', 'Lewis', 'hashed_password_7', 'salt_7', 'MSc', 2),
('Dr. Sarah', 'Walker', 'hashed_password_8', 'salt_8', 'PhD', 3),
('Prof. David', 'Hall', 'hashed_password_9', 'salt_9', 'MSc', 4),
('Dr. Jessica', 'Allen', 'hashed_password_10', 'salt_10', 'PhD', 5);

INSERT INTO students(first_name, last_name, school_class_id) VALUES
('Emily', 'Wilson', 1),
('Michael', 'Taylor', 1),
('Sarah', 'Anderson', 2),
('David', 'Thomas', 2),
('Jessica', 'Jackson', 3),
('Daniel', 'White', 3),
('Olivia', 'Harris', 4),
('Matthew', 'Martin', 4),
('Sophia', 'Thompson', 5),
('James', 'Garcia', 5);

INSERT INTO absence_notes(student_id, date, reason, comment) VALUES
(1, '2024-01-15', 'Sick', 'Flu'),
(2, '2024-02-20', 'Family Emergency', 'Had to attend a family event'),
(3, '2024-03-10', 'Sick', 'Cold'),
(4, '2024-04-05', 'Personal', 'Needed a mental health day'),
(5, '2024-05-12', 'Sick', 'Stomach ache'),
(6, '2024-06-18', 'Family Emergency', 'Attended a wedding'),
(7, '2024-07-22', 'Sick', 'Fever'),
(8, '2024-08-30', 'Personal', 'Had to take care of a personal matter'),
(9, '2024-09-14', 'Sick', 'Headache'),
(10, '2024-10-25', 'Family Emergency', 'Had to visit a sick relative');