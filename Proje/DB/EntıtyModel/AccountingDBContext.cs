using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DB.EntıtyModel
{
    public partial class AccountingDBContext : DbContext
    {
        public AccountingDBContext()
        {
        }

        public AccountingDBContext(DbContextOptions<AccountingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountControlTable> AccountControlTable { get; set; }
        public virtual DbSet<AccountHeadTable> AccountHeadTable { get; set; }
        public virtual DbSet<AccountSubControlTable> AccountSubControlTable { get; set; }
        public virtual DbSet<CategoryTable> CategoryTable { get; set; }
        public virtual DbSet<CustomerInvoiceDetailsTable> CustomerInvoiceDetailsTable { get; set; }
        public virtual DbSet<CustomerInvoiceTable> CustomerInvoiceTable { get; set; }
        public virtual DbSet<CustomerPaymentTable> CustomerPaymentTable { get; set; }
        public virtual DbSet<CustomerTable> CustomerTable { get; set; }
        public virtual DbSet<FinancialYearTable> FinancialYearTable { get; set; }
        public virtual DbSet<StockTable> StockTable { get; set; }
        public virtual DbSet<SupplierInvoiceDetailsTable> SupplierInvoiceDetailsTable { get; set; }
        public virtual DbSet<SupplierInvoiceTable> SupplierInvoiceTable { get; set; }
        public virtual DbSet<SupplierPaymentTable> SupplierPaymentTable { get; set; }
        public virtual DbSet<SupplierTable> SupplierTable { get; set; }
        public virtual DbSet<TransactionTable> TransactionTable { get; set; }
        public virtual DbSet<UserTypesTable> UserTypesTable { get; set; }
        public virtual DbSet<UsersTable> UsersTable { get; set; }
        public virtual DbSet<VAccountSubControlsList> VAccountSubControlsList { get; set; }
        public virtual DbSet<VAccountsControlList> VAccountsControlList { get; set; }
        public virtual DbSet<VHeadsList> VHeadsList { get; set; }
        public virtual DbSet<VProductList> VProductList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-FUT2P42\\MREMIN;Initial Catalog=AccountingDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountControlTable>(entity =>
            {
                entity.HasKey(e => e.AccountControlId);

                entity.Property(e => e.AccountControlId).HasColumnName("AccountControl_ID");

                entity.Property(e => e.AccountControlName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHeadId).HasColumnName("AccountHead_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.AccountHead)
                    .WithMany(p => p.AccountControlTable)
                    .HasForeignKey(d => d.AccountHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountControlTable_AccountHeadTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountControlTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountControlTable_UsersTable");
            });

            modelBuilder.Entity<AccountHeadTable>(entity =>
            {
                entity.HasKey(e => e.AccountHeadId);

                entity.Property(e => e.AccountHeadId).HasColumnName("AccountHeadID");

                entity.Property(e => e.AccountHeadName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountHeadTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountHeadTable_UsersTable");
            });

            modelBuilder.Entity<AccountSubControlTable>(entity =>
            {
                entity.HasKey(e => e.AccountSubControlD);

                entity.Property(e => e.AccountControlId).HasColumnName("AccountControl_ID");

                entity.Property(e => e.AccountHeadId).HasColumnName("AccountHead_ID");

                entity.Property(e => e.AccountSubControlName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.AccountControl)
                    .WithMany(p => p.AccountSubControlTable)
                    .HasForeignKey(d => d.AccountControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountSubControlTable_AccountControlTable");

                entity.HasOne(d => d.AccountHead)
                    .WithMany(p => p.AccountSubControlTable)
                    .HasForeignKey(d => d.AccountHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountSubControlTable_AccountHeadTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountSubControlTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountSubControlTable_UsersTable");
            });

            modelBuilder.Entity<CategoryTable>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerInvoiceDetailsTable>(entity =>
            {
                entity.HasKey(e => e.CustomerInvoiceDetailId);

                entity.Property(e => e.CustomerInvoiceDetailId).HasColumnName("CustomerInvoiceDetailID");

                entity.Property(e => e.CustomerInvoiceId).HasColumnName("CustomerInvoice_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.HasOne(d => d.CustomerInvoice)
                    .WithMany(p => p.CustomerInvoiceDetailsTable)
                    .HasForeignKey(d => d.CustomerInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerInvoiceDetailsTable_CustomerInvoiceTable");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerInvoiceDetailsTable)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerInvoiceDetailsTable_StockTable");
            });

            modelBuilder.Entity<CustomerInvoiceTable>(entity =>
            {
                entity.HasKey(e => e.CustomerInvoiceId)
                    .HasName("PK_CustomerInvoice");

                entity.Property(e => e.CustomerInvoiceId).HasColumnName("CustomerInvoiceID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerInvoiceTable)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerInvoiceTable_CustomerTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerInvoiceTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerInvoiceTable_UsersTable");
            });

            modelBuilder.Entity<CustomerPaymentTable>(entity =>
            {
                entity.HasKey(e => e.CustomerPaymenId);

                entity.Property(e => e.CustomerPaymenId).HasColumnName("CustomerPaymenID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerInvoiceId).HasColumnName("CustomerInvoice_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPaymentTable)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPaymentTable_CustomerTable");

                entity.HasOne(d => d.CustomerInvoice)
                    .WithMany(p => p.CustomerPaymentTable)
                    .HasForeignKey(d => d.CustomerInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPaymentTable_CustomerInvoiceTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerPaymentTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPaymentTable_UsersTable");
            });

            modelBuilder.Entity<CustomerTable>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialYearTable>(entity =>
            {
                entity.HasKey(e => e.FinancialYearId);

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FinancialYear)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<StockTable>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.MfturDate).HasColumnType("date");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockTrasholdQty).HasDefaultValueSql("((10))");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.StockTable)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTable_CategoryTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StockTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockTable_UsersTable");
            });

            modelBuilder.Entity<SupplierInvoiceDetailsTable>(entity =>
            {
                entity.HasKey(e => e.SupplierInvoiceDetailId);

                entity.Property(e => e.SupplierInvoiceDetailId).HasColumnName("SupplierInvoiceDetailID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoice_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SupplierInvoiceDetailsTable)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierInvoiceDetailsTable_StockTable");

                entity.HasOne(d => d.SupplierInvoice)
                    .WithMany(p => p.SupplierInvoiceDetailsTable)
                    .HasForeignKey(d => d.SupplierInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierInvoiceDetailsTable_SupplierInvoiceTable");
            });

            modelBuilder.Entity<SupplierInvoiceTable>(entity =>
            {
                entity.HasKey(e => e.SupplierInvoiceId);

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierInvoiceTable)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierInvoiceTable_SupplierTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SupplierInvoiceTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierInvoiceTable_UsersTable");
            });

            modelBuilder.Entity<SupplierPaymentTable>(entity =>
            {
                entity.HasKey(e => e.SupplierPaymentId);

                entity.Property(e => e.SupplierPaymentId).HasColumnName("SupplierPaymentID");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoice_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierPaymentTable)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierPaymentTable_SupplierTable");

                entity.HasOne(d => d.SupplierInvoice)
                    .WithMany(p => p.SupplierPaymentTable)
                    .HasForeignKey(d => d.SupplierInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierPaymentTable_SupplierInvoiceTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SupplierPaymentTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierPaymentTable_UsersTable");
            });

            modelBuilder.Entity<SupplierTable>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contactno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionTable>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.AccountControlId).HasColumnName("AccountControl_ID");

                entity.Property(e => e.AccountHeadId).HasColumnName("AccountHead_ID");

                entity.Property(e => e.AccountSubControlId).HasColumnName("AccountSubControl_ID");

                entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYear_ID");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.AccountControl)
                    .WithMany(p => p.TransactionTable)
                    .HasForeignKey(d => d.AccountControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionTable_AccountControlTable");

                entity.HasOne(d => d.AccountHead)
                    .WithMany(p => p.TransactionTable)
                    .HasForeignKey(d => d.AccountHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionTable_AccountHeadTable");

                entity.HasOne(d => d.AccountSubControl)
                    .WithMany(p => p.TransactionTable)
                    .HasForeignKey(d => d.AccountSubControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionTable_AccountSubControlTable");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.TransactionTable)
                    .HasForeignKey(d => d.FinancialYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionTable_FinancialYearTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TransactionTable)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionTable_UsersTable");
            });

            modelBuilder.Entity<UserTypesTable>(entity =>
            {
                entity.HasKey(e => e.UserTypeId);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserType_ID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UsersTable)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersTable_UserTypesTable");
            });

            modelBuilder.Entity<VAccountSubControlsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AccountSubControlsList");

                entity.Property(e => e.AccountControl)
                    .IsRequired()
                    .HasColumnName("Account Control")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountControlId).HasColumnName("AccountControl_ID");

                entity.Property(e => e.AccountHead)
                    .IsRequired()
                    .HasColumnName("Account Head")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHeadId).HasColumnName("AccountHead_ID");

                entity.Property(e => e.AccountSubControlName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAccountsControlList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AccountsControlList");

                entity.Property(e => e.AccountControl)
                    .IsRequired()
                    .HasColumnName("Account Control")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHead)
                    .IsRequired()
                    .HasColumnName("Account Head")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHeadId).HasColumnName("AccountHead_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHeadsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HeadsList");

                entity.Property(e => e.AccountHead)
                    .IsRequired()
                    .HasColumnName("Account Head")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<VProductList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProductList");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry Date")
                    .HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ManufacturDate)
                    .HasColumnName("Manufactur Date")
                    .HasColumnType("date");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseUnitPrice).HasColumnName("Purchase Unit Price");

                entity.Property(e => e.SaleUnitPrice).HasColumnName("Sale Unit Price");

                entity.Property(e => e.ThresholdQty).HasColumnName("Threshold Qty");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
