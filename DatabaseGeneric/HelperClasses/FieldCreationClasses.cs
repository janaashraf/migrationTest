﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace test.HelperClasses
{
	/// <summary>Field Creation Class for entity CourseEntity</summary>
	public partial class CourseFields
	{
		/// <summary>Creates a new CourseEntity.Description field instance</summary>
		public static EntityField2 Description { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CourseFieldIndex.Description); }}
		/// <summary>Creates a new CourseEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CourseFieldIndex.Id); }}
		/// <summary>Creates a new CourseEntity.InstructorId field instance</summary>
		public static EntityField2 InstructorId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CourseFieldIndex.InstructorId); }}
		/// <summary>Creates a new CourseEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CourseFieldIndex.Name); }}
	}

	/// <summary>Field Creation Class for entity EnrollmentEntity</summary>
	public partial class EnrollmentFields
	{
		/// <summary>Creates a new EnrollmentEntity.CourseId field instance</summary>
		public static EntityField2 CourseId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EnrollmentFieldIndex.CourseId); }}
		/// <summary>Creates a new EnrollmentEntity.EnrollmentDate field instance</summary>
		public static EntityField2 EnrollmentDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EnrollmentFieldIndex.EnrollmentDate); }}
		/// <summary>Creates a new EnrollmentEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EnrollmentFieldIndex.Id); }}
		/// <summary>Creates a new EnrollmentEntity.StudentId field instance</summary>
		public static EntityField2 StudentId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EnrollmentFieldIndex.StudentId); }}
	}

	/// <summary>Field Creation Class for entity InstructorEntity</summary>
	public partial class InstructorFields
	{
		/// <summary>Creates a new InstructorEntity.Email field instance</summary>
		public static EntityField2 Email { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(InstructorFieldIndex.Email); }}
		/// <summary>Creates a new InstructorEntity.FirstName field instance</summary>
		public static EntityField2 FirstName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(InstructorFieldIndex.FirstName); }}
		/// <summary>Creates a new InstructorEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(InstructorFieldIndex.Id); }}
		/// <summary>Creates a new InstructorEntity.LastName field instance</summary>
		public static EntityField2 LastName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(InstructorFieldIndex.LastName); }}
		/// <summary>Creates a new InstructorEntity.OfficeLocation field instance</summary>
		public static EntityField2 OfficeLocation { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(InstructorFieldIndex.OfficeLocation); }}
		/// <summary>Creates a new InstructorEntity.Phone field instance</summary>
		public static EntityField2 Phone { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(InstructorFieldIndex.Phone); }}
	}

	/// <summary>Field Creation Class for entity StudentEntity</summary>
	public partial class StudentFields
	{
		/// <summary>Creates a new StudentEntity.DateOfBirth field instance</summary>
		public static EntityField2 DateOfBirth { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(StudentFieldIndex.DateOfBirth); }}
		/// <summary>Creates a new StudentEntity.Email field instance</summary>
		public static EntityField2 Email { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(StudentFieldIndex.Email); }}
		/// <summary>Creates a new StudentEntity.FirstName field instance</summary>
		public static EntityField2 FirstName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(StudentFieldIndex.FirstName); }}
		/// <summary>Creates a new StudentEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(StudentFieldIndex.Id); }}
		/// <summary>Creates a new StudentEntity.LastName field instance</summary>
		public static EntityField2 LastName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(StudentFieldIndex.LastName); }}
		/// <summary>Creates a new StudentEntity.Phone field instance</summary>
		public static EntityField2 Phone { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(StudentFieldIndex.Phone); }}
	}
	

}