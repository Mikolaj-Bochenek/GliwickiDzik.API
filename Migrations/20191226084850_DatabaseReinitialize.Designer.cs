﻿// <auto-generated />
using System;
using GliwickiDzik.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GliwickiDzik.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191226084850_DatabaseReinitialize")]
    partial class DatabaseReinitialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("GliwickiDzik.API.DTOs.ExerciseForTrainingForReturnDTO", b =>
                {
                    b.Property<int>("ExerciseForTrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Reps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sets")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TrainingModelTrainingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExerciseForTrainingId");

                    b.HasIndex("TrainingModelTrainingId");

                    b.ToTable("ExerciseForTrainingForReturnDTO");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.CommentModel", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CommentDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommenterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("LikeCounter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("CommenterId");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("CommentModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.ExerciseForTrainingModel", b =>
                {
                    b.Property<int>("ExerciseForTrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Reps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sets")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExerciseForTrainingId");

                    b.HasIndex("TrainingId");

                    b.ToTable("ExerciseForTrainingModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.ExerciseModel", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ExerciseId");

                    b.ToTable("ExerciseModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.LikeModel", b =>
                {
                    b.Property<int>("UserIdLikesPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlanIdIsLikedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommentModelCommentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LikeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlanIsLikedTrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserLikesUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserIdLikesPlanId", "PlanIdIsLikedByUserId");

                    b.HasIndex("CommentModelCommentId");

                    b.HasIndex("PlanIsLikedTrainingPlanId");

                    b.HasIndex("UserLikesUserId");

                    b.ToTable("LikeModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.MessageModel", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataRead")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipientId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("MessageModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.PhotoModel", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PhotoId");

                    b.HasIndex("UserId");

                    b.ToTable("PhotoModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.TrainingModel", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TrainingPlanModelTrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrainingId");

                    b.HasIndex("TrainingPlanModelTrainingPlanId");

                    b.ToTable("TrainingModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.TrainingPlanModel", b =>
                {
                    b.Property<int>("TrainingPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommentCounter")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Level")
                        .HasColumnType("TEXT");

                    b.Property<int>("LikeCounter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrainingPlanId");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingPlanModel");
                });

            modelBuilder.Entity("GliwickiDzik.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("BicepsSize")
                        .HasColumnType("REAL");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<float>("Growth")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("UserId");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("GliwickiDzik.API.DTOs.ExerciseForTrainingForReturnDTO", b =>
                {
                    b.HasOne("GliwickiDzik.API.Models.TrainingModel", null)
                        .WithMany("ExercisesForTraining")
                        .HasForeignKey("TrainingModelTrainingId");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.CommentModel", b =>
                {
                    b.HasOne("GliwickiDzik.Models.UserModel", "Commenter")
                        .WithMany()
                        .HasForeignKey("CommenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GliwickiDzik.API.Models.TrainingPlanModel", "TrainingPlan")
                        .WithMany("Comments")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.ExerciseForTrainingModel", b =>
                {
                    b.HasOne("GliwickiDzik.API.Models.TrainingModel", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.LikeModel", b =>
                {
                    b.HasOne("GliwickiDzik.API.Models.CommentModel", null)
                        .WithMany("Likes")
                        .HasForeignKey("CommentModelCommentId");

                    b.HasOne("GliwickiDzik.API.Models.TrainingPlanModel", "PlanIsLiked")
                        .WithMany("Likes")
                        .HasForeignKey("PlanIsLikedTrainingPlanId");

                    b.HasOne("GliwickiDzik.Models.UserModel", "UserLikes")
                        .WithMany()
                        .HasForeignKey("UserLikesUserId");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.MessageModel", b =>
                {
                    b.HasOne("GliwickiDzik.Models.UserModel", "Recipient")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GliwickiDzik.Models.UserModel", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.PhotoModel", b =>
                {
                    b.HasOne("GliwickiDzik.Models.UserModel", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.TrainingModel", b =>
                {
                    b.HasOne("GliwickiDzik.API.Models.TrainingPlanModel", "TrainingPlanModel")
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingPlanModelTrainingPlanId");
                });

            modelBuilder.Entity("GliwickiDzik.API.Models.TrainingPlanModel", b =>
                {
                    b.HasOne("GliwickiDzik.Models.UserModel", "User")
                        .WithMany("TrainingPlans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}