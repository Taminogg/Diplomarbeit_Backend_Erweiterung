﻿// <auto-generated />
using System;
using ContainerToolDBDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContainerToolDB.Migrations
{
    [DbContext(typeof(ContainerToolDBContext))]
    [Migration("20240315173815_AddedThccToCsinquiry")]
    partial class AddedThccToCsinquiry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ArticlePP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArticleNumber")
                        .HasColumnType("int")
                        .HasColumnName("ArticleNumber");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeliveryDate");

                    b.Property<DateTime?>("DesiredDeliveryDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DesiredDeliveryDate");

                    b.Property<string>("Factory")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Factory");

                    b.Property<bool>("InquiryForFixedOrder")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("InquiryForFixedOrder");

                    b.Property<bool>("InquiryForNonFixedOrder")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("InquiryForQuotation")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("InquiryForQuotation");

                    b.Property<int>("MinHeigthRequired")
                        .HasColumnType("int")
                        .HasColumnName("MinHeightRequired");

                    b.Property<string>("Nozzle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nozzle");

                    b.Property<int>("Pallets")
                        .HasColumnType("int")
                        .HasColumnName("Pallets");

                    b.Property<string>("PlannedOrder")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PlannedOrder");

                    b.Property<string>("Plant")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductionOrder")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ProductionOrder");

                    b.Property<int>("ProductionPlanningId")
                        .HasColumnType("int")
                        .HasColumnName("ProductionPlanningId");

                    b.Property<int>("ProductionPlanningId1")
                        .HasColumnType("int");

                    b.Property<string>("ShortText")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ShortText");

                    b.HasKey("Id");

                    b.HasIndex("ProductionPlanningId");

                    b.HasIndex("ProductionPlanningId1");

                    b.ToTable("ArticlesPP", (string)null);
                });

            modelBuilder.Entity("ContainerToolDB.ArticleCR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArticleNumber")
                        .HasColumnType("int")
                        .HasColumnName("ArticleNumber");

                    b.Property<int>("CsinquiryId")
                        .HasColumnType("int")
                        .HasColumnName("CsinquiryId");

                    b.Property<int>("Pallets")
                        .HasColumnType("int")
                        .HasColumnName("Pallets");

                    b.HasKey("Id");

                    b.HasIndex("CsinquiryId");

                    b.ToTable("ArticlesCR", (string)null);
                });

            modelBuilder.Entity("ContainerToolDB.ProductionPlanning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<bool>("ApprovedByPpCs")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ApprovedByPPCS");

                    b.Property<DateTime?>("ApprovedByPpCsTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ApprovedByPPCSTime");

                    b.Property<bool>("ApprovedByPpPp")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ApprovedByPPPP");

                    b.Property<DateTime?>("ApprovedByPpPpTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ApprovedByPPPPTime");

                    b.Property<string>("CustomerPriority")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("RecievingCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ProductionPlannings", (string)null);
                });

            modelBuilder.Entity("ContainerToolDBDb.Checklist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Checklistname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("GeneratedByAdmin")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Checklists");
                });

            modelBuilder.Entity("ContainerToolDBDb.Csinquiry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Abnumber")
                        .HasColumnType("int")
                        .HasColumnName("ABNumber");

                    b.Property<bool>("ApprovedByCrCs")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("ApprovedByCrCsTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Container")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ContainersizeA")
                        .HasColumnType("int");

                    b.Property<int>("ContainersizeB")
                        .HasColumnType("int");

                    b.Property<int>("ContainersizeHc")
                        .HasColumnType("int")
                        .HasColumnName("ContainersizeHC");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FreeDetention")
                        .HasColumnType("int");

                    b.Property<int>("GrossWeightInKg")
                        .HasColumnType("int")
                        .HasColumnName("GrossWeightInKG");

                    b.Property<string>("Incoterm")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("INCOTERM");

                    b.Property<bool>("IsDirectLine")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFastLine")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LoadingPlattform")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReadyToLoad")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Thcc")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Thctb")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("THCTb");

                    b.HasKey("Id");

                    b.ToTable("CSInquiries", (string)null);
                });

            modelBuilder.Entity("ContainerToolDBDb.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ContainerToolDBDb.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AttachmentId" }, "IX_Messages_AttachmentId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ContainerToolDBDb.MessageConversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "OrderId" }, "IX_MessageConversations_ConversationId");

                    b.HasIndex(new[] { "MessageId" }, "IX_MessageConversations_MessageId");

                    b.ToTable("MessageConversations");
                });

            modelBuilder.Entity("ContainerToolDBDb.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("longtext");

                    b.Property<bool>("Canceled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ChecklistId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByCS")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBySD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CsId")
                        .HasColumnType("int")
                        .HasColumnName("CSId");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("FinishedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastUpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PpId")
                        .HasColumnType("int")
                        .HasColumnName("PpId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("SuccessfullyFinished")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("TlId")
                        .HasColumnType("int")
                        .HasColumnName("TLId");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CsId" }, "IX_Orders_CSId");

                    b.HasIndex(new[] { "ChecklistId" }, "IX_Orders_ChecklistId");

                    b.HasIndex(new[] { "PpId" }, "IX_Orders_PPId");

                    b.HasIndex(new[] { "TlId" }, "IX_Orders_TLId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ContainerToolDBDb.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StepDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StepName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StepNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("ContainerToolDBDb.StepChecklist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ChecklistId")
                        .HasColumnType("int");

                    b.Property<int>("StepId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ChecklistId" }, "IX_StepChecklists_ChecklistId");

                    b.HasIndex(new[] { "StepId" }, "IX_StepChecklists_StepId");

                    b.ToTable("StepChecklists");
                });

            modelBuilder.Entity("ContainerToolDBDb.Tlinquiry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AcceptingPort")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("AcceptingPort");

                    b.Property<bool>("ApprovedByCrTl")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ApprovedByCrTL");

                    b.Property<DateTime?>("ApprovedByCrTlTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ApprovedByCrTLTime");

                    b.Property<string>("Boat")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Boat");

                    b.Property<DateTime?>("Eta")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ETA");

                    b.Property<DateTime?>("Ets")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ETS");

                    b.Property<DateTime?>("ExpectedRetrieveWeek")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ExpectedRetrieveWeek");

                    b.Property<DateTime?>("InvoiceOn")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("InvoiceOn");

                    b.Property<string>("PortOfDeparture")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PortOfDeparture");

                    b.Property<DateTime?>("RetrieveDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("RetrieveDate");

                    b.Property<string>("RetrieveLocation")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("RetrieveLocation");

                    b.Property<int>("SCGeneral")
                        .HasColumnType("int")
                        .HasColumnName("SCGeneral");

                    b.Property<int>("SCMainRun")
                        .HasColumnType("int")
                        .HasColumnName("SCMainRun");

                    b.Property<int>("SCTrail")
                        .HasColumnType("int")
                        .HasColumnName("SCTrail");

                    b.Property<string>("Sped")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Sped");

                    b.HasKey("Id");

                    b.ToTable("Tlinquiries", (string)null);
                });

            modelBuilder.Entity("ArticlePP", b =>
                {
                    b.HasOne("ContainerToolDB.ProductionPlanning", null)
                        .WithMany("Articles")
                        .HasForeignKey("ProductionPlanningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContainerToolDB.ProductionPlanning", "ProductionPlanning")
                        .WithMany()
                        .HasForeignKey("ProductionPlanningId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductionPlanning");
                });

            modelBuilder.Entity("ContainerToolDB.ArticleCR", b =>
                {
                    b.HasOne("ContainerToolDBDb.Csinquiry", "Csinquiry")
                        .WithMany("Articles")
                        .HasForeignKey("CsinquiryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Csinquiry");
                });

            modelBuilder.Entity("ContainerToolDBDb.Message", b =>
                {
                    b.HasOne("ContainerToolDBDb.File", "Attachment")
                        .WithMany("Messages")
                        .HasForeignKey("AttachmentId");

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("ContainerToolDBDb.MessageConversation", b =>
                {
                    b.HasOne("ContainerToolDBDb.Message", "Message")
                        .WithMany("MessageConversations")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContainerToolDBDb.Order", "Order")
                        .WithMany("MessageConversations")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ContainerToolDBDb.Order", b =>
                {
                    b.HasOne("ContainerToolDBDb.Checklist", "Checklist")
                        .WithMany("Orders")
                        .HasForeignKey("ChecklistId");

                    b.HasOne("ContainerToolDBDb.Csinquiry", "Cs")
                        .WithMany("Orders")
                        .HasForeignKey("CsId");

                    b.HasOne("ContainerToolDB.ProductionPlanning", "ProductionPlanning")
                        .WithMany("Orders")
                        .HasForeignKey("PpId");

                    b.HasOne("ContainerToolDBDb.Tlinquiry", "Tl")
                        .WithMany("Orders")
                        .HasForeignKey("TlId");

                    b.Navigation("Checklist");

                    b.Navigation("Cs");

                    b.Navigation("ProductionPlanning");

                    b.Navigation("Tl");
                });

            modelBuilder.Entity("ContainerToolDBDb.StepChecklist", b =>
                {
                    b.HasOne("ContainerToolDBDb.Checklist", "Checklist")
                        .WithMany("StepChecklists")
                        .HasForeignKey("ChecklistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContainerToolDBDb.Step", "Step")
                        .WithMany("StepChecklists")
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Checklist");

                    b.Navigation("Step");
                });

            modelBuilder.Entity("ContainerToolDB.ProductionPlanning", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ContainerToolDBDb.Checklist", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("StepChecklists");
                });

            modelBuilder.Entity("ContainerToolDBDb.Csinquiry", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ContainerToolDBDb.File", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ContainerToolDBDb.Message", b =>
                {
                    b.Navigation("MessageConversations");
                });

            modelBuilder.Entity("ContainerToolDBDb.Order", b =>
                {
                    b.Navigation("MessageConversations");
                });

            modelBuilder.Entity("ContainerToolDBDb.Step", b =>
                {
                    b.Navigation("StepChecklists");
                });

            modelBuilder.Entity("ContainerToolDBDb.Tlinquiry", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
