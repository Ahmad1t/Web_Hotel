using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class HotelContext : DbContext
{
    public HotelContext()
    {
    }

    public HotelContext(DbContextOptions<HotelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employe> Employes { get; set; }

    public virtual DbSet<Floor> Floors { get; set; }

    public virtual DbSet<FloorRoom> FloorRooms { get; set; }

    public virtual DbSet<Manger> Mangers { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WorkingWith> WorkingWiths { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QOH5V7E\\SQLEXPRESS;Database=Hotel;Trusted_Connection=True; TrustServerCertificate = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.ToTable("Booking");

            entity.Property(e => e.BookingId).HasColumnName("Booking_ID");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.FloorRoomId).HasColumnName("FloorRoom_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_Active");
            entity.Property(e => e.NumberOfNight).HasColumnName("Number_Of_Night");
            entity.Property(e => e.StartingDate).HasColumnName("Starting_Date");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Booking_Customer");

            entity.HasOne(d => d.Emp).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_Booking_Employe");

            entity.HasOne(d => d.FloorRoom).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.FloorRoomId)
                .HasConstraintName("FK_Booking_FloorRoom");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CityName)
                .HasMaxLength(30)
                .HasColumnName("city_name");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(1)
                .HasColumnName("isActive");

            entity.HasOne(d => d.Country).WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_City_Country");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .HasColumnName("country_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.CustomerIdentityNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Customer_Identity_Number");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_Active");
            entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

            entity.HasOne(d => d.Nationality).WithMany(p => p.Customers)
                .HasForeignKey(d => d.NationalityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_nationality");
        });

        modelBuilder.Entity<Employe>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("Employe");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.EmpGander).HasColumnName("emp_gander");
            entity.Property(e => e.EmpLname)
                .HasMaxLength(25)
                .HasColumnName("emp_lname");
            entity.Property(e => e.EmpName)
                .HasMaxLength(25)
                .HasColumnName("emp_name");
            entity.Property(e => e.EmpPhonenumber)
                .HasMaxLength(20)
                .HasColumnName("emp_phonenumber");
            entity.Property(e => e.EmpSalary).HasColumnName("emp_salary");
            entity.Property(e => e.EmpStartDay).HasColumnName("emp_start_day");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_Active");
            entity.Property(e => e.NationalityId).HasColumnName("nationality_id");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.WorkingwithId).HasColumnName("Workingwith_ID");

            entity.HasOne(d => d.City).WithMany(p => p.Employes)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employe_City");

            entity.HasOne(d => d.Nationality).WithMany(p => p.Employes)
                .HasForeignKey(d => d.NationalityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employe_nationality");

            entity.HasOne(d => d.User).WithMany(p => p.Employes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employe_User");

            entity.HasOne(d => d.Workingwith).WithMany(p => p.Employes)
                .HasForeignKey(d => d.WorkingwithId)
                .HasConstraintName("FK_Employe_WorkingWith");
        });

        modelBuilder.Entity<Floor>(entity =>
        {
            entity.ToTable("Floor");

            entity.Property(e => e.FloorId).HasColumnName("Floor_ID");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_Number");
        });

        modelBuilder.Entity<FloorRoom>(entity =>
        {
            entity.ToTable("FloorRoom");

            entity.Property(e => e.FloorRoomId).HasColumnName("FloorRoom_ID");
            entity.Property(e => e.FloorId).HasColumnName("Floor_ID");
            entity.Property(e => e.RoomId).HasColumnName("Room_ID");

            entity.HasOne(d => d.Floor).WithMany(p => p.FloorRooms)
                .HasForeignKey(d => d.FloorId)
                .HasConstraintName("FK_FloorRoom_Floor");

            entity.HasOne(d => d.Room).WithMany(p => p.FloorRooms)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_FloorRoom_Room");
        });

        modelBuilder.Entity<Manger>(entity =>
        {
            entity.ToTable("Manger");

            entity.Property(e => e.MangerId).HasColumnName("Manger_ID");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");

            entity.HasOne(d => d.Emp).WithMany(p => p.Mangers)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manger_Employe");
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("nationality");

            entity.Property(e => e.NationalityId).HasColumnName("nationality_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.NationalityName)
                .HasMaxLength(50)
                .HasColumnName("nationality_name");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Payment_ID");
            entity.Property(e => e.BookingId).HasColumnName("Booking_ID");
            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethod_ID");

            entity.HasOne(d => d.Booking).WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Booking");

            entity.HasOne(d => d.Customer).WithMany(p => p.Payments)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Customer");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_PaymentMethod");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.ToTable("PaymentMethod");

            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethod_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_Active");
            entity.Property(e => e.PaymentMethodName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PaymentMethod_Name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("Role_Name");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.Property(e => e.RoomId).HasColumnName("Room_ID");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Room_Number");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("User_Name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("User_Password");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<WorkingWith>(entity =>
        {
            entity.ToTable("WorkingWith");

            entity.Property(e => e.WorkingwithId)
                .ValueGeneratedNever()
                .HasColumnName("Workingwith_ID");
            entity.Property(e => e.MangerId).HasColumnName("Manger_ID");

            entity.HasOne(d => d.Manger).WithMany(p => p.WorkingWiths)
                .HasForeignKey(d => d.MangerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkingWith_Manger");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
