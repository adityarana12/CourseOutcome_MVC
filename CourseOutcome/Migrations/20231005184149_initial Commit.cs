using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourseOutcome.Migrations
{
    /// <inheritdoc />
    public partial class initialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qtext = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QId);
                    table.ForeignKey(
                        name: "FK_Question_Subject_SId",
                        column: x => x.SId,
                        principalTable: "Subject",
                        principalColumn: "SId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    Enrollmentno = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Response1 = table.Column<int>(type: "int", nullable: true),
                    Response2 = table.Column<int>(type: "int", nullable: true),
                    Response3 = table.Column<int>(type: "int", nullable: true),
                    Response4 = table.Column<int>(type: "int", nullable: true),
                    Response5 = table.Column<int>(type: "int", nullable: true),
                    Response6 = table.Column<int>(type: "int", nullable: true),
                    Suggestion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => new { x.Enrollmentno, x.SId });
                    table.ForeignKey(
                        name: "FK_Response_Subject_SId",
                        column: x => x.SId,
                        principalTable: "Subject",
                        principalColumn: "SId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SId", "SubjectName" },
                values: new object[,]
                {
                    { "CCMCA-265", "Lab Cloud Computing" },
                    { "EBMCA-265", "Lab e-Business Systems" },
                    { "FSDMCA-168", "Full Stack Development Lab" },
                    { "MCA-101", "Discrete Structures" },
                    { "MCA-102", "Data and File Structures" },
                    { "MCA-103", "Computer Networks" },
                    { "MCA-104", "Object Oriented Software Engineering" },
                    { "MCA-105", "Operating Systems with Linux" },
                    { "MCA-106", "Python Programming" },
                    { "MCA-107", "Database Management Systems" },
                    { "MCA-109", "Object Oriented Programming and JAVA" },
                    { "MCA-114", "Full Stack Development" },
                    { "MCA-120", "Software Testing" },
                    { "MCA-128", "Digital Marketing" },
                    { "MCA-161", "Computer Networks Lab." },
                    { "MCA-162", "Data and File Structures Lab" },
                    { "MCA-163", "Operating Systems with Linux Lab." },
                    { "MCA-164", "Object Oriented Software Engineering Lab" },
                    { "MCA-165", "Database Management Systems Lab." },
                    { "MCA-166", "Python Programming Lab" },
                    { "MCA-167", "Object Oriented Programming and JAVA Lab." },
                    { "MCA-169", "Minor Project I" },
                    { "MCA-170", "Minor Project II" },
                    { "MCA-201", "Design and Analysis of Algorithms" },
                    { "MCA-202", "Dissertation (Major Project)" },
                    { "MCA-203", "Artificial Intelligence and Machine Learning" },
                    { "MCA-205", "Statistics and Data Analytics" },
                    { "MCA-223", "Cloud Computing" },
                    { "MCA-225", "e-Business Systems" },
                    { "MCA-233", "Multimedia Technologies" },
                    { "MCA-253", "Cyber Security and Cyber Laws" },
                    { "MCA-261", "Design and Analysis of Algorithms Lab." },
                    { "MCA-263", "Artificial Intelligence and Machine Learning Lab." },
                    { "MCA-269", "Minor Project III" },
                    { "MTMCA-267", "Lab Multimedia Technologies" },
                    { "PO", "Program Outcome" },
                    { "StatsMCA-265", "Lab Statistics and Data Analytics" },
                    { "STMCA-168", "Software Testing Lab" }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QId", "Qtext", "SId" },
                values: new object[,]
                {
                    { "AIML1", "Are you able to Define the meaning of Intelligence and recall various models for knowledge representation and reasoning within an AI problem domain.", "MCA-203" },
                    { "AIML2", "Are you able to Summarize varied learning algorithms and model selection.", "MCA-203" },
                    { "AIML3", "Are you able to Apply the concept of learning trends and patterns from data to build an appreciation for what is involved in learning from data.", "MCA-203" },
                    { "AIML4", "Are you able to Analyze and apply a variety of learning algorithms to data.", "MCA-203" },
                    { "AIML5", "Are you able to Appraise AI algorithms and assess their performance. Follow standards and ethical practices.", "MCA-203" },
                    { "AIML6", "Are you able to Develop a strong foundation for a wide variety of state of the art Machine Learning algorithms.", "MCA-203" },
                    { "AIMLL1", "Are you able to Apply heuristic search based algorithms to solve different puzzles.", "MCA-263" },
                    { "AIMLL2", "Are you able to Identify reduction techniques on large datasets and reduce their dimensionality.", "MCA-263" },
                    { "AIMLL3", "Are you able to Analyze the datasets for bias and apply appropriate regression techniques.", "MCA-263" },
                    { "AIMLL4", "Are you able to Evaluate the learning techniques for classification.", "MCA-263" },
                    { "AIMLL5", "Are you able to Implement the knowledge of inferences rules to design the knowledge base.", "MCA-263" },
                    { "AIMLL6", "re you able to Create a domain specific intelligent application.", "MCA-263" },
                    { "CC1", "Are you able to Identify the importance of Cloud Computing Paradigm, Cloud Security primitives & Load Configurations.", "MCA-223" },
                    { "CC2", "Are you able to Model and apply the concepts of Virtualization and Security in the cloud computing environment.", "MCA-223" },
                    { "CC3", "Are you able to Analyze the concept of Data Centres with Cloud Computing and examine the Use cases of various Cloud Computing Titans.", "MCA-223" },
                    { "CC4", "Are you able to Design & Appraise Cloud Computing based VMS and weigh the advantages & disadvantages of various proprietary platforms along with available best practices.", "MCA-223" },
                    { "CCL1", "Are you able to Demonstrate the cloud platform on an appropriate tool.", "CCMCA-265" },
                    { "CCL2", "Are you able to Apply virtualization in clouds.", "CCMCA-265" },
                    { "CCL3", "Are you able to Distinguish between at least two cloud- based platforms.", "CCMCA-265" },
                    { "CCL4", "Are you able to Choose and implement best security practices of cloud.", "CCMCA-265" },
                    { "CCL5", "Are you able to Create automation on load balancing in cloud.", "CCMCA-265" },
                    { "CN1", "Are you able to Explain the functions of each layer in the OSI reference model and TCP/IP protocol suite while illustrating the process of data encoding and multiplexing.", "PO" },
                    { "CN2", "Are you able to Utilize the fundamentals of data communication and networking to identify the topologies and connecting devices of networks.", "PO" },
                    { "CN3", "Are you able to Identify and discuss the underlying concepts of IPv4 & IPv6 protocols, along with their characteristics and functionality.", "PO" },
                    { "CN4", "Are you able to Discover the appropriate MAC layer/ data link layer protocols for the given network.", "PO" },
                    { "CN5", "Are you able to Evaluate and implement routing algorithms and multicasting.", "PO" },
                    { "CN6", "Are you able to Adapt transport and application layer protocols along with concepts of mobility and security in networks.", "PO" },
                    { "CNL1", "Are you able to Interpret suitable Network Simulator", "MCA-161" },
                    { "CNL2", "Are you able to Apply network configuration skills to design specific network scenarios.", "MCA-161" },
                    { "CNL3", "Are you able to Make use of various connecting devices and LAN connectivity to build networks.", "MCA-161" },
                    { "CNL4", "Are you able to Simulate the working and analyze the performance of various communication protocols.", "MCA-161" },
                    { "CNL5", "Are you able to Evaluate routing in the networks and compare different routing algorithms", "MCA-161" },
                    { "CNL6", "Are you able to Work in teams to design networks for real life scenarios by applying the concepts of all the layered architecture.", "MCA-161" },
                    { "CSCL1", "Are you able to Demonstrate computer technologies, digital evidence collection, and reporting in forensic acquisition.", "MCA-253" },
                    { "CSCL2", "Are you able to Apply strategies of using information as a weapon and a target.", "MCA-253" },
                    { "CSCL3", "Are you able to Identify the principles of offensive and defensive information warfare for a given context.", "MCA-253" },
                    { "CSCL4", "Are you able to Analyze the social, legal and ethical implications of information warfare.", "MCA-253" },
                    { "CSCL5", "Are you able to Appraise key terms and concepts in cyber law, intellectual property and cyber crimes, trademarks, domain theft and Cyber Forensics.", "MCA-253" },
                    { "DAA1", "Are you able to Demonstrate P and NP complexity classes of the problem.", "MCA-201" },
                    { "DAA2", "Are you able to Apply the concepts of asymptotic notations to analyze the complexities of various algorithms.", "MCA-201" },
                    { "DAA3", "Are you able to Analyze and evaluate the searching, sorting and tree-based algorithms.", "MCA-201" },
                    { "DAA4", "Are you able to Design efficient solutions using various algorithms for given problems.", "MCA-201" },
                    { "DAA5", "Are you able to Develop innovative solutions for real-world problems using different paradigms.", "MCA-201" },
                    { "DAAL1", "Are you able to Apply logical thinking to build solutions for given problems.", "MCA-261" },
                    { "DAAL2", "Are you able to Evaluate correctness & efficiency of algorithms using inductive proofs and invariants.", "MCA-261" },
                    { "DAAL3", "Are you able to Design and perform parameter-based analysis of the searching, sorting and tree-based algorithms.", "MCA-261" },
                    { "DAAL4", "Are you able to Create and test optimal solutions for various problems.", "MCA-261" },
                    { "DBMS1", "Are you able to Explain the various database components, models, DBMS architecture and Database Security", "MCA-107" },
                    { "DBMS2", "Are you able to Apply relational database theory to construct relational algebra expression, tuple and domain relation expression for SQL queries.", "MCA-107" },
                    { "DBMS3", "Are you able to Construct advanced SQL queries on data and apply Procedural abilities through PL/SQL.", "MCA-107" },
                    { "DBMS4", "Are you able to Examine the use of normalization and functional dependency for database design.", "MCA-107" },
                    { "DBMS5", "Are you able to Appraise the concepts of transaction, concurrency control and recovery in databases.", "MCA-107" },
                    { "DBMSL1", "Are you able to Translate an information model into a relational database schema and to implement the schema using RDBMS", "MCA-165" },
                    { "DBMSL2", "Are you able to Apply advanced SQL features like views, indexes, synonyms, etc. for database management", "MCA-165" },
                    { "DBMSL3", "Are you able to Analyze PL/SQL structures like functions, procedures, cursors and triggers for database applications.", "MCA-165" },
                    { "DBMSL4", "Are you able to Examine database administration concepts like GRANT, REVOKE etc. through SQL commands.", "MCA-165" },
                    { "DBMSL5", "Are you able to Work in teams to design solutions for real world problems/case studies by creating efficient database schema.", "MCA-165" },
                    { "DFS1", "Are you able to recall the different types of data structures?", "MCA-102" },
                    { "DFS2", "Are you able to explain the fundamentals of an Abstract Data Type (ADT) ?", "MCA-102" },
                    { "DFS3", "Are you able to analyze requirements with use cases?", "MCA-102" },
                    { "DFS4", "Are you able to apply linear and nonlinear data structures to solve real time problems?", "MCA-102" },
                    { "DFS5", "Are you able to appraise and determine the correct data structure for any given real-world problem?", "MCA-102" },
                    { "DFS6", "Are you able to create innovative solutions for real world problems?", "MCA-102" },
                    { "DFSL1", "Are you able to illustrate basic data structures- arrays and linked lists?", "MCA-162" },
                    { "DFSL2", "Are you able to build stacks and queues using arrays and linked lists?", "MCA-162" },
                    { "DFSL3", "Are you able to discover sparse matrix, polynomial arithmetic, searching and sorting techniques and their applications?", "MCA-162" },
                    { "DFSL4", "Are you able to appraise binary search tree to perform efficient search operations ? ", "MCA-162" },
                    { "DFSL5", "Are you able to examine and implement graph algorithms?", "MCA-162" },
                    { "DFSL6", "Are you able to develop an application making extensive use of binary files?", "MCA-162" },
                    { "DM1", "Are you able to interpret digital marketing preliminaries?", "MCA-128" },
                    { "DM2", "Are you able to build effective digital marketing strategies for different products and services?	", "MCA-128" },
                    { "DM3", "Are you able to make appropriate use of varied Digital Marketing Platforms like Email, Facebook, Twitter, YouTube, Pinterest, etc as per given scenario?", "MCA-128" },
                    { "DM4", "Are you able to apply and analyze the concept of Search Engine Optimization (SEO), SEM and Mobile Marketing to given scenarios?", "MCA-128" },
                    { "DM5", "Are you able to analyze specific trends using Google Analytics?", "MCA-128" },
                    { "DM6", "Are you able to create effective Display Ads and Search Engine Advertising", "MCA-128" },
                    { "DMP1", "Are you able to Apply techniques, skills and modern computing tools necessary for project development.", "MCA-202" },
                    { "DMP2", "Are you able to Apply team-skills, ethics and professional attitude in professional endeavour.", "MCA-202" },
                    { "DMP3", "Are you able to Model overall project management through sustainable practices.", "MCA-202" },
                    { "DMP4", "Are you able to Adapt technological changes and futuristic challenges of the contemporary world.", "MCA-202" },
                    { "DMP5", "Are you able to Create technical documents and reports.", "MCA-202" },
                    { "DS1", "Are you able to Choose appropriate discrete structures and combinatorics for basic problems.", "MCA-101" },
                    { "DS2", "Are you able to Interpret and illustrate the basics of Group Theory.", "MCA-101" },
                    { "DS3", "Are you able to Examine and infer mathematical logic and Boolean Algebra.", "MCA-101" },
                    { "DS4", "Are you able to Evaluate applications of number theory.", "MCA-101" },
                    { "DS5", "Are you able to Implement and create models for computer science problems by understanding the concepts of Graph Theory", "MCA-101" },
                    { "EBS1", "Are you able to Define the concepts of e-business and e- commerce and the related information technology and web-based tools.", "MCA-225" },
                    { "EBS2", "Are you able to Identify Security aspects of e-business-online threats, security protocols and understand and apply cryptographic applications for securing the e-businesses and data privacy.", "MCA-225" },
                    { "EBS3", "Are you able to Examine various e-business models, revenue models, electronic payment systems and electronic fund transfers.", "MCA-225" },
                    { "EBS4", "Are you able to Create effective strategies for e-business, and mobile commerce while adapting to the emerging trends in e-business.", "MCA-225" },
                    { "EBSL1", "Are you able to Model an appropriate Business model for a proposed website", "EBMCA-265" },
                    { "EBSL2", "Are you able to Distinguish varied online payment methods", "EBMCA-265" },
                    { "EBSL3", "Are you able to Assess varied e-commerce software's", "EBMCA-265" },
                    { "EBSL4", "Are you able to Create an e-commerce website and compare it with similar existing websites", "EBMCA-265" },
                    { "FSD1", "Are you able to relate the basics of Javascript (JS) and ReactJS?", "MCA-114" },
                    { "FSD2", "Are you able to apply the concepts of props and State Management in React JS?", "MCA-114" },
                    { "FSD3", "Are you able to examine Redux and router with React JS?", "MCA-114" },
                    { "FSD4", "Are you able to appraise Node JS environment and modular development?", "MCA-114" },
                    { "FSD5", "Are you able to develop full stack applications using MongoDB?", "MCA-114" },
                    { "FSDL1", "Are you able to apply concepts of DOM creation and rendering using React.js?", "FSDMCA-168" },
                    { "FSDL2", "Are you able to make use of Node.js process model in given case studies?", "FSDMCA-168" },
                    { "FSDL3", "Are you able to construct REST APIs for cross platform application development?", "FSDMCA-168" },
                    { "FSDL4", "Are you able to create full stack applications using Angular.js and React. js?", "FSDMCA-168" },
                    { "FSDL5", "Are you able to work in teams to develop applications with Node.js and MongoDB connectivity?", "FSDMCA-168" },
                    { "MM1", "Are you able to Explain the technical aspects of multimedia systems.", "MCA-233" },
                    { "MM2", "Are you able to Apply various file formats of audio, video and text media in different applications.", "MCA-233" },
                    { "MM3", "Are you able to Analyze the QoS parameters of various multimedia applications through internet.", "MCA-233" },
                    { "MM4", "Are you able to Evaluate different types of multimedia compression methods.", "MCA-233" },
                    { "MM5", "Are you able to Design interactive multimedia software applications using animations.", "MCA-233" },
                    { "MM6", "Are you able to Develop real-time multimedia applications using different multimedia components.", "MCA-233" },
                    { "MML1", "Are you able to Demonstrate modelling of 2D and 3D graphical scenes using Open Graphics Library suits.", "MTMCA-267" },
                    { "MML2", "Are you able to Apply various delivery methods including streaming.", "MTMCA-267" },
                    { "MML3", "Are you able to Analyse audio and text compression algorithms.", "MTMCA-267" },
                    { "MML4", "Are you able to Examine video compression algorithms.", "MTMCA-267" },
                    { "MML5", "Are you able to Create 2D animation applications using appropriate multimedia tools.", "MTMCA-267" },
                    { "MML6", "Are you able to Develop customized multimedia projects using different components.", "MTMCA-267" },
                    { "MP11", "Are you able to Apply acquired knowledge within the chosen technology for solution of specific problem.", "MCA-169" },
                    { "MP12", "Are you able to Analyze the technical aspects of the chosen project through a systematic and comprehensive approach.", "MCA-169" },
                    { "MP13", "Are you able to Deduct plausible solution for the technical aspects of the project.", "MCA-169" },
                    { "MP14", "Are you able to Work as an individual or in teams to develop the technical project.", "MCA-169" },
                    { "MP15", "Are you able to Create effective reports and documentation for all project related activities and solutions.", "MCA-169" },
                    { "MP21", "Are you able to Apply acquired knowledge within the chosen technology for solution of specific real world problem.", "MCA-170" },
                    { "MP22", "Are you able to Analyze the technical aspects of the chosen project through a systematic and comprehensive approach.", "MCA-170" },
                    { "MP23", "Are you able to Deduct plausible solution for the technical aspects of the project.", "MCA-170" },
                    { "MP24", "Are you able to Work as an individual or in teams to develop the technical project.", "MCA-170" },
                    { "MP25", "Are you able to Create effective reports and documentation for all project related activities and solutions.", "MCA-170" },
                    { "MP31", "Are you able to Apply acquired knowledge within the chosen technology for solution of specific problem.", "MCA-269" },
                    { "MP32", "Are you able to Analyze the technical aspects of the chosen project through a systematic and comprehensive approach.", "MCA-269" },
                    { "MP33", "Are you able to Deduct plausible solution for the technical aspects of the project.", "MCA-269" },
                    { "MP34", "Are you able to Work as an individual or in teams to develop the technical project.", "MCA-269" },
                    { "MP35", "Are you able to Create effective reports and documentation for all project related activities and solutions.", "MCA-269" },
                    { "OOPJ1", "Are you able to Illustrate the Object-Oriented paradigm, Java language constructs and JVM internal architecture.", "MCA-109" },
                    { "OOPJ2", "Are you able to Apply the concepts of exception handling, multithreading, and collection framework.", "MCA-109" },
                    { "OOPJ3", "Are you able to Analyze the use of event handling and JFC based toolkit in creating GUI-based computing solutions.", "MCA-109" },
                    { "OOPJ4", "Are you able to Design database enabled client-server applications using JDBC, RMI, I/O operations, network programming and relevant concepts.", "MCA-109" },
                    { "OOPJ5", "Are you able to Elaborate the functional programming concepts introduced in Java 8 and beyond.", "MCA-109" },
                    { "OOPJL1", "Are you able to Apply Object-Oriented and Java language constructs for creating Java programs.", "MCA-167" },
                    { "OOPJL2", "Are you able to Make use of exception handling, multithreading, and collection framework for constructing effective solutions.", "MCA-167" },
                    { "OOPJL3", "Are you able to Inspect the use of event handling and JFC based toolkit for GUI-based computing solutions.", "MCA-167" },
                    { "OOPJL4", "Are you able to Design database enabled client-server applications using JDBC, RMI, I/O operations, network programming and relevant concepts.", "MCA-167" },
                    { "OOPJL5", "Are you able to Elaborate the functional programming concepts introduced in Java 8 and beyond.", "MCA-167" },
                    { "OOSE1", "Are you able to illustrate system modeling and architecture using UML?", "MCA-104" },
                    { "OOSE2", "Are you able to apply suitable iterative process model?", "MCA-104" },
                    { "OOSE3", "Are you able to analyze requirements with use cases?", "MCA-104" },
                    { "OOSE4", "Are you able to appraise, analysis and design artifacts?", "MCA-104" },
                    { "OOSE5", "Are you able to create domain models for analysis phase?", "MCA-104" },
                    { "OOSE6", "Are you able to design object solutions with patterns and architectural layers", "MCA-104" },
                    { "OOSEL1", "Are you able to apply object-oriented software engineering concepts to a project?", "MCA-164" },
                    { "OOSEL2", "Are you able to build design model diagrams for design phase?", "MCA-164" },
                    { "OOSEL3", "Are you able to analyze and construct models and diagrams in analysis phase?", "MCA-164" },
                    { "OOSEL4", "Are you able to appraise an advanced CASE tool?", "MCA-164" },
                    { "OOSEL5", "Are you able to design and deploy a project suitably?", "MCA-164" },
                    { "OOSEL6", "Are you able to work in teams to design practical solutions for real life case studies using UML?", "MCA-164" },
                    { "OS1", "Are you able to Explain the structure and functions of Operating Systems along with their components, types and working.", "MCA-105" },
                    { "OS2", "Are you able to Make use of appropriate Linux commands for Memory Management, File Management and Directory Management.", "MCA-105" },
                    { "OS3", "Are you able to Analyze the performance of different Scheduling algorithms along with the policies for Concurrency and Deadlock management.", "MCA-105" },
                    { "OS4", "Are you able to Elaborate the System Calls for Process management and File Management.", "MCA-105" },
                    { "OSL1", "Are you able to Build the Linux operating system and configure it.", "MCA-163" },
                    { "OSL2", "Are you able to Discover Linux commands for working with Linux Environment", "MCA-163" },
                    { "OSL3", "Are you able to Appraise the Process Management algorithms, Process Management system calls, Inter Process Communication and CPU Scheduling algorithms", "MCA-163" },
                    { "OSL4", "Are you able to Create programs using systems calls for memory management and File Management in C programming, also simulate Deadlock avoidance algorithm using C.", "MCA-163" },
                    { "PO1", "Demonstrate competencies in fundamentals of computing, computing specialization, mathematics and domain knowledge suitable for the computing specialization to the abstraction and conceptualization of computing models from defined problems and requirements.", "PO" },
                    { "PO10", "Ability to recognize and assess societal, environmental, health, safety, legal and cultural issues within local and global contexts and the consequential responsibilities applicable to professional computing practices.", "PO" },
                    { "PO11", "Ability to work in multi-disciplinary team collaboration both as a member and leader, as per need.", "PO" },
                    { "PO12", "Ability to apply innovation to track a suitable opportunity to create value and wealth for the betterment of the individual and society at large.", "PO" },
                    { "PO2", "Identify, formulate and analyze complex real-life problems in order to arrive at computationally viable conclusions using fundamentals of mathematics, computer sciences, management and relevant domain disciplines.", "PO" },
                    { "PO3", "Design efficient solutions for complex, real-world problems to design systems, components or processes that meet the specifications with suitable consideration to public health, safety, cultural, societal and environmental considerations.", "PO" },
                    { "PO4", "Ability to research, analyze and investigate complex computing problems through design of experiments, analysis and interpretation of data and synthesis of the information to arrive at valid conclusions.", "PO" },
                    { "PO5", "Create, select, adapt and apply appropriate technologies and tools to a wide range of computational activities while understanding their limitations", "PO" },
                    { "PO6", "Ability to perform professional practices in an ethical way, keeping in the mind cyber regulations & laws, responsibilities and norms of professional computing practices.", "PO" },
                    { "PO7", "Ability to engage in independent learning for continuous self- development as a computing professional.", "PO" },
                    { "PO8", "Ability to apply knowledge and understanding of the computing and management principles and apply these to one's own work, as a member and leader in a team, to manage projects in multidisciplinary environments.", "PO" },
                    { "PO9", "Ability to effectively communicate with the technical community and with the society at large about complex computing activities by being able to understand and write effective reports, design documentation, make effective presentations with the capability of giving and taking clear instructions.", "PO" },
                    { "PP1", "Are you able to demonstrate knowledge of basic programming constructs in python?", "MCA-106" },
                    { "PP2", "Are you able to illustrate string handling methods and user defined functions in python?", "MCA-106" },
                    { "PP3", "Are you able to apply data structure primitives like lists, tuples, sets and dictionaries?", "MCA-106" },
                    { "PP4", "Are you able to inspect file handling and object-oriented programming techniques?", "MCA-106" },
                    { "PP5", "Are you able to evaluate and visualize the data using appropriate python libraries?", "MCA-106" },
                    { "PP6", "Are you able to develop python applications with database connectivity operations?", "MCA-106" },
                    { "PPL1", "Are you able to demonstrate program creation in Python through usage of appropriate constructs and OOPs concepts?", "MCA-166" },
                    { "PPL2", "Are you able to apply the concepts of data structures and string functions in python program?", "MCA-166" },
                    { "PPL3", "Are you able to apply the concepts of file handling and exception handling?", "MCA-166" },
                    { "PPL4", "Are you able to evaluate and visualize the data using appropriate python libraries?", "MCA-166" },
                    { "PPL5", "Are you able to work in teams to develop GUI based applications with database connectivity in Python?", "MCA-166" },
                    { "SDA1", "Are you able to Explain fundamental concepts and terminologies of statistics and data analytics", "MCA-205" },
                    { "SDA2", "Are you able to Experiment with various measures of central tendency, dispersion, shape and their implication.", "MCA-205" },
                    { "SDA3", "Are you able to Apply probability and probability distribution primitives.", "MCA-205" },
                    { "SDA4", "Are you able to Examine hypothesis testing and use inferential statistics- T, F, Z and Chi Square Test", "MCA-205" },
                    { "SDA5", "Are you able to Assess analysis of variance for specific cases.", "MCA-205" },
                    { "SDAL1", "Are you able to Identify various measures like Central tendency, Measures of Dispersion, Measures of shape etc.", "StatsMCA-265" },
                    { "SDAL2", "Are you able to Analyze Probability Distribution on specific cases", "StatsMCA-265" },
                    { "SDAL3", "Are you able to Assess hypothesis testing and apply inferential statistics- t, F, Z and Chi Square Test to specific cases", "StatsMCA-265" },
                    { "SDAL4", "Are you able to Deduct Correlation and Regression on specific problems.", "StatsMCA-265" },
                    { "SDAL5", "Are you able to Elaborate Statistical and Data analytics techniques on real time data (case study).", "StatsMCA-265" },
                    { "SF1", "Are you able to identify the fundamentals of software testing and differentiate it from debugging?", "MCA-120" },
                    { "SF2", "Are you able to apply knowledge of prioritization, and technical and logical dependencies to schedule test execution of a given set of test cases during development and regression testing?", "MCA-120" },
                    { "SF3", "Are you able to appraise test tools, object-oriented software testing according to their purpose and the test activities they support?", "MCA-120" },
                    { "SF4", "Are you able to develop test cases for given problem with respect to structural and functional techniques?", "MCA-120" },
                    { "SF5", "Are you able to adapt in a cross-functional agile team to discuss principles and basic practices of Agile software development?", "MCA-120" },
                    { "STL1", "Are you able to plan and test driven development within the context of a software development application?", "STMCA-168" },
                    { "STL2", "Are you able to discover specific and measurable test cases and suites to ensure coverage and traceability to requirements through appropriate tools?", "STMCA-168" },
                    { "STL3", "Are you able to appraise and prioritize test cases for the specific software?", "STMCA-168" },
                    { "STL4", "Are you able to evaluate problem reporting techniques, metrics, and testing status reports to communicate testing results to colleagues, managers and end users?", "STMCA-168" },
                    { "STL5", "Are you able to work in teams to adapt in a team to design a live case study on a software product through appropriate agile methodology?", "STMCA-168" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_SId",
                table: "Question",
                column: "SId");

            migrationBuilder.CreateIndex(
                name: "IX_Response_SId",
                table: "Response",
                column: "SId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
