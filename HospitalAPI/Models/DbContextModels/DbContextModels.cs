using HospitalAPI.Models.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.DbContextModels
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<HospitalContact> HospitalContacts { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Addmission> Addmissions { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<MedicineReport> MedicineReports { get; set; }
        public virtual DbSet<PrescribedMed> PrescribedMeds { get; set; }
        public virtual DbSet<MedicalTest> MedicalTests { get; set; }
        public virtual DbSet<Lab> Labs { get; set; }
        public virtual DbSet<PatientReport> PatientReports { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Payroll> Payrolls { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
    }
}
