CREATE TABLE school_classes (
    school_class_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(5) NOT NULL UNIQUE
);

CREATE TABLE homeroom_teachers (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(200) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    password_salt VARCHAR(255) NOT NULL,
    academic_title VARCHAR(50),
    school_class_id INT NOT NULL,
    FOREIGN KEY (school_class_id)
        REFERENCES school_classes(school_class_id)
);

CREATE TABLE class_leaders (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(200) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    password_salt VARCHAR(255) NOT NULL,
    class_leader_end_date DATE NOT NULL,
    school_class_id INT NOT NULL,
    FOREIGN KEY (school_class_id)
        REFERENCES school_classes(school_class_id)
);

CREATE TABLE students (
    student_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(200) NOT NULL,
    school_class_id INT,
    FOREIGN KEY (school_class_id)
        REFERENCES school_classes(school_class_id)
);

CREATE TABLE absence_notes (
    absence_note_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT NOT NULL,
    date DATE NOT NULL,
    reason VARCHAR(100) NOT NULL,
    comment VARCHAR(255),
    FOREIGN KEY (student_id)
        REFERENCES students(student_id)
);