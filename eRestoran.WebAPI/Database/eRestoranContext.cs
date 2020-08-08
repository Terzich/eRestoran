﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eRestoran.WebAPI.Database
{
    public partial class eRestoranContext : DbContext
    {
        public eRestoranContext()
        {
        }

        public eRestoranContext(DbContextOptions<eRestoranContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<MenuItemsReview> MenuItemsReview { get; set; }
        public virtual DbSet<RecommendationType> RecommendationType { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<RestaurantMenuItem> RestaurantMenuItem { get; set; }
        public virtual DbSet<RestaurantReview> RestaurantReview { get; set; }
        public virtual DbSet<SuperOffer> SuperOffer { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
        public virtual DbSet<VisitorRecommendation> VisitorRecommendation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=eRestoran;Integrated Security=False;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityName).HasMaxLength(50);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Gender1)
                    .HasColumnName("Gender")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.ItemCategory)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ItemTypeId_FK");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<MenuItemsReview>(entity =>
            {
                entity.ToTable("MenuItems_Review");

                entity.Property(e => e.MenuItemsReviewId).HasColumnName("MenuItems_ReviewId");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RestaurantMenuItemId).HasColumnName("RestaurantMenu_ItemId");

                entity.HasOne(d => d.RestaurantMenuItem)
                    .WithMany(p => p.MenuItemsReview)
                    .HasForeignKey(d => d.RestaurantMenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RestaurantMenu_ItemId_FK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MenuItemsReview)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserId_FK");
            });

            modelBuilder.Entity<RecommendationType>(entity =>
            {
                entity.Property(e => e.RecommendationTypeDescription)
                    .HasColumnName("RecommendationType_Description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CloseAt).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(100);

                entity.Property(e => e.OpenAt).HasColumnType("datetime");

                entity.Property(e => e.RestaurantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CityId_Restaurant_FK");
            });

            modelBuilder.Entity<RestaurantMenuItem>(entity =>
            {
                entity.ToTable("RestaurantMenu_Item");

                entity.Property(e => e.RestaurantMenuItemId).HasColumnName("RestaurantMenu_ItemId");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.RestaurantMenuItem)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ItemCategoryId_FK");
            });

            modelBuilder.Entity<RestaurantReview>(entity =>
            {
                entity.ToTable("Restaurant_Review");

                entity.Property(e => e.RestaurantReviewId).HasColumnName("Restaurant_ReviewId");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RestaurantReview)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Restaurant_Review_UserId_FK");
            });

            modelBuilder.Entity<SuperOffer>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferEnd).HasColumnType("datetime");

                entity.Property(e => e.OfferStart).HasColumnType("datetime");

                entity.Property(e => e.RestaurantMenuItemId).HasColumnName("RestaurantMenu_ItemId");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.SuperOffer)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("ItemCategory_SuperOffer_FK");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.SuperOffer)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("ItemType_SuperOffer_FK");

                entity.HasOne(d => d.RestaurantMenuItem)
                    .WithMany(p => p.SuperOffer)
                    .HasForeignKey(d => d.RestaurantMenuItemId)
                    .HasConstraintName("RestaurantMenu_Item_SuperOffer_FK");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(30);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber).HasMaxLength(30);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CityId_FK");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GenderId_FK");
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.Property(e => e.DateOfVisit).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Visit_UserId_FK");
            });

            modelBuilder.Entity<VisitorRecommendation>(entity =>
            {
                entity.ToTable("Visitor_Recommendation");

                entity.Property(e => e.VisitorRecommendationId).HasColumnName("Visitor_RecommendationId");

                entity.Property(e => e.RecommendationDescription)
                    .HasColumnName("Recommendation_Description")
                    .HasMaxLength(100);

                entity.HasOne(d => d.RecommendationType)
                    .WithMany(p => p.VisitorRecommendation)
                    .HasForeignKey(d => d.RecommendationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RecommendationTypeId_FK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VisitorRecommendation)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Visitor_Recommendation_UserId_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
