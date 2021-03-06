// <auto-generated />
using System;
using Faculty_Information_System_Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Faculty_Information_System_Application.Migrations
{
    [DbContext(typeof(FacultyInformationSystemContext))]
    partial class FacultyInformationSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Adminstrator", b =>
                {
                    b.Property<int>("AdminstratorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminstratorID");

                    b.HasIndex("UserId");

                    b.ToTable("Adminstrators");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCredits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeptIdDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("DeptIdDepartmentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.CourseSubject", b =>
                {
                    b.Property<int>("CourseSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("CourseSubjectId");

                    b.HasIndex("CourseId");

                    b.HasIndex("SubjectID");

                    b.ToTable("CourseSubjects");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.CourseTaught", b =>
                {
                    b.Property<int>("CourseTaughtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstDateTaught")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("CourseTaughtId");

                    b.HasIndex("CourseId");

                    b.HasIndex("FacultyId");

                    b.HasIndex("SubjectID");

                    b.ToTable("CourseTaughts");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DegreeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DegreeYear")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DegreeId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesignationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignationId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Dob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FacultyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("UserId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Grant", b =>
                {
                    b.Property<int>("GrantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("GrantDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrantId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Grants");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Publication", b =>
                {
                    b.Property<int>("PublicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CitationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublicationId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.WorkHistory", b =>
                {
                    b.Property<int>("WorkHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JobBeginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("JobEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobResponsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organisation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkHistoryId");

                    b.HasIndex("FacultyId");

                    b.ToTable("WorkHistories");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Adminstrator", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.User", "UserID")
                        .WithMany("Adminstrators")
                        .HasForeignKey("UserId");

                    b.Navigation("UserID");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Course", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Department", "DeptId")
                        .WithMany("Courses")
                        .HasForeignKey("DeptIdDepartmentId");

                    b.Navigation("DeptId");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.CourseSubject", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Course", "Course")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("CourseId");

                    b.HasOne("Faculty_Information_System_Application.Data.Subject", "Subject")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("SubjectID");

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.CourseTaught", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Course", "Course")
                        .WithMany("CourseTaughts")
                        .HasForeignKey("CourseId");

                    b.HasOne("Faculty_Information_System_Application.Data.Faculty", "Faculty")
                        .WithMany("CourseTaughts")
                        .HasForeignKey("FacultyId");

                    b.HasOne("Faculty_Information_System_Application.Data.Subject", "Subject")
                        .WithMany("CourseTaughts")
                        .HasForeignKey("SubjectID");

                    b.Navigation("Course");

                    b.Navigation("Faculty");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Degree", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Faculty", "Faculty")
                        .WithMany("Degrees")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Faculty", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Department", "Department")
                        .WithMany("Faculties")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Faculty_Information_System_Application.Data.Designation", "Designation")
                        .WithMany("Faculties")
                        .HasForeignKey("DesignationId");

                    b.HasOne("Faculty_Information_System_Application.Data.User", "User")
                        .WithMany("Faculties")
                        .HasForeignKey("UserId");

                    b.Navigation("Department");

                    b.Navigation("Designation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Grant", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Faculty", "Faculty")
                        .WithMany("Grants")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Publication", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Faculty", "Faculty")
                        .WithMany("Publications")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.WorkHistory", b =>
                {
                    b.HasOne("Faculty_Information_System_Application.Data.Faculty", "Faculty")
                        .WithMany("WorkHistories")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Course", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("CourseTaughts");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Designation", b =>
                {
                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Faculty", b =>
                {
                    b.Navigation("CourseTaughts");

                    b.Navigation("Degrees");

                    b.Navigation("Grants");

                    b.Navigation("Publications");

                    b.Navigation("WorkHistories");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.Subject", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("CourseTaughts");
                });

            modelBuilder.Entity("Faculty_Information_System_Application.Data.User", b =>
                {
                    b.Navigation("Adminstrators");

                    b.Navigation("Faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
