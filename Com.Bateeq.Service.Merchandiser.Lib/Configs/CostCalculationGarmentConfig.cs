﻿using Com.Bateeq.Service.Merchandiser.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Com.Bateeq.Service.Merchandiser.Lib.Configs
{
    public class CostCalculationGarmentConfig : IEntityTypeConfiguration<CostCalculationGarment>
    {
        public void Configure(EntityTypeBuilder<CostCalculationGarment> builder)
        {
            builder.Property(c => c.Code).HasMaxLength(100);
            builder.Property(c => c.RO).HasMaxLength(100);
            builder.Property(c => c.Article).HasMaxLength(500);
            builder.Property(c => c.ConvectionId).HasMaxLength(100);
            builder.Ignore(c => c.ConvectionCode);
            builder.Property(c => c.ConvectionName).HasMaxLength(500);
            builder.Property(c => c.Commodity).HasMaxLength(500);
            builder.Property(c => c.Section).HasMaxLength(500);
            builder.Property(c => c.SizeRangeName).HasMaxLength(500);
            builder.Property(c => c.BuyerName).HasMaxLength(500);
            builder.Property(c => c.Description).HasMaxLength(3000);
            builder
                .HasMany(c => c.CostCalculationGarment_Materials)
                .WithOne(cm => cm.CostCalculationGarment)
                .HasForeignKey(cm => cm.CostCalculationGarmentId)
                .IsRequired();
        }
    }
}