INSERT INTO user_table (id, login, password) VALUES
(1, 'Biba', 'password'),
(2, 'Boba', 'password'),
(3, 'Amogus', 'password'),
(4, 'Abobus', 'password'),
(5, 'Sus', 'password'),
(6, 'Shush', 'password'),
(7, 'Shesh', 'password'),
(8, 'Bingus', 'password');

-- Insert data into lecturer
INSERT INTO lecturer (id, userId) VALUES
(1, 1),
(2, 2);

-- Insert data into student
INSERT INTO student (id, userId) VALUES
(1, 3),
(2, 4),
(3, 5),
(4, 6),
(5, 7);

-- Insert data into subject
INSERT INTO subject (id, title) VALUES
(1, 'Mathematics'),
(2, 'Physics');

-- Insert data into theme
INSERT INTO theme (id, title, subjectId, amount_of_questions_per_attempt, number_of_attempts) VALUES
(1, 'Algebra', 1, 10, 2),
(2, 'Mechanics', 1, 15, 3),
(3, 'Optics', 2, 12, 2),
(4, 'Thermodynamics', 2, 20, 3);

INSERT INTO question (id,text_of_question, themeId) VALUES
(1,'What is the solution to the equation 3x + 7 = 22?', 1),
(2,'Simplify the expression 2x^2 - 5x + 3 when x = 2.', 1),
(3,'If a + b = 10 and 2a - b = 4, what is the value of a?', 1),
(4,'Solve the inequality 2x + 6 < 14.', 1),
(5,'Factorize the quadratic expression x^2 - 5x + 6.', 1);

-- Insert data into question table for Theme: Mechanics
INSERT INTO question (id,text_of_question, themeId) VALUES
(123,'What is the acceleration of an object with a mass of 5 kg experiencing a force of 20 N?', 2),
(562,'A car starts from rest and accelerates uniformly at 3 m/s^2 for 8 s. What is its final velocity?', 2),
(937,'If an object is in equilibrium, what can be said about the sum of the forces acting on it?', 2),
(293,'What is the work done when a force of 12 N is applied to move an object 4 m?', 2),
(109,'State Newton''s second law of motion.', 2);

INSERT INTO question (id,text_of_question, themeId) VALUES
(333,'What is the relationship between the angle of incidence and the angle of reflection in optics?', 3),
(444,'Define the term "refraction" in the context of optics.', 3),
(555,'How does the focal length of a convex lens change when the object is moved closer to the lens?', 3),
(666,'Explain the concept of total internal reflection in optics.', 3),
(900,'What is the relationship between the object distance and image distance for a convex mirror?', 3);

-- Insert data into question table for Theme: Thermodynamics
INSERT INTO question (id,text_of_question, themeId) VALUES
(432,'State the first law of thermodynamics.', 4),
(220,'Define the term "specific heat capacity" in thermodynamics.', 4),
(901,'What is an adiabatic process in thermodynamics?', 4),
(928,'Explain the concept of entropy in thermodynamics.', 4),
(516,'How does the pressure of a gas change if its volume is decreased while the temperature remains constant (according to Boyle''s Law)?', 4);
