﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using test.HelperClasses;
using test.FactoryClasses;
using test.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace test.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Enrollment'.<br/><br/></summary>
	[Serializable]
	public partial class EnrollmentEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private CourseEntity _course;
		private StudentEntity _student;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static EnrollmentEntityStaticMetaData _staticMetaData = new EnrollmentEntityStaticMetaData();
		private static EnrollmentRelations _relationsFactory = new EnrollmentRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Course</summary>
			public static readonly string Course = "Course";
			/// <summary>Member name Student</summary>
			public static readonly string Student = "Student";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class EnrollmentEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public EnrollmentEntityStaticMetaData()
			{
				SetEntityCoreInfo("EnrollmentEntity", InheritanceHierarchyType.None, false, (int)test.EntityType.EnrollmentEntity, typeof(EnrollmentEntity), typeof(EnrollmentEntityFactory), false);
				AddNavigatorMetaData<EnrollmentEntity, CourseEntity>("Course", "Enrollments", (a, b) => a._course = b, a => a._course, (a, b) => a.Course = b, test.RelationClasses.StaticEnrollmentRelations.CourseEntityUsingCourseIdStatic, ()=>new EnrollmentRelations().CourseEntityUsingCourseId, null, new int[] { (int)EnrollmentFieldIndex.CourseId }, null, true, (int)test.EntityType.CourseEntity);
				AddNavigatorMetaData<EnrollmentEntity, StudentEntity>("Student", "Enrollments", (a, b) => a._student = b, a => a._student, (a, b) => a.Student = b, test.RelationClasses.StaticEnrollmentRelations.StudentEntityUsingStudentIdStatic, ()=>new EnrollmentRelations().StudentEntityUsingStudentId, null, new int[] { (int)EnrollmentFieldIndex.StudentId }, null, true, (int)test.EntityType.StudentEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static EnrollmentEntity()
		{
		}

		/// <summary> CTor</summary>
		public EnrollmentEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EnrollmentEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EnrollmentEntity</param>
		public EnrollmentEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Enrollment which data should be fetched into this Enrollment object</param>
		public EnrollmentEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Enrollment which data should be fetched into this Enrollment object</param>
		/// <param name="validator">The custom validator object for this EnrollmentEntity</param>
		public EnrollmentEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EnrollmentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Course' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCourse() { return CreateRelationInfoForNavigator("Course"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Student' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStudent() { return CreateRelationInfoForNavigator("Student"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this EnrollmentEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static EnrollmentRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Course' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCourse { get { return _staticMetaData.GetPrefetchPathElement("Course", CommonEntityBase.CreateEntityCollection<CourseEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Student' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStudent { get { return _staticMetaData.GetPrefetchPathElement("Student", CommonEntityBase.CreateEntityCollection<StudentEntity>()); } }

		/// <summary>The CourseId property of the Entity Enrollment<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Enrollment"."CourseId".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CourseId
		{
			get { return (System.Int32)GetValue((int)EnrollmentFieldIndex.CourseId, true); }
			set	{ SetValue((int)EnrollmentFieldIndex.CourseId, value); }
		}

		/// <summary>The EnrollmentDate property of the Entity Enrollment<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Enrollment"."EnrollmentDate".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EnrollmentDate
		{
			get { return (System.DateTime)GetValue((int)EnrollmentFieldIndex.EnrollmentDate, true); }
			set	{ SetValue((int)EnrollmentFieldIndex.EnrollmentDate, value); }
		}

		/// <summary>The Id property of the Entity Enrollment<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Enrollment"."Id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)EnrollmentFieldIndex.Id, true); }
			set	{ SetValue((int)EnrollmentFieldIndex.Id, value); }
		}

		/// <summary>The StudentId property of the Entity Enrollment<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Enrollment"."StudentId".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StudentId
		{
			get { return (System.Int32)GetValue((int)EnrollmentFieldIndex.StudentId, true); }
			set	{ SetValue((int)EnrollmentFieldIndex.StudentId, value); }
		}

		/// <summary>Gets / sets related entity of type 'CourseEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CourseEntity Course
		{
			get { return _course; }
			set { SetSingleRelatedEntityNavigator(value, "Course"); }
		}

		/// <summary>Gets / sets related entity of type 'StudentEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StudentEntity Student
		{
			get { return _student; }
			set { SetSingleRelatedEntityNavigator(value, "Student"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace test
{
	public enum EnrollmentFieldIndex
	{
		///<summary>CourseId. </summary>
		CourseId,
		///<summary>EnrollmentDate. </summary>
		EnrollmentDate,
		///<summary>Id. </summary>
		Id,
		///<summary>StudentId. </summary>
		StudentId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace test.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Enrollment. </summary>
	public partial class EnrollmentRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between EnrollmentEntity and CourseEntity over the m:1 relation they have, using the relation between the fields: Enrollment.CourseId - Course.Id</summary>
		public virtual IEntityRelation CourseEntityUsingCourseId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Course", false, new[] { CourseFields.Id, EnrollmentFields.CourseId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EnrollmentEntity and StudentEntity over the m:1 relation they have, using the relation between the fields: Enrollment.StudentId - Student.Id</summary>
		public virtual IEntityRelation StudentEntityUsingStudentId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Student", false, new[] { StudentFields.Id, EnrollmentFields.StudentId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEnrollmentRelations
	{
		internal static readonly IEntityRelation CourseEntityUsingCourseIdStatic = new EnrollmentRelations().CourseEntityUsingCourseId;
		internal static readonly IEntityRelation StudentEntityUsingStudentIdStatic = new EnrollmentRelations().StudentEntityUsingStudentId;

		/// <summary>CTor</summary>
		static StaticEnrollmentRelations() { }
	}
}
