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
    [Migration("20240220130310_ApprovedByPpCsAdded")]
    partial class ApprovedByPpCsAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ContainerToolDB.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("longtext");

                    b.Property<int>("ArticleNumber")
                        .HasColumnType("int");

                    b.Property<int>("CsinquiryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DesiredDeliveryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Factory")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool?>("InquiryForFixedOrder")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("InquiryForQuotation")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDirectLine")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFastLine")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("MinHeigthRequired")
                        .HasColumnType("int");

                    b.Property<string>("Nozzle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Pallets")
                        .HasColumnType("int");

                    b.Property<string>("Planned")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductionOrder")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShortText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CsinquiryId" }, "IX_Conversations_OrderId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ContainerToolDBDb.ArticlesInDispatchRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AmountNeeded")
                        .HasColumnType("int");

                    b.Property<string>("Articlenumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("AskedDeal")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DispachDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DispachDateRequestId")
                        .HasColumnType("int");

                    b.Property<bool>("FixOrder")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("MinLotSize")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Neededby")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DispachDateRequestId" }, "IX_ArticlesInDispatchRequests_DispachDateRequestId");

                    b.ToTable("ArticlesInDispatchRequests");
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

                    b.Property<bool>("FreeDetention")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("GrossWeightInKg")
                        .HasColumnType("int")
                        .HasColumnName("GrossWeightInKG");

                    b.Property<string>("Incoterm")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("INCOTERM");

                    b.Property<string>("LoadingPlattform")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReadyToLoad")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Thctb")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("THCTb");

                    b.HasKey("Id");

                    b.ToTable("CSInquiries", (string)null);
                });

            modelBuilder.Entity("ContainerToolDBDb.DispachDateRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Annotation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WorkerId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DispachDateRequests");
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

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("ApprovedByCrCs")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ApprovedByCrTl")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("ApprovedByCsTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("ApprovedByPpCs")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("ApprovedByTlTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ChecklistId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Csid")
                        .HasColumnType("int")
                        .HasColumnName("CSId");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tlid")
                        .HasColumnType("int")
                        .HasColumnName("TLId");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Csid" }, "IX_Orders_CSId");

                    b.HasIndex(new[] { "ChecklistId" }, "IX_Orders_ChecklistId");

                    b.HasIndex(new[] { "Tlid" }, "IX_Orders_TLId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ContainerToolDBDb.PlanningSt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Annotation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WorkerId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PlanningSTS", (string)null);
                });

            modelBuilder.Entity("ContainerToolDBDb.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Plants");
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

            modelBuilder.Entity("ContainerToolDBDb.Stsarticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Jet")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Planinquiry")
                        .HasColumnType("int");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("Productioninquiry")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PlantId" }, "IX_STSArticles_PlantId");

                    b.ToTable("STSArticles", (string)null);
                });

            modelBuilder.Entity("ContainerToolDBDb.Tlinquiry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AcceptingPort")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Boat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DebtCapitalGeneralForerunEur")
                        .HasColumnType("int")
                        .HasColumnName("DebtCapitalGeneralForerunEUR");

                    b.Property<int>("DebtCapitalMainDol")
                        .HasColumnType("int")
                        .HasColumnName("DebtCapitalMainDOL");

                    b.Property<int>("DebtCapitalTrailingDol")
                        .HasColumnType("int")
                        .HasColumnName("DebtCapitalTrailingDOL");

                    b.Property<DateTime>("Eta")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ETA");

                    b.Property<DateTime>("Ets")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ETS");

                    b.Property<DateTime>("ExpectedRetrieveWeek")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InquiryNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsContainer40")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsContainerHc")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsContainerHC");

                    b.Property<string>("PortOfDeparture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RetrieveDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RetrieveLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sped")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WeightInKg")
                        .HasColumnType("int")
                        .HasColumnName("WeightInKG");

                    b.HasKey("Id");

                    b.ToTable("TLInquiries", (string)null);
                });

            modelBuilder.Entity("ContainerToolDB.Article", b =>
                {
                    b.HasOne("ContainerToolDBDb.Csinquiry", "Csinquiry")
                        .WithMany("Articles")
                        .HasForeignKey("CsinquiryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Csinquiry");
                });

            modelBuilder.Entity("ContainerToolDBDb.ArticlesInDispatchRequest", b =>
                {
                    b.HasOne("ContainerToolDBDb.DispachDateRequest", "DispachDateRequest")
                        .WithMany("ArticlesInDispatchRequests")
                        .HasForeignKey("DispachDateRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DispachDateRequest");
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
                        .HasForeignKey("ChecklistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContainerToolDBDb.Csinquiry", "Cs")
                        .WithMany("Orders")
                        .HasForeignKey("Csid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContainerToolDBDb.Tlinquiry", "Tl")
                        .WithMany("Orders")
                        .HasForeignKey("Tlid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Checklist");

                    b.Navigation("Cs");

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

            modelBuilder.Entity("ContainerToolDBDb.Stsarticle", b =>
                {
                    b.HasOne("ContainerToolDBDb.Plant", "Plant")
                        .WithMany("Stsarticles")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
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

            modelBuilder.Entity("ContainerToolDBDb.DispachDateRequest", b =>
                {
                    b.Navigation("ArticlesInDispatchRequests");
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

            modelBuilder.Entity("ContainerToolDBDb.Plant", b =>
                {
                    b.Navigation("Stsarticles");
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