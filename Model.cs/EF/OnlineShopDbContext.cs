namespace Model.cs.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext5")
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<admin_Employee> admin_Employee { get; set; }
        public virtual DbSet<admin_Login> admin_Login { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<genMainSlider> genMainSliders { get; set; }
        public virtual DbSet<genPromoRight> genPromoRights { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RecentlyView> RecentlyViews { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ShippingDetail> ShippingDetails { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User1> User1 { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.Metatitle)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Employee>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<admin_Login>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.SubCategories)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Organization)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AltEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mobile1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mobile2)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Picture)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.RecentlyViews)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genMainSlider>()
                .Property(e => e.ImageURL)
                .IsUnicode(false);

            modelBuilder.Entity<genMainSlider>()
                .Property(e => e.AltText)
                .IsUnicode(false);

            modelBuilder.Entity<genMainSlider>()
                .Property(e => e.OfferTag)
                .IsUnicode(false);

            modelBuilder.Entity<genMainSlider>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<genMainSlider>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<genMainSlider>()
                .Property(e => e.BtnText)
                .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
               .Property(e => e.ImageURL)
               .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.AltText)
                .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.OfferTag)
                .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Discount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.DebitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => e.Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.QuantityPerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.OldPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitWeight)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Discount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ImageURL)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.AltText)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.OfferTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.OfferBadgeClass)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.LongDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Picture3)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Picture4)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.RecentlyViews)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Wishlists)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecentlyView>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.Review1)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.admin_Login)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.RoleType);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingDetail>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.SubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.ContactTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User1>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User1>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User1>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User1>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
