using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Seeder
    /// </summary>
    static internal class Seeder
    {
        public static readonly List<Institution> Institutions = [];
        public static readonly List<Department> Departments = [];
        public static readonly List<Course> Courses = [];

        private static void SeedInstitution()
        {
            Institutions.Add(new Institution("Otago Polytechnic",
                                             "Otago",
                                             "New Zealand"));

            Institutions.Add(new Institution("University of Otago",
                                             "Otago",
                                             "New Zealand"));

            Institutions.Add(new Institution("University of Canterbury",
                                             "Canterbury",
                                             "New Zealand"));
        }

        private static void SeedDepartment()
        {
            // Otago Polytechnic
            Departments.Add(new Department(Institutions[0], "Information Technology"));
            Departments.Add(new Department(Institutions[0], "Engineering"));
            Departments.Add(new Department(Institutions[0], "Construction"));

            // University of Otago
            Departments.Add(new Department(Institutions[1], "Biochemistry"));
            Departments.Add(new Department(Institutions[1], "Pharmacology"));
            Departments.Add(new Department(Institutions[1], "Microbiology"));

            // University of Canterbury
            Departments.Add(new Department(Institutions[2], "Computer Science"));
            Departments.Add(new Department(Institutions[2], "Software Engineering"));
            Departments.Add(new Department(Institutions[2], "Mathematics"));
        }

        private static void SeedCourse()
        {
            // Otago Polytechnic - Information Technology
            Courses.Add(new Course(Departments[0],
                                   101,
                                   "Introduction to Programming",
                                   "An introduction to programming concepts, problem solving, algorithms, and software development.",
                                   15,
                                   750));

            Courses.Add(new Course(Departments[0],
                                   201,
                                   "Database Development",
                                   "An introduction to relational databases, SQL, database design, and data management.",
                                   15,
                                   800));

            Courses.Add(new Course(Departments[0],
                                   301,
                                   "Web Application Development",
                                   "Development of modern web applications using HTML, CSS, JavaScript, and server-side programming.",
                                   15,
                                   850));


            // Otago Polytechnic - Engineering
            Courses.Add(new Course(Departments[1],
                                   110,
                                   "Engineering Fundamentals",
                                   "An introduction to engineering principles, problem solving, technical drawing, and engineering practice.",
                                   15,
                                   900));

            Courses.Add(new Course(Departments[1],
                                   210,
                                   "Engineering Mathematics",
                                   "Mathematical techniques used to solve practical engineering problems.",
                                   15,
                                   900));

            Courses.Add(new Course(Departments[1],
                                   310,
                                   "Engineering Design",
                                   "Principles and practices of engineering design, prototyping, testing, and evaluation.",
                                   15,
                                   950));


            // Otago Polytechnic - Construction
            Courses.Add(new Course(Departments[2],
                                   120,
                                   "Construction Fundamentals",
                                   "An introduction to construction methods, materials, tools, and workplace practices.",
                                   15,
                                   850));

            Courses.Add(new Course(Departments[2],
                                   220,
                                   "Construction Management",
                                   "Principles of planning, organising, and managing construction projects.",
                                   15,
                                   900));

            Courses.Add(new Course(Departments[2],
                                   320,
                                   "Building Technology",
                                   "Study of modern building systems, construction techniques, materials, and building performance.",
                                   15,
                                   950));


            // University of Otago - Biochemistry
            Courses.Add(new Course(Departments[3],
                                   130,
                                   "Introduction to Biochemistry",
                                   "An introduction to the chemical processes and molecular mechanisms underlying biological systems.",
                                   15,
                                   1000));

            Courses.Add(new Course(Departments[3],
                                   230,
                                   "Molecular Biochemistry",
                                   "Study of proteins, nucleic acids, enzymes, and molecular processes within living organisms.",
                                   15,
                                   1050));

            Courses.Add(new Course(Departments[3],
                                   330,
                                   "Advanced Biochemistry",
                                   "Advanced study of biochemical pathways, molecular interactions, and biochemical research methods.",
                                   15,
                                   1100));


            // University of Otago - Pharmacology
            Courses.Add(new Course(Departments[4],
                                   140,
                                   "Introduction to Pharmacology",
                                   "An introduction to drugs, their mechanisms of action, and their effects on biological systems.",
                                   15,
                                   1000));

            Courses.Add(new Course(Departments[4],
                                   240,
                                   "Drug Action and Development",
                                   "Study of drug mechanisms, therapeutic targets, drug development, and pharmacological testing.",
                                   15,
                                   1050));

            Courses.Add(new Course(Departments[4],
                                   340,
                                   "Advanced Pharmacology",
                                   "Advanced study of pharmacological principles, drug interactions, and therapeutic applications.",
                                   15,
                                   1100));


            // University of Otago - Microbiology
            Courses.Add(new Course(Departments[5],
                                   150,
                                   "Introduction to Microbiology",
                                   "An introduction to microorganisms, microbial diversity, and their roles in biological systems.",
                                   15,
                                   1000));

            Courses.Add(new Course(Departments[5],
                                   250,
                                   "Microbial Genetics",
                                   "Study of microbial genetics, gene expression, mutation, and genetic variation.",
                                   15,
                                   1050));

            Courses.Add(new Course(Departments[5],
                                   350,
                                   "Advanced Microbiology",
                                   "Advanced study of microorganisms, microbial pathogenesis, laboratory methods, and research techniques.",
                                   15,
                                   1100));


            // University of Canterbury - Computer Science
            Courses.Add(new Course(Departments[6],
                                   160,
                                   "Computer Science Fundamentals",
                                   "An introduction to computer science, computational thinking, algorithms, and data structures.",
                                   15,
                                   950));

            Courses.Add(new Course(Departments[6],
                                   260,
                                   "Data Structures and Algorithms",
                                   "Study of fundamental data structures and algorithms used in software development.",
                                   15,
                                   1000));

            Courses.Add(new Course(Departments[6],
                                   360,
                                   "Artificial Intelligence",
                                   "Introduction to artificial intelligence concepts, machine learning, search algorithms, and intelligent systems.",
                                   15,
                                   1100));


            // University of Canterbury - Software Engineering
            Courses.Add(new Course(Departments[7],
                                   170,
                                   "Software Engineering Fundamentals",
                                   "Introduction to software engineering principles, development methodologies, and software lifecycle management.",
                                   15,
                                   950));

            Courses.Add(new Course(Departments[7],
                                   270,
                                   "Software Design",
                                   "Principles of software architecture, object-oriented design, requirements, and system modelling.",
                                   15,
                                   1000));

            Courses.Add(new Course(Departments[7],
                                   370,
                                   "Software Project Management",
                                   "Planning, managing, testing, and delivering software projects using modern development practices.",
                                   15,
                                   1050));


            // University of Canterbury - Mathematics
            Courses.Add(new Course(Departments[8],
                                   180,
                                   "Calculus",
                                   "Introduction to differential and integral calculus and their applications.",
                                   15,
                                   900));

            Courses.Add(new Course(Departments[8],
                                   280,
                                   "Linear Algebra",
                                   "Study of vectors, matrices, linear transformations, and systems of linear equations.",
                                   15,
                                   900));

            Courses.Add(new Course(Departments[8],
                                   380,
                                   "Applied Mathematics",
                                   "Application of mathematical techniques to modelling and solving practical scientific problems.",
                                   15,
                                   950));
        }

        public static void SeedAll()
        {
            SeedInstitution();
            SeedDepartment();
            SeedCourse();
        }
    }
}
