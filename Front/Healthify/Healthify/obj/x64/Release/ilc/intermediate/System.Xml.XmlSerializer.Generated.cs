namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write83_thing(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"thing", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write79_RecordItem(@"thing", namespace1, ((global::HealthVault.Types.RecordItem)o), true, false, namespace1, @"");
        }

        public void Write84_ItemData(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ItemData", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write75_ItemData(@"ItemData", namespace2, ((global::HealthVault.Types.ItemData)o), true, false, namespace2, @"");
        }

        public void Write85_RecordQueryResponse(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"RecordQueryResponse", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write82_RecordQueryResponse(@"RecordQueryResponse", namespace3, ((global::HealthVault.Types.RecordQueryResponse)o), true, false, namespace3, @"");
        }

        public void Write86_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace4, ((global::System.Object)o), true, false, namespace4, @"");
        }

        public void Write87_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace5, ((global::System.Object)o), true, false, namespace5, @"");
        }

        void Write1_Object(string n, string ns, global::System.Object o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Object)) {
                }
                else if (t == typeof(global::HealthVault.Types.RecordQueryResponse)) {
                    Write82_RecordQueryResponse(n, ns,(global::HealthVault.Types.RecordQueryResponse)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemQueryResult)) {
                    Write81_ItemQueryResult(n, ns,(global::HealthVault.Types.ItemQueryResult)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.PendingItem)) {
                    Write80_PendingItem(n, ns,(global::HealthVault.Types.PendingItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.RecordItem)) {
                    Write79_RecordItem(n, ns,(global::HealthVault.Types.RecordItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemDataBlob)) {
                    Write78_ItemDataBlob(n, ns,(global::HealthVault.Types.ItemDataBlob)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Blob)) {
                    Write77_Blob(n, ns,(global::HealthVault.Types.Blob)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.BlobInfo)) {
                    Write76_BlobInfo(n, ns,(global::HealthVault.Types.BlobInfo)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemData)) {
                    Write75_ItemData(n, ns,(global::HealthVault.Types.ItemData)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemDataCommon)) {
                    Write74_ItemDataCommon(n, ns,(global::HealthVault.Types.ItemDataCommon)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.RelatedItem)) {
                    Write73_RelatedItem(n, ns,(global::HealthVault.Types.RelatedItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemExtension)) {
                    Write72_ItemExtension(n, ns,(global::HealthVault.Types.ItemExtension)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.MealDefinition)) {
                    Write71_MealDefinition(n, ns,(global::HealthVault.ItemTypes.MealDefinition)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.DietaryIntakeItem)) {
                    Write70_DietaryIntakeItem(n, ns,(global::HealthVault.Types.DietaryIntakeItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Weight)) {
                    Write69_Weight(n, ns,(global::HealthVault.ItemTypes.Weight)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Procedure)) {
                    Write68_Procedure(n, ns,(global::HealthVault.ItemTypes.Procedure)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.PersonalImage)) {
                    Write67_PersonalImage(n, ns,(global::HealthVault.ItemTypes.PersonalImage)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Personal)) {
                    Write66_Personal(n, ns,(global::HealthVault.ItemTypes.Personal)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Medication)) {
                    Write65_Medication(n, ns,(global::HealthVault.ItemTypes.Medication)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Prescription)) {
                    Write64_Prescription(n, ns,(global::HealthVault.Types.Prescription)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.PositiveInt)) {
                    Write63_PositiveInt(n, ns,(global::HealthVault.Types.PositiveInt)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ApproxMeasurement)) {
                    Write62_ApproxMeasurement(n, ns,(global::HealthVault.Types.ApproxMeasurement)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Insurance)) {
                    Write61_Insurance(n, ns,(global::HealthVault.ItemTypes.Insurance)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Immunization)) {
                    Write60_Immunization(n, ns,(global::HealthVault.ItemTypes.Immunization)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ApproxDate)) {
                    Write59_ApproxDate(n, ns,(global::HealthVault.Types.ApproxDate)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Height)) {
                    Write58_Height(n, ns,(global::HealthVault.ItemTypes.Height)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.HealthGoal)) {
                    Write57_HealthGoal(n, ns,(global::HealthVault.ItemTypes.HealthGoal)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.GoalRecurrence)) {
                    Write56_GoalRecurrence(n, ns,(global::HealthVault.Types.GoalRecurrence)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.GoalRange)) {
                    Write55_GoalRange(n, ns,(global::HealthVault.Types.GoalRange)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.GoalAssociatedTypeInfo)) {
                    Write54_GoalAssociatedTypeInfo(n, ns,(global::HealthVault.Types.GoalAssociatedTypeInfo)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.File)) {
                    Write53_File(n, ns,(global::HealthVault.ItemTypes.File)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Exercise)) {
                    Write52_Exercise(n, ns,(global::HealthVault.ItemTypes.Exercise)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ExerciseSegment)) {
                    Write51_ExerciseSegment(n, ns,(global::HealthVault.Types.ExerciseSegment)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.StructuredNameValue)) {
                    Write50_StructuredNameValue(n, ns,(global::HealthVault.Types.StructuredNameValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.LengthMeasurement)) {
                    Write49_LengthMeasurement(n, ns,(global::HealthVault.Types.LengthMeasurement)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.DietaryIntake)) {
                    Write48_DietaryIntake(n, ns,(global::HealthVault.ItemTypes.DietaryIntake)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.NutritionFact)) {
                    Write47_NutritionFact(n, ns,(global::HealthVault.Types.NutritionFact)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.GeneralMeasurement)) {
                    Write46_GeneralMeasurement(n, ns,(global::HealthVault.Types.GeneralMeasurement)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.StructuredMeasurement)) {
                    Write45_StructuredMeasurement(n, ns,(global::HealthVault.Types.StructuredMeasurement)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.WeightMeasurement)) {
                    Write44_WeightMeasurement(n, ns,(global::HealthVault.Types.WeightMeasurement)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.FoodEnergyValue)) {
                    Write43_FoodEnergyValue(n, ns,(global::HealthVault.Types.FoodEnergyValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Contact)) {
                    Write42_Contact(n, ns,(global::HealthVault.ItemTypes.Contact)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Condition)) {
                    Write41_Condition(n, ns,(global::HealthVault.ItemTypes.Condition)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Cholesterol)) {
                    Write40_Cholesterol(n, ns,(global::HealthVault.ItemTypes.Cholesterol)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ConcentrationValue)) {
                    Write39_ConcentrationValue(n, ns,(global::HealthVault.Types.ConcentrationValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.NonNegativeDouble)) {
                    Write38_NonNegativeDouble(n, ns,(global::HealthVault.Types.NonNegativeDouble)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.BloodPressure)) {
                    Write37_BloodPressure(n, ns,(global::HealthVault.ItemTypes.BloodPressure)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.NonNegativeInt)) {
                    Write36_NonNegativeInt(n, ns,(global::HealthVault.Types.NonNegativeInt)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.BloodGlucose)) {
                    Write35_BloodGlucose(n, ns,(global::HealthVault.ItemTypes.BloodGlucose)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.OneToFive)) {
                    Write34_OneToFive(n, ns,(global::HealthVault.Types.OneToFive)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.BloodGlucoseMeasurement)) {
                    Write33_BloodGlucoseMeasurement(n, ns,(global::HealthVault.Types.BloodGlucoseMeasurement)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.DisplayValue)) {
                    Write32_DisplayValue(n, ns,(global::HealthVault.Types.DisplayValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.PositiveDouble)) {
                    Write31_PositiveDouble(n, ns,(global::HealthVault.Types.PositiveDouble)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.BasicV2)) {
                    Write30_BasicV2(n, ns,(global::HealthVault.ItemTypes.BasicV2)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Language)) {
                    Write29_Language(n, ns,(global::HealthVault.Types.Language)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.DayOfWeek)) {
                    Write28_DayOfWeek(n, ns,(global::HealthVault.Types.DayOfWeek)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.ItemTypes.Allergy)) {
                    Write27_Allergy(n, ns,(global::HealthVault.ItemTypes.Allergy)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Person)) {
                    Write26_Person(n, ns,(global::HealthVault.Types.Person)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Contact)) {
                    Write25_Contact(n, ns,(global::HealthVault.Types.Contact)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Email)) {
                    Write24_Email(n, ns,(global::HealthVault.Types.Email)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.EmailAddress)) {
                    Write23_EmailAddress(n, ns,(global::HealthVault.Types.EmailAddress)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Phone)) {
                    Write22_Phone(n, ns,(global::HealthVault.Types.Phone)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Address)) {
                    Write21_Address(n, ns,(global::HealthVault.Types.Address)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.BooleanValue)) {
                    Write20_BooleanValue(n, ns,(global::HealthVault.Types.BooleanValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Name)) {
                    Write19_Name(n, ns,(global::HealthVault.Types.Name)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ApproxDateTime)) {
                    Write18_ApproxDateTime(n, ns,(global::HealthVault.Types.ApproxDateTime)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Audit)) {
                    Write17_Audit(n, ns,(global::HealthVault.Types.Audit)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.StructuredDateTime)) {
                    Write16_StructuredDateTime(n, ns,(global::HealthVault.Types.StructuredDateTime)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.CodableValue)) {
                    Write15_CodableValue(n, ns,(global::HealthVault.Types.CodableValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.CodedValue)) {
                    Write14_CodedValue(n, ns,(global::HealthVault.Types.CodedValue)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Time)) {
                    Write13_Time(n, ns,(global::HealthVault.Types.Time)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Millisecond)) {
                    Write12_Millisecond(n, ns,(global::HealthVault.Types.Millisecond)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Second)) {
                    Write11_Second(n, ns,(global::HealthVault.Types.Second)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Minute)) {
                    Write10_Minute(n, ns,(global::HealthVault.Types.Minute)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Hour)) {
                    Write9_Hour(n, ns,(global::HealthVault.Types.Hour)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Date)) {
                    Write8_Date(n, ns,(global::HealthVault.Types.Date)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Day)) {
                    Write7_Day(n, ns,(global::HealthVault.Types.Day)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Month)) {
                    Write6_Month(n, ns,(global::HealthVault.Types.Month)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.Year)) {
                    Write5_Year(n, ns,(global::HealthVault.Types.Year)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.DateTime)) {
                    Write4_DateTime(n, ns,(global::HealthVault.Types.DateTime)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemType)) {
                    Write3_ItemType(n, ns,(global::HealthVault.Types.ItemType)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.ItemKey)) {
                    Write2_ItemKey(n, ns,(global::HealthVault.Types.ItemKey)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.NutritionFact[])) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfNutritionFact", @"");
                    {
                        global::HealthVault.Types.NutritionFact[] a = (global::HealthVault.Types.NutritionFact[])o;
                        if (a != null) {
                            for (int ia = 0; ia < a.Length; ia++) {
                                string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write47_NutritionFact(@"nutrition-fact", namespace6, ((global::HealthVault.Types.NutritionFact)a[ia]), true, false, namespace6, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::HealthVault.Types.DietaryIntakeItem[])) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfDietaryIntakeItem", @"");
                    {
                        global::HealthVault.Types.DietaryIntakeItem[] a = (global::HealthVault.Types.DietaryIntakeItem[])o;
                        if (a != null) {
                            for (int ia = 0; ia < a.Length; ia++) {
                                string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write70_DietaryIntakeItem(@"dietary-item", namespace7, ((global::HealthVault.Types.DietaryIntakeItem)a[ia]), true, false, namespace7, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else {
                    WriteTypedPrimitive(n, ns, o, true);
                    return;
                }
            }
            WriteStartElement(n, ns, o, false, null);
            WriteEndElement(o);
        }

        void Write70_DietaryIntakeItem(string n, string ns, global::HealthVault.Types.DietaryIntakeItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.DietaryIntakeItem)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DietaryIntakeItem", defaultNamespace);
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"food-item", namespace8, ((global::HealthVault.Types.CodableValue)o.@FoodItem), false, false, namespace8, @"");
            string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"serving-size", namespace9, ((global::HealthVault.Types.CodableValue)o.@ServingSize), false, false, namespace9, @"");
            string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write38_NonNegativeDouble(@"servings-consumed", namespace10, ((global::HealthVault.Types.NonNegativeDouble)o.@ServingsConsumed), false, false, namespace10, @"");
            string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"meal", namespace11, ((global::HealthVault.Types.CodableValue)o.@Meal), false, false, namespace11, @"");
            string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace12, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace12, @"");
            string namespace13 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write43_FoodEnergyValue(@"energy", namespace13, ((global::HealthVault.Types.FoodEnergyValue)o.@Calories), false, false, namespace13, @"");
            string namespace14 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write43_FoodEnergyValue(@"energy-from-fat", namespace14, ((global::HealthVault.Types.FoodEnergyValue)o.@CaloriesFromFat), false, false, namespace14, @"");
            string namespace15 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"total-fat", namespace15, ((global::HealthVault.Types.WeightMeasurement)o.@TotalFat), false, false, namespace15, @"");
            string namespace16 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"saturated-fat", namespace16, ((global::HealthVault.Types.WeightMeasurement)o.@SaturatedFat), false, false, namespace16, @"");
            string namespace17 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"trans-fat", namespace17, ((global::HealthVault.Types.WeightMeasurement)o.@TransFat), false, false, namespace17, @"");
            string namespace18 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"monounsaturated-fat", namespace18, ((global::HealthVault.Types.WeightMeasurement)o.@MonounsaturatedFat), false, false, namespace18, @"");
            string namespace19 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"polyunsaturated-fat", namespace19, ((global::HealthVault.Types.WeightMeasurement)o.@PolyunsaturatedFat), false, false, namespace19, @"");
            string namespace20 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"protein", namespace20, ((global::HealthVault.Types.WeightMeasurement)o.@Protein), false, false, namespace20, @"");
            string namespace21 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"carbohydrates", namespace21, ((global::HealthVault.Types.WeightMeasurement)o.@Carbohydrates), false, false, namespace21, @"");
            string namespace22 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"dietary-fiber", namespace22, ((global::HealthVault.Types.WeightMeasurement)o.@Fiber), false, false, namespace22, @"");
            string namespace23 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"sugars", namespace23, ((global::HealthVault.Types.WeightMeasurement)o.@Sugars), false, false, namespace23, @"");
            string namespace24 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"sodium", namespace24, ((global::HealthVault.Types.WeightMeasurement)o.@Sodium), false, false, namespace24, @"");
            string namespace25 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"cholesterol", namespace25, ((global::HealthVault.Types.WeightMeasurement)o.@Cholesterol), false, false, namespace25, @"");
            string namespace26 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"calcium", namespace26, ((global::HealthVault.Types.WeightMeasurement)o.@Calcium), false, false, namespace26, @"");
            string namespace27 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"iron", namespace27, ((global::HealthVault.Types.WeightMeasurement)o.@Iron), false, false, namespace27, @"");
            string namespace28 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"magnesium", namespace28, ((global::HealthVault.Types.WeightMeasurement)o.@Magnesium), false, false, namespace28, @"");
            string namespace29 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"phosphorus", namespace29, ((global::HealthVault.Types.WeightMeasurement)o.@Phosphorus), false, false, namespace29, @"");
            string namespace30 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"potassium", namespace30, ((global::HealthVault.Types.WeightMeasurement)o.@Potassium), false, false, namespace30, @"");
            string namespace31 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"zinc", namespace31, ((global::HealthVault.Types.WeightMeasurement)o.@Zinc), false, false, namespace31, @"");
            string namespace32 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-A-RAE", namespace32, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminA), false, false, namespace32, @"");
            string namespace33 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-E", namespace33, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminE), false, false, namespace33, @"");
            string namespace34 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-D", namespace34, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminD), false, false, namespace34, @"");
            string namespace35 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-C", namespace35, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminC), false, false, namespace35, @"");
            string namespace36 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"thiamin", namespace36, ((global::HealthVault.Types.WeightMeasurement)o.@Thiamin), false, false, namespace36, @"");
            string namespace37 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"riboflavin", namespace37, ((global::HealthVault.Types.WeightMeasurement)o.@Riboflavin), false, false, namespace37, @"");
            string namespace38 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"niacin", namespace38, ((global::HealthVault.Types.WeightMeasurement)o.@Niacin), false, false, namespace38, @"");
            string namespace39 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-B-6", namespace39, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminB6), false, false, namespace39, @"");
            string namespace40 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"folate-DFE", namespace40, ((global::HealthVault.Types.WeightMeasurement)o.@Folate), false, false, namespace40, @"");
            string namespace41 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-B-12", namespace41, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminB12), false, false, namespace41, @"");
            string namespace42 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-K", namespace42, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminK), false, false, namespace42, @"");
            string namespace43 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::HealthVault.Types.NutritionFact[] a = (global::HealthVault.Types.NutritionFact[])((global::HealthVault.Types.NutritionFact[])o.@AdditionalNutritionFacts);
                if (a != null){
                    WriteStartElement(@"additional-nutrition-facts", namespace43, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace44 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write47_NutritionFact(@"nutrition-fact", namespace44, ((global::HealthVault.Types.NutritionFact)a[ia]), true, false, namespace44, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write47_NutritionFact(string n, string ns, global::HealthVault.Types.NutritionFact o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.NutritionFact)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"NutritionFact", defaultNamespace);
            string namespace45 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace45, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace45, @"");
            string namespace46 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write46_GeneralMeasurement(@"fact", namespace46, ((global::HealthVault.Types.GeneralMeasurement)o.@Fact), false, false, namespace46, @"");
            WriteEndElement(o);
        }

        void Write46_GeneralMeasurement(string n, string ns, global::HealthVault.Types.GeneralMeasurement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.GeneralMeasurement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GeneralMeasurement", defaultNamespace);
            if (o.@ShouldSerializeDisplay()) {
                string namespace47 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"display", namespace47, ((global::System.String)o.@Display));
            }
            {
                global::HealthVault.Types.StructuredMeasurement[] a = (global::HealthVault.Types.StructuredMeasurement[])o.@Structured;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace48 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write45_StructuredMeasurement(@"structured", namespace48, ((global::HealthVault.Types.StructuredMeasurement)a[ia]), false, false, namespace48, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write45_StructuredMeasurement(string n, string ns, global::HealthVault.Types.StructuredMeasurement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.StructuredMeasurement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"StructuredMeasurement", defaultNamespace);
            string namespace49 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"value", namespace49, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Value)));
            string namespace50 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"units", namespace50, ((global::HealthVault.Types.CodableValue)o.@Units), false, false, namespace50, @"");
            WriteEndElement(o);
        }

        void Write15_CodableValue(string n, string ns, global::HealthVault.Types.CodableValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.CodableValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CodableValue", defaultNamespace);
            if (o.@ShouldSerializeText()) {
                string namespace51 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"text", namespace51, ((global::System.String)o.@Text));
            }
            {
                global::HealthVault.Types.CodedValueCollection a = (global::HealthVault.Types.CodedValueCollection)o.@Codes;
                if (a != null) {
                    System.Collections.IEnumerator e = a.@GetEnumerator();
                    if (e != null)
                    while (e.MoveNext()) {
                        global::HealthVault.Types.CodedValue ai = (global::HealthVault.Types.CodedValue)e.Current;
                        string namespace52 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write14_CodedValue(@"code", namespace52, ((global::HealthVault.Types.CodedValue)ai), false, false, namespace52, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write14_CodedValue(string n, string ns, global::HealthVault.Types.CodedValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.CodedValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CodedValue", defaultNamespace);
            if (o.@ShouldSerializeCode()) {
                string namespace53 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"value", namespace53, ((global::System.String)o.@Code));
            }
            if (o.@ShouldSerializeVocabFamily()) {
                string namespace54 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"family", namespace54, ((global::System.String)o.@VocabFamily));
            }
            if (o.@ShouldSerializeVocabName()) {
                string namespace55 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"type", namespace55, ((global::System.String)o.@VocabName));
            }
            if (o.@ShouldSerializeVocabVersion()) {
                string namespace56 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"version", namespace56, ((global::System.String)o.@VocabVersion));
            }
            WriteEndElement(o);
        }

        void Write44_WeightMeasurement(string n, string ns, global::HealthVault.Types.WeightMeasurement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.WeightMeasurement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"WeightMeasurement", defaultNamespace);
            string namespace57 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_PositiveDouble(@"kg", namespace57, ((global::HealthVault.Types.PositiveDouble)o.@Value), false, false, namespace57, @"");
            string namespace58 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_DisplayValue(@"display", namespace58, ((global::HealthVault.Types.DisplayValue)o.@DisplayValue), false, false, namespace58, @"");
            WriteEndElement(o);
        }

        void Write32_DisplayValue(string n, string ns, global::HealthVault.Types.DisplayValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.DisplayValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DisplayValue", defaultNamespace);
            if (o.@ShouldSerializeUnits()) {
                WriteAttribute(@"units", @"", ((global::System.String)o.@Units));
            }
            if (o.@ShouldSerializeCode()) {
                WriteAttribute(@"units-code", @"", ((global::System.String)o.@Code));
            }
            if (o.@ShouldSerializeText()) {
                WriteAttribute(@"text", @"", ((global::System.String)o.@Text));
            }
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write31_PositiveDouble(string n, string ns, global::HealthVault.Types.PositiveDouble o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.PositiveDouble)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PositiveDouble", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write43_FoodEnergyValue(string n, string ns, global::HealthVault.Types.FoodEnergyValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.FoodEnergyValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"FoodEnergyValue", defaultNamespace);
            string namespace59 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write38_NonNegativeDouble(@"calories", namespace59, ((global::HealthVault.Types.NonNegativeDouble)o.@Calories), false, false, namespace59, @"");
            string namespace60 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_DisplayValue(@"display", namespace60, ((global::HealthVault.Types.DisplayValue)o.@Display), false, false, namespace60, @"");
            WriteEndElement(o);
        }

        void Write38_NonNegativeDouble(string n, string ns, global::HealthVault.Types.NonNegativeDouble o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.NonNegativeDouble)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"NonNegativeDouble", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write16_StructuredDateTime(string n, string ns, global::HealthVault.Types.StructuredDateTime o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.StructuredDateTime)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"StructuredDateTime", defaultNamespace);
            string namespace61 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write8_Date(@"date", namespace61, ((global::HealthVault.Types.Date)o.@Date), false, false, namespace61, @"");
            string namespace62 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write13_Time(@"time", namespace62, ((global::HealthVault.Types.Time)o.@Time), false, false, namespace62, @"");
            string namespace63 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"tz", namespace63, ((global::HealthVault.Types.CodableValue)o.@Timezone), false, false, namespace63, @"");
            WriteEndElement(o);
        }

        void Write13_Time(string n, string ns, global::HealthVault.Types.Time o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Time)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Time", defaultNamespace);
            string namespace64 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write9_Hour(@"h", namespace64, ((global::HealthVault.Types.Hour)o.@Hour), false, false, namespace64, @"");
            string namespace65 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write10_Minute(@"m", namespace65, ((global::HealthVault.Types.Minute)o.@Minute), false, false, namespace65, @"");
            string namespace66 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write11_Second(@"s", namespace66, ((global::HealthVault.Types.Second)o.@Second), false, false, namespace66, @"");
            string namespace67 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write12_Millisecond(@"f", namespace67, ((global::HealthVault.Types.Millisecond)o.@Millisecond), false, false, namespace67, @"");
            WriteEndElement(o);
        }

        void Write12_Millisecond(string n, string ns, global::HealthVault.Types.Millisecond o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Millisecond)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Millisecond", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write11_Second(string n, string ns, global::HealthVault.Types.Second o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Second)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Second", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write10_Minute(string n, string ns, global::HealthVault.Types.Minute o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Minute)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Minute", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write9_Hour(string n, string ns, global::HealthVault.Types.Hour o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Hour)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Hour", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write8_Date(string n, string ns, global::HealthVault.Types.Date o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Date)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Date", defaultNamespace);
            string namespace68 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write5_Year(@"y", namespace68, ((global::HealthVault.Types.Year)o.@Year), false, false, namespace68, @"");
            string namespace69 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write6_Month(@"m", namespace69, ((global::HealthVault.Types.Month)o.@Month), false, false, namespace69, @"");
            string namespace70 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write7_Day(@"d", namespace70, ((global::HealthVault.Types.Day)o.@Day), false, false, namespace70, @"");
            WriteEndElement(o);
        }

        void Write7_Day(string n, string ns, global::HealthVault.Types.Day o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Day)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Day", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write6_Month(string n, string ns, global::HealthVault.Types.Month o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Month)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Month", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write5_Year(string n, string ns, global::HealthVault.Types.Year o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Year)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Year", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write2_ItemKey(string n, string ns, global::HealthVault.Types.ItemKey o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemKey)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"thing-id", defaultNamespace);
            if (o.@ShouldSerializeVersion()) {
                WriteAttribute(@"version-stamp", @"", ((global::System.String)o.@Version));
            }
            if (o.@ShouldSerializeID()) {
                if ((object)(o.@ID) != null){
                    WriteValue(((global::System.String)o.@ID));
                }
            }
            WriteEndElement(o);
        }

        void Write3_ItemType(string n, string ns, global::HealthVault.Types.ItemType o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ItemType", defaultNamespace);
            if (o.@ShouldSerializeName()) {
                WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            }
            if (o.@ShouldSerializeID()) {
                if ((object)(o.@ID) != null){
                    WriteValue(((global::System.String)o.@ID));
                }
            }
            WriteEndElement(o);
        }

        void Write4_DateTime(string n, string ns, global::HealthVault.Types.DateTime o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.DateTime)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DateTime", defaultNamespace);
            if ((object)(o.@TextValue) != null){
                WriteValue(((global::System.String)o.@TextValue));
            }
            WriteEndElement(o);
        }

        void Write17_Audit(string n, string ns, global::HealthVault.Types.Audit o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Audit)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Audit", defaultNamespace);
            string namespace71 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"timestamp", namespace71, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace71, @"");
            if (o.@ShouldSerializeAppID()) {
                string namespace72 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"app-id", namespace72, ((global::System.String)o.@AppID));
            }
            if (o.@ShouldSerializeAction()) {
                string namespace73 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"audit-action", namespace73, ((global::System.String)o.@Action));
            }
            WriteEndElement(o);
        }

        void Write18_ApproxDateTime(string n, string ns, global::HealthVault.Types.ApproxDateTime o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ApproxDateTime)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ApproxDateTime", defaultNamespace);
            if (o.@ShouldSerializeDescription()) {
                string namespace74 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"descriptive", namespace74, ((global::System.String)o.@Description));
            }
            string namespace75 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"structured", namespace75, ((global::HealthVault.Types.StructuredDateTime)o.@DateTime), false, false, namespace75, @"");
            WriteEndElement(o);
        }

        void Write19_Name(string n, string ns, global::HealthVault.Types.Name o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Name)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Name", defaultNamespace);
            if (o.@ShouldSerializeFull()) {
                string namespace76 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"full", namespace76, ((global::System.String)o.@Full));
            }
            string namespace77 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"title", namespace77, ((global::HealthVault.Types.CodableValue)o.@Title), false, false, namespace77, @"");
            if (o.@ShouldSerializeFirst()) {
                string namespace78 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"first", namespace78, ((global::System.String)o.@First));
            }
            if (o.@ShouldSerializeMiddle()) {
                string namespace79 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"middle", namespace79, ((global::System.String)o.@Middle));
            }
            if (o.@ShouldSerializeLast()) {
                string namespace80 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"last", namespace80, ((global::System.String)o.@Last));
            }
            string namespace81 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"suffix", namespace81, ((global::HealthVault.Types.CodableValue)o.@Suffix), false, false, namespace81, @"");
            WriteEndElement(o);
        }

        void Write20_BooleanValue(string n, string ns, global::HealthVault.Types.BooleanValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.BooleanValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BooleanValue", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write21_Address(string n, string ns, global::HealthVault.Types.Address o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Address)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Address", defaultNamespace);
            if (o.@ShouldSerializeDescription()) {
                string namespace82 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"description", namespace82, ((global::System.String)o.@Description));
            }
            string namespace83 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-primary", namespace83, ((global::HealthVault.Types.BooleanValue)o.@IsPrimary), false, false, namespace83, @"");
            {
                global::System.String[] a = (global::System.String[])o.@Street;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace84 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementString(@"street", namespace84, ((global::System.String)a[ia]));
                    }
                }
            }
            if (o.@ShouldSerializeCity()) {
                string namespace85 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"city", namespace85, ((global::System.String)o.@City));
            }
            if (o.@ShouldSerializeState()) {
                string namespace86 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"state", namespace86, ((global::System.String)o.@State));
            }
            if (o.@ShouldSerializePostalCode()) {
                string namespace87 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"postcode", namespace87, ((global::System.String)o.@PostalCode));
            }
            if (o.@ShouldSerializeCountry()) {
                string namespace88 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"country", namespace88, ((global::System.String)o.@Country));
            }
            if (o.@ShouldSerializeCounty()) {
                string namespace89 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"county", namespace89, ((global::System.String)o.@County));
            }
            WriteEndElement(o);
        }

        void Write22_Phone(string n, string ns, global::HealthVault.Types.Phone o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Phone)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Phone", defaultNamespace);
            if (o.@ShouldSerializeDescription()) {
                string namespace90 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"description", namespace90, ((global::System.String)o.@Description));
            }
            string namespace91 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-primary", namespace91, ((global::HealthVault.Types.BooleanValue)o.@IsPrimary), false, false, namespace91, @"");
            if (o.@ShouldSerializeNumber()) {
                string namespace92 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"number", namespace92, ((global::System.String)o.@Number));
            }
            WriteEndElement(o);
        }

        void Write23_EmailAddress(string n, string ns, global::HealthVault.Types.EmailAddress o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.EmailAddress)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"EmailAddress", defaultNamespace);
            if (o.@ShouldSerializeValue()) {
                if ((object)(o.@Value) != null){
                    WriteValue(((global::System.String)o.@Value));
                }
            }
            WriteEndElement(o);
        }

        void Write24_Email(string n, string ns, global::HealthVault.Types.Email o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Email)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Email", defaultNamespace);
            if (o.@ShouldSerializeDescription()) {
                string namespace93 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"description", namespace93, ((global::System.String)o.@Description));
            }
            string namespace94 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-primary", namespace94, ((global::HealthVault.Types.BooleanValue)o.@IsPrimary), false, false, namespace94, @"");
            string namespace95 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write23_EmailAddress(@"address", namespace95, ((global::HealthVault.Types.EmailAddress)o.@Address), false, false, namespace95, @"");
            WriteEndElement(o);
        }

        void Write25_Contact(string n, string ns, global::HealthVault.Types.Contact o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Contact)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Contact", defaultNamespace);
            {
                global::HealthVault.Types.Address[] a = (global::HealthVault.Types.Address[])o.@Address;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace96 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write21_Address(@"address", namespace96, ((global::HealthVault.Types.Address)a[ia]), false, false, namespace96, @"");
                    }
                }
            }
            {
                global::HealthVault.Types.Phone[] a = (global::HealthVault.Types.Phone[])o.@Phone;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace97 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write22_Phone(@"phone", namespace97, ((global::HealthVault.Types.Phone)a[ia]), false, false, namespace97, @"");
                    }
                }
            }
            {
                global::HealthVault.Types.Email[] a = (global::HealthVault.Types.Email[])o.@Email;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace98 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write24_Email(@"email", namespace98, ((global::HealthVault.Types.Email)a[ia]), false, false, namespace98, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write26_Person(string n, string ns, global::HealthVault.Types.Person o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Person)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Person", defaultNamespace);
            string namespace99 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write19_Name(@"name", namespace99, ((global::HealthVault.Types.Name)o.@Name), false, false, namespace99, @"");
            if (o.@ShouldSerializeOrganization()) {
                string namespace100 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"organization", namespace100, ((global::System.String)o.@Organization));
            }
            if (o.@ShouldSerializeTraining()) {
                string namespace101 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"professional-training", namespace101, ((global::System.String)o.@Training));
            }
            if (o.@ShouldSerializeIdentificationNumber()) {
                string namespace102 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"id", namespace102, ((global::System.String)o.@IdentificationNumber));
            }
            string namespace103 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write25_Contact(@"contact", namespace103, ((global::HealthVault.Types.Contact)o.@Contact), false, false, namespace103, @"");
            string namespace104 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"type", namespace104, ((global::HealthVault.Types.CodableValue)o.@Type), false, false, namespace104, @"");
            WriteEndElement(o);
        }

        void Write27_Allergy(string n, string ns, global::HealthVault.ItemTypes.Allergy o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Allergy)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"allergy", defaultNamespace);
            string namespace105 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace105, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace105, @"");
            string namespace106 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"reaction", namespace106, ((global::HealthVault.Types.CodableValue)o.@Reaction), false, false, namespace106, @"");
            string namespace107 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"first-observed", namespace107, ((global::HealthVault.Types.ApproxDateTime)o.@FirstObserved), false, false, namespace107, @"");
            string namespace108 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"allergen-type", namespace108, ((global::HealthVault.Types.CodableValue)o.@AllergenType), false, false, namespace108, @"");
            string namespace109 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"allergen-code", namespace109, ((global::HealthVault.Types.CodableValue)o.@AllergenCode), false, false, namespace109, @"");
            string namespace110 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write26_Person(@"treatment-provider", namespace110, ((global::HealthVault.Types.Person)o.@TreatmentProvider), false, false, namespace110, @"");
            string namespace111 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"treatment", namespace111, ((global::HealthVault.Types.CodableValue)o.@Treatment), false, false, namespace111, @"");
            string namespace112 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-negated", namespace112, ((global::HealthVault.Types.BooleanValue)o.@IsNegated), false, false, namespace112, @"");
            WriteEndElement(o);
        }

        void Write28_DayOfWeek(string n, string ns, global::HealthVault.Types.DayOfWeek o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.DayOfWeek)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DayOfWeek", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write29_Language(string n, string ns, global::HealthVault.Types.Language o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Language)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Language", defaultNamespace);
            string namespace113 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"language", namespace113, ((global::HealthVault.Types.CodableValue)o.@LanguageValue), false, false, namespace113, @"");
            string namespace114 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-primary", namespace114, ((global::HealthVault.Types.BooleanValue)o.@IsPrimary), false, false, namespace114, @"");
            WriteEndElement(o);
        }

        void Write30_BasicV2(string n, string ns, global::HealthVault.ItemTypes.BasicV2 o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.BasicV2)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"basic", defaultNamespace);
            if (o.@ShouldSerializeGender()) {
                string namespace115 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"gender", namespace115, ((global::System.String)o.@Gender));
            }
            string namespace116 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write5_Year(@"birthyear", namespace116, ((global::HealthVault.Types.Year)o.@BirthYear), false, false, namespace116, @"");
            string namespace117 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"country", namespace117, ((global::HealthVault.Types.CodableValue)o.@Country), false, false, namespace117, @"");
            if (o.@ShouldSerializePostalCode()) {
                string namespace118 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"postcode", namespace118, ((global::System.String)o.@PostalCode));
            }
            if (o.@ShouldSerializeCity()) {
                string namespace119 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"city", namespace119, ((global::System.String)o.@City));
            }
            string namespace120 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"state", namespace120, ((global::HealthVault.Types.CodableValue)o.@State), false, false, namespace120, @"");
            string namespace121 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write28_DayOfWeek(@"firstdow", namespace121, ((global::HealthVault.Types.DayOfWeek)o.@FirstDayOfWeek), false, false, namespace121, @"");
            {
                global::HealthVault.Types.Language[] a = (global::HealthVault.Types.Language[])o.@Languages;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace122 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write29_Language(@"language", namespace122, ((global::HealthVault.Types.Language)a[ia]), false, false, namespace122, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write33_BloodGlucoseMeasurement(string n, string ns, global::HealthVault.Types.BloodGlucoseMeasurement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.BloodGlucoseMeasurement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BloodGlucoseMeasurement", defaultNamespace);
            string namespace123 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_PositiveDouble(@"mmolPerL", namespace123, ((global::HealthVault.Types.PositiveDouble)o.@Value), false, false, namespace123, @"");
            string namespace124 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_DisplayValue(@"display", namespace124, ((global::HealthVault.Types.DisplayValue)o.@Display), false, false, namespace124, @"");
            WriteEndElement(o);
        }

        void Write34_OneToFive(string n, string ns, global::HealthVault.Types.OneToFive o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.OneToFive)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"OneToFive", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write35_BloodGlucose(string n, string ns, global::HealthVault.ItemTypes.BloodGlucose o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.BloodGlucose)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"blood-glucose", defaultNamespace);
            string namespace125 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace125, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace125, @"");
            string namespace126 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write33_BloodGlucoseMeasurement(@"value", namespace126, ((global::HealthVault.Types.BloodGlucoseMeasurement)o.@Value), false, false, namespace126, @"");
            string namespace127 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"glucose-measurement-type", namespace127, ((global::HealthVault.Types.CodableValue)o.@MeasurementType), false, false, namespace127, @"");
            string namespace128 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"outside-operating-temp", namespace128, ((global::HealthVault.Types.BooleanValue)o.@OutsideOperatingTemperature), false, false, namespace128, @"");
            string namespace129 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-control-test", namespace129, ((global::HealthVault.Types.BooleanValue)o.@IsControlTest), false, false, namespace129, @"");
            string namespace130 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write34_OneToFive(@"normalcy", namespace130, ((global::HealthVault.Types.OneToFive)o.@Normalcy), false, false, namespace130, @"");
            string namespace131 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"measurement-context", namespace131, ((global::HealthVault.Types.CodableValue)o.@MeasurementContext), false, false, namespace131, @"");
            WriteEndElement(o);
        }

        void Write36_NonNegativeInt(string n, string ns, global::HealthVault.Types.NonNegativeInt o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.NonNegativeInt)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"NonNegativeInt", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write37_BloodPressure(string n, string ns, global::HealthVault.ItemTypes.BloodPressure o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.BloodPressure)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"blood-pressure", defaultNamespace);
            string namespace132 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace132, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace132, @"");
            string namespace133 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write36_NonNegativeInt(@"systolic", namespace133, ((global::HealthVault.Types.NonNegativeInt)o.@Systolic), false, false, namespace133, @"");
            string namespace134 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write36_NonNegativeInt(@"diastolic", namespace134, ((global::HealthVault.Types.NonNegativeInt)o.@Diastolic), false, false, namespace134, @"");
            string namespace135 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write36_NonNegativeInt(@"pulse", namespace135, ((global::HealthVault.Types.NonNegativeInt)o.@Pulse), false, false, namespace135, @"");
            string namespace136 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"irregular-heartbeat", namespace136, ((global::HealthVault.Types.BooleanValue)o.@IrregularHeartbeat), false, false, namespace136, @"");
            WriteEndElement(o);
        }

        void Write39_ConcentrationValue(string n, string ns, global::HealthVault.Types.ConcentrationValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ConcentrationValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ConcentrationValue", defaultNamespace);
            string namespace137 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write38_NonNegativeDouble(@"mmolPerL", namespace137, ((global::HealthVault.Types.NonNegativeDouble)o.@Value), false, false, namespace137, @"");
            string namespace138 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_DisplayValue(@"display", namespace138, ((global::HealthVault.Types.DisplayValue)o.@DisplayValue), false, false, namespace138, @"");
            WriteEndElement(o);
        }

        void Write40_Cholesterol(string n, string ns, global::HealthVault.ItemTypes.Cholesterol o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Cholesterol)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"cholesterol-profile", defaultNamespace);
            string namespace139 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace139, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace139, @"");
            string namespace140 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write39_ConcentrationValue(@"ldl", namespace140, ((global::HealthVault.Types.ConcentrationValue)o.@Ldl), false, false, namespace140, @"");
            string namespace141 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write39_ConcentrationValue(@"hdl", namespace141, ((global::HealthVault.Types.ConcentrationValue)o.@Hdl), false, false, namespace141, @"");
            string namespace142 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write39_ConcentrationValue(@"total-cholesterol", namespace142, ((global::HealthVault.Types.ConcentrationValue)o.@Total), false, false, namespace142, @"");
            string namespace143 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write39_ConcentrationValue(@"triglyceride", namespace143, ((global::HealthVault.Types.ConcentrationValue)o.@Triglycerides), false, false, namespace143, @"");
            WriteEndElement(o);
        }

        void Write41_Condition(string n, string ns, global::HealthVault.ItemTypes.Condition o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Condition)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"condition", defaultNamespace);
            string namespace144 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace144, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace144, @"");
            string namespace145 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"onset-date", namespace145, ((global::HealthVault.Types.ApproxDateTime)o.@OnsetDate), false, false, namespace145, @"");
            string namespace146 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"status", namespace146, ((global::HealthVault.Types.CodableValue)o.@Status), false, false, namespace146, @"");
            string namespace147 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"stop-date", namespace147, ((global::HealthVault.Types.ApproxDateTime)o.@StopDate), false, false, namespace147, @"");
            if (o.@ShouldSerializeStopReason()) {
                string namespace148 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"stop-reason", namespace148, ((global::System.String)o.@StopReason));
            }
            WriteEndElement(o);
        }

        void Write42_Contact(string n, string ns, global::HealthVault.ItemTypes.Contact o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Contact)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"person", defaultNamespace);
            string namespace149 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write19_Name(@"name", namespace149, ((global::HealthVault.Types.Name)o.@Name), false, false, namespace149, @"");
            string namespace150 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"organization", namespace150, ((global::System.String)o.@Organization));
            string namespace151 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"professional-training", namespace151, ((global::System.String)o.@Training));
            string namespace152 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"id", namespace152, ((global::System.String)o.@IdentificationNumber));
            string namespace153 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write25_Contact(@"contact", namespace153, ((global::HealthVault.Types.Contact)o.@ContactInformation), false, false, namespace153, @"");
            string namespace154 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"type", namespace154, ((global::HealthVault.Types.CodableValue)o.@ContactType), false, false, namespace154, @"");
            WriteEndElement(o);
        }

        void Write48_DietaryIntake(string n, string ns, global::HealthVault.ItemTypes.DietaryIntake o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.DietaryIntake)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DietaryIntake", defaultNamespace);
            string namespace155 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"food-item", namespace155, ((global::HealthVault.Types.CodableValue)o.@FoodItem), false, false, namespace155, @"");
            string namespace156 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"serving-size", namespace156, ((global::HealthVault.Types.CodableValue)o.@ServingSize), false, false, namespace156, @"");
            string namespace157 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write38_NonNegativeDouble(@"servings-consumed", namespace157, ((global::HealthVault.Types.NonNegativeDouble)o.@ServingsConsumed), false, false, namespace157, @"");
            string namespace158 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"meal", namespace158, ((global::HealthVault.Types.CodableValue)o.@Meal), false, false, namespace158, @"");
            string namespace159 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace159, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace159, @"");
            string namespace160 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write43_FoodEnergyValue(@"energy", namespace160, ((global::HealthVault.Types.FoodEnergyValue)o.@Calories), false, false, namespace160, @"");
            string namespace161 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write43_FoodEnergyValue(@"energy-from-fat", namespace161, ((global::HealthVault.Types.FoodEnergyValue)o.@CaloriesFromFat), false, false, namespace161, @"");
            string namespace162 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"total-fat", namespace162, ((global::HealthVault.Types.WeightMeasurement)o.@TotalFat), false, false, namespace162, @"");
            string namespace163 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"saturated-fat", namespace163, ((global::HealthVault.Types.WeightMeasurement)o.@SaturatedFat), false, false, namespace163, @"");
            string namespace164 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"trans-fat", namespace164, ((global::HealthVault.Types.WeightMeasurement)o.@TransFat), false, false, namespace164, @"");
            string namespace165 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"monounsaturated-fat", namespace165, ((global::HealthVault.Types.WeightMeasurement)o.@MonounsaturatedFat), false, false, namespace165, @"");
            string namespace166 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"polyunsaturated-fat", namespace166, ((global::HealthVault.Types.WeightMeasurement)o.@PolyunsaturatedFat), false, false, namespace166, @"");
            string namespace167 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"protein", namespace167, ((global::HealthVault.Types.WeightMeasurement)o.@Protein), false, false, namespace167, @"");
            string namespace168 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"carbohydrates", namespace168, ((global::HealthVault.Types.WeightMeasurement)o.@Carbohydrates), false, false, namespace168, @"");
            string namespace169 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"dietary-fiber", namespace169, ((global::HealthVault.Types.WeightMeasurement)o.@Fiber), false, false, namespace169, @"");
            string namespace170 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"sugars", namespace170, ((global::HealthVault.Types.WeightMeasurement)o.@Sugars), false, false, namespace170, @"");
            string namespace171 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"sodium", namespace171, ((global::HealthVault.Types.WeightMeasurement)o.@Sodium), false, false, namespace171, @"");
            string namespace172 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"cholesterol", namespace172, ((global::HealthVault.Types.WeightMeasurement)o.@Cholesterol), false, false, namespace172, @"");
            string namespace173 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"calcium", namespace173, ((global::HealthVault.Types.WeightMeasurement)o.@Calcium), false, false, namespace173, @"");
            string namespace174 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"iron", namespace174, ((global::HealthVault.Types.WeightMeasurement)o.@Iron), false, false, namespace174, @"");
            string namespace175 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"magnesium", namespace175, ((global::HealthVault.Types.WeightMeasurement)o.@Magnesium), false, false, namespace175, @"");
            string namespace176 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"phosphorus", namespace176, ((global::HealthVault.Types.WeightMeasurement)o.@Phosphorus), false, false, namespace176, @"");
            string namespace177 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"potassium", namespace177, ((global::HealthVault.Types.WeightMeasurement)o.@Potassium), false, false, namespace177, @"");
            string namespace178 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"zinc", namespace178, ((global::HealthVault.Types.WeightMeasurement)o.@Zinc), false, false, namespace178, @"");
            string namespace179 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-A-RAE", namespace179, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminA), false, false, namespace179, @"");
            string namespace180 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-E", namespace180, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminE), false, false, namespace180, @"");
            string namespace181 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-D", namespace181, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminD), false, false, namespace181, @"");
            string namespace182 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-C", namespace182, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminC), false, false, namespace182, @"");
            string namespace183 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"thiamin", namespace183, ((global::HealthVault.Types.WeightMeasurement)o.@Thiamin), false, false, namespace183, @"");
            string namespace184 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"riboflavin", namespace184, ((global::HealthVault.Types.WeightMeasurement)o.@Riboflavin), false, false, namespace184, @"");
            string namespace185 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"niacin", namespace185, ((global::HealthVault.Types.WeightMeasurement)o.@Niacin), false, false, namespace185, @"");
            string namespace186 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-B-6", namespace186, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminB6), false, false, namespace186, @"");
            string namespace187 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"folate-DFE", namespace187, ((global::HealthVault.Types.WeightMeasurement)o.@Folate), false, false, namespace187, @"");
            string namespace188 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-B-12", namespace188, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminB12), false, false, namespace188, @"");
            string namespace189 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"vitamin-K", namespace189, ((global::HealthVault.Types.WeightMeasurement)o.@VitaminK), false, false, namespace189, @"");
            string namespace190 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::HealthVault.Types.NutritionFact[] a = (global::HealthVault.Types.NutritionFact[])((global::HealthVault.Types.NutritionFact[])o.@AdditionalNutritionFacts);
                if (a != null){
                    WriteStartElement(@"additional-nutrition-facts", namespace190, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace191 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write47_NutritionFact(@"nutrition-fact", namespace191, ((global::HealthVault.Types.NutritionFact)a[ia]), true, false, namespace191, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write49_LengthMeasurement(string n, string ns, global::HealthVault.Types.LengthMeasurement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.LengthMeasurement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LengthMeasurement", defaultNamespace);
            string namespace192 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_PositiveDouble(@"m", namespace192, ((global::HealthVault.Types.PositiveDouble)o.@Value), false, false, namespace192, @"");
            string namespace193 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_DisplayValue(@"display", namespace193, ((global::HealthVault.Types.DisplayValue)o.@DisplayValue), false, false, namespace193, @"");
            WriteEndElement(o);
        }

        void Write50_StructuredNameValue(string n, string ns, global::HealthVault.Types.StructuredNameValue o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.StructuredNameValue)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"StructuredNameValue", defaultNamespace);
            string namespace194 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write14_CodedValue(@"name", namespace194, ((global::HealthVault.Types.CodedValue)o.@Name), false, false, namespace194, @"");
            string namespace195 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write45_StructuredMeasurement(@"value", namespace195, ((global::HealthVault.Types.StructuredMeasurement)o.@Value), false, false, namespace195, @"");
            WriteEndElement(o);
        }

        void Write51_ExerciseSegment(string n, string ns, global::HealthVault.Types.ExerciseSegment o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ExerciseSegment)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ExerciseSegment", defaultNamespace);
            string namespace196 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"activity", namespace196, ((global::HealthVault.Types.CodableValue)o.@Activity), false, false, namespace196, @"");
            if (o.@ShouldSerializeTitle()) {
                string namespace197 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"title", namespace197, ((global::System.String)o.@Title));
            }
            string namespace198 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write49_LengthMeasurement(@"distance", namespace198, ((global::HealthVault.Types.LengthMeasurement)o.@Distance), false, false, namespace198, @"");
            string namespace199 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_PositiveDouble(@"duration", namespace199, ((global::HealthVault.Types.PositiveDouble)o.@Duration), false, false, namespace199, @"");
            string namespace200 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write38_NonNegativeDouble(@"offset", namespace200, ((global::HealthVault.Types.NonNegativeDouble)o.@Offset), false, false, namespace200, @"");
            {
                global::HealthVault.Types.StructuredNameValueCollection a = (global::HealthVault.Types.StructuredNameValueCollection)o.@Details;
                if (a != null) {
                    System.Collections.IEnumerator e = a.@GetEnumerator();
                    if (e != null)
                    while (e.MoveNext()) {
                        global::HealthVault.Types.StructuredNameValue ai = (global::HealthVault.Types.StructuredNameValue)e.Current;
                        string namespace201 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write50_StructuredNameValue(@"detail", namespace201, ((global::HealthVault.Types.StructuredNameValue)ai), false, false, namespace201, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write52_Exercise(string n, string ns, global::HealthVault.ItemTypes.Exercise o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Exercise)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"exercise", defaultNamespace);
            string namespace202 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"when", namespace202, ((global::HealthVault.Types.ApproxDateTime)o.@When), false, false, namespace202, @"");
            string namespace203 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"activity", namespace203, ((global::HealthVault.Types.CodableValue)o.@Activity), false, false, namespace203, @"");
            if (o.@ShouldSerializeTitle()) {
                string namespace204 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"title", namespace204, ((global::System.String)o.@Title));
            }
            string namespace205 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write49_LengthMeasurement(@"distance", namespace205, ((global::HealthVault.Types.LengthMeasurement)o.@Distance), false, false, namespace205, @"");
            string namespace206 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_PositiveDouble(@"duration", namespace206, ((global::HealthVault.Types.PositiveDouble)o.@Duration), false, false, namespace206, @"");
            {
                global::HealthVault.Types.StructuredNameValueCollection a = (global::HealthVault.Types.StructuredNameValueCollection)o.@Details;
                if (a != null) {
                    System.Collections.IEnumerator e = a.@GetEnumerator();
                    if (e != null)
                    while (e.MoveNext()) {
                        global::HealthVault.Types.StructuredNameValue ai = (global::HealthVault.Types.StructuredNameValue)e.Current;
                        string namespace207 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write50_StructuredNameValue(@"detail", namespace207, ((global::HealthVault.Types.StructuredNameValue)ai), false, false, namespace207, @"");
                    }
                }
            }
            {
                global::HealthVault.Types.ExerciseSegmentCollection a = (global::HealthVault.Types.ExerciseSegmentCollection)o.@Segments;
                if (a != null) {
                    System.Collections.IEnumerator e = a.@GetEnumerator();
                    if (e != null)
                    while (e.MoveNext()) {
                        global::HealthVault.Types.ExerciseSegment ai = (global::HealthVault.Types.ExerciseSegment)e.Current;
                        string namespace208 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write51_ExerciseSegment(@"segment", namespace208, ((global::HealthVault.Types.ExerciseSegment)ai), false, false, namespace208, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write53_File(string n, string ns, global::HealthVault.ItemTypes.File o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.File)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"File", defaultNamespace);
            if (o.@ShouldSerializeName()) {
                string namespace209 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"name", namespace209, ((global::System.String)o.@Name));
            }
            string namespace210 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"size", namespace210, System.Xml.XmlConvert.ToString((global::System.Int64)((global::System.Int64)o.@Size)));
            string namespace211 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"content-type", namespace211, ((global::HealthVault.Types.CodableValue)o.@ContentType), false, false, namespace211, @"");
            WriteEndElement(o);
        }

        void Write54_GoalAssociatedTypeInfo(string n, string ns, global::HealthVault.Types.GoalAssociatedTypeInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.GoalAssociatedTypeInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GoalAssociatedTypeInfo", defaultNamespace);
            if (o.@ShouldSerializeThingTypeVersionId()) {
                string namespace212 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"thing-type-version-id", namespace212, ((global::System.String)o.@ThingTypeVersionId));
            }
            if (o.@ShouldSerializeThingTypeValueXpath()) {
                string namespace213 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"thing-type-value-xpath", namespace213, ((global::System.String)o.@ThingTypeValueXpath));
            }
            if (o.@ShouldSerializeThingTypeDisplayXpath()) {
                string namespace214 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"thing-type-display-xpath", namespace214, ((global::System.String)o.@ThingTypeDisplayXpath));
            }
            WriteEndElement(o);
        }

        void Write55_GoalRange(string n, string ns, global::HealthVault.Types.GoalRange o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.GoalRange)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GoalRange", defaultNamespace);
            string namespace215 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace215, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace215, @"");
            if (o.@ShouldSerializeDescription()) {
                string namespace216 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"description", namespace216, ((global::System.String)o.@Description));
            }
            string namespace217 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write46_GeneralMeasurement(@"minimum", namespace217, ((global::HealthVault.Types.GeneralMeasurement)o.@Minimum), false, false, namespace217, @"");
            string namespace218 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write46_GeneralMeasurement(@"maximum", namespace218, ((global::HealthVault.Types.GeneralMeasurement)o.@Maximum), false, false, namespace218, @"");
            WriteEndElement(o);
        }

        void Write56_GoalRecurrence(string n, string ns, global::HealthVault.Types.GoalRecurrence o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.GoalRecurrence)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GoalRecurrence", defaultNamespace);
            string namespace219 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"interval", namespace219, ((global::HealthVault.Types.CodableValue)o.@Interval), false, false, namespace219, @"");
            string namespace220 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"times-in-interval", namespace220, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@TimesInInterval)));
            WriteEndElement(o);
        }

        void Write57_HealthGoal(string n, string ns, global::HealthVault.ItemTypes.HealthGoal o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.HealthGoal)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"health-goal", defaultNamespace);
            string namespace221 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace221, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace221, @"");
            if (o.@ShouldSerializeDescription()) {
                string namespace222 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"description", namespace222, ((global::System.String)o.@Description));
            }
            string namespace223 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"start-date", namespace223, ((global::HealthVault.Types.ApproxDateTime)o.@StartDate), false, false, namespace223, @"");
            string namespace224 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"end-date", namespace224, ((global::HealthVault.Types.ApproxDateTime)o.@EndDate), false, false, namespace224, @"");
            string namespace225 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write54_GoalAssociatedTypeInfo(@"associated-type-info", namespace225, ((global::HealthVault.Types.GoalAssociatedTypeInfo)o.@AssociatedTypeInfo), false, false, namespace225, @"");
            string namespace226 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write55_GoalRange(@"target-range", namespace226, ((global::HealthVault.Types.GoalRange)o.@TargetRange), false, false, namespace226, @"");
            {
                global::HealthVault.Types.GoalRange[] a = (global::HealthVault.Types.GoalRange[])o.@GoalAdditionalRanges;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace227 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write55_GoalRange(@"goal-additional-ranges", namespace227, ((global::HealthVault.Types.GoalRange)a[ia]), false, false, namespace227, @"");
                    }
                }
            }
            string namespace228 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write56_GoalRecurrence(@"recurrence", namespace228, ((global::HealthVault.Types.GoalRecurrence)o.@Recurrence), false, false, namespace228, @"");
            WriteEndElement(o);
        }

        void Write58_Height(string n, string ns, global::HealthVault.ItemTypes.Height o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Height)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"height", defaultNamespace);
            string namespace229 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace229, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace229, @"");
            string namespace230 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write49_LengthMeasurement(@"value", namespace230, ((global::HealthVault.Types.LengthMeasurement)o.@Value), false, false, namespace230, @"");
            WriteEndElement(o);
        }

        void Write59_ApproxDate(string n, string ns, global::HealthVault.Types.ApproxDate o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ApproxDate)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ApproxDate", defaultNamespace);
            string namespace231 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write5_Year(@"y", namespace231, ((global::HealthVault.Types.Year)o.@Year), false, false, namespace231, @"");
            string namespace232 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write6_Month(@"m", namespace232, ((global::HealthVault.Types.Month)o.@Month), false, false, namespace232, @"");
            string namespace233 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write7_Day(@"d", namespace233, ((global::HealthVault.Types.Day)o.@Day), false, false, namespace233, @"");
            WriteEndElement(o);
        }

        void Write60_Immunization(string n, string ns, global::HealthVault.ItemTypes.Immunization o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Immunization)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Immunization", defaultNamespace);
            string namespace234 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace234, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace234, @"");
            string namespace235 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"administration-date", namespace235, ((global::HealthVault.Types.ApproxDateTime)o.@AdministrationDate), false, false, namespace235, @"");
            string namespace236 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write26_Person(@"administrator", namespace236, ((global::HealthVault.Types.Person)o.@Administrator), false, false, namespace236, @"");
            string namespace237 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"manufacturer", namespace237, ((global::HealthVault.Types.CodableValue)o.@Manufacturer), false, false, namespace237, @"");
            if (o.@ShouldSerializeLot()) {
                string namespace238 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"lot", namespace238, ((global::System.String)o.@Lot));
            }
            string namespace239 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"route", namespace239, ((global::HealthVault.Types.CodableValue)o.@Route), false, false, namespace239, @"");
            string namespace240 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write59_ApproxDate(@"expiration-date", namespace240, ((global::HealthVault.Types.ApproxDate)o.@ExpirationDate), false, false, namespace240, @"");
            if (o.@ShouldSerializeSequence()) {
                string namespace241 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"sequence", namespace241, ((global::System.String)o.@Sequence));
            }
            string namespace242 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"anatomic-surface", namespace242, ((global::HealthVault.Types.CodableValue)o.@AnatomicSurface), false, false, namespace242, @"");
            if (o.@ShouldSerializeAdverseEvent()) {
                string namespace243 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"adverse-event", namespace243, ((global::System.String)o.@AdverseEvent));
            }
            if (o.@ShouldSerializeConsent()) {
                string namespace244 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"consent", namespace244, ((global::System.String)o.@Consent));
            }
            WriteEndElement(o);
        }

        void Write61_Insurance(string n, string ns, global::HealthVault.ItemTypes.Insurance o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Insurance)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"payer", defaultNamespace);
            if (o.@ShouldSerializePlanName()) {
                string namespace245 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"plan-name", namespace245, ((global::System.String)o.@PlanName));
            }
            string namespace246 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"coverage-type", namespace246, ((global::HealthVault.Types.CodableValue)o.@CoverageType), false, false, namespace246, @"");
            if (o.@ShouldSerializeCarrierId()) {
                string namespace247 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"carrier-id", namespace247, ((global::System.String)o.@CarrierId));
            }
            if (o.@ShouldSerializeGroupNumber()) {
                string namespace248 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"group-num", namespace248, ((global::System.String)o.@GroupNumber));
            }
            if (o.@ShouldSerializePlanCode()) {
                string namespace249 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"plan-code", namespace249, ((global::System.String)o.@PlanCode));
            }
            if (o.@ShouldSerializeSubscriberId()) {
                string namespace250 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"subscriber-id", namespace250, ((global::System.String)o.@SubscriberId));
            }
            if (o.@ShouldSerializePersonCode()) {
                string namespace251 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"person-code", namespace251, ((global::System.String)o.@PersonCode));
            }
            if (o.@ShouldSerializeSubscriberName()) {
                string namespace252 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"subscriber-name", namespace252, ((global::System.String)o.@SubscriberName));
            }
            string namespace253 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"subscriber-dob", namespace253, ((global::HealthVault.Types.StructuredDateTime)o.@SubscriberDob), false, false, namespace253, @"");
            string namespace254 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-primary", namespace254, ((global::HealthVault.Types.BooleanValue)o.@IsPrimary), false, false, namespace254, @"");
            string namespace255 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"expiration-date", namespace255, ((global::HealthVault.Types.StructuredDateTime)o.@ExpirationDate), false, false, namespace255, @"");
            string namespace256 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write25_Contact(@"contact", namespace256, ((global::HealthVault.Types.Contact)o.@Contact), false, false, namespace256, @"");
            WriteEndElement(o);
        }

        void Write62_ApproxMeasurement(string n, string ns, global::HealthVault.Types.ApproxMeasurement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ApproxMeasurement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ApproxMeasurement", defaultNamespace);
            if (o.@ShouldSerializeDisplay()) {
                string namespace257 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"display", namespace257, ((global::System.String)o.@Display));
            }
            string namespace258 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write45_StructuredMeasurement(@"structured", namespace258, ((global::HealthVault.Types.StructuredMeasurement)o.@Measurement), false, false, namespace258, @"");
            WriteEndElement(o);
        }

        void Write63_PositiveInt(string n, string ns, global::HealthVault.Types.PositiveInt o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.PositiveInt)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PositiveInt", defaultNamespace);
            {
                WriteValue(System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Value)));
            }
            WriteEndElement(o);
        }

        void Write64_Prescription(string n, string ns, global::HealthVault.Types.Prescription o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Prescription)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Prescription", defaultNamespace);
            string namespace259 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write26_Person(@"prescribed-by", namespace259, ((global::HealthVault.Types.Person)o.@PrescribedBy), false, false, namespace259, @"");
            string namespace260 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"date-prescribed", namespace260, ((global::HealthVault.Types.ApproxDateTime)o.@DatePrescribed), false, false, namespace260, @"");
            string namespace261 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write62_ApproxMeasurement(@"amount-prescribed", namespace261, ((global::HealthVault.Types.ApproxMeasurement)o.@Amount), false, false, namespace261, @"");
            string namespace262 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"substitution", namespace262, ((global::HealthVault.Types.CodableValue)o.@Substitution), false, false, namespace262, @"");
            string namespace263 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write36_NonNegativeInt(@"refills", namespace263, ((global::HealthVault.Types.NonNegativeInt)o.@Refills), false, false, namespace263, @"");
            string namespace264 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write63_PositiveInt(@"days-supply", namespace264, ((global::HealthVault.Types.PositiveInt)o.@DaysSupply), false, false, namespace264, @"");
            string namespace265 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write8_Date(@"prescription-expiration", namespace265, ((global::HealthVault.Types.Date)o.@Expiration), false, false, namespace265, @"");
            string namespace266 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"instructions", namespace266, ((global::HealthVault.Types.CodableValue)o.@Instructions), false, false, namespace266, @"");
            WriteEndElement(o);
        }

        void Write65_Medication(string n, string ns, global::HealthVault.ItemTypes.Medication o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Medication)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"medication", defaultNamespace);
            string namespace267 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace267, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace267, @"");
            string namespace268 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"generic-name", namespace268, ((global::HealthVault.Types.CodableValue)o.@GenericName), false, false, namespace268, @"");
            string namespace269 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write62_ApproxMeasurement(@"dose", namespace269, ((global::HealthVault.Types.ApproxMeasurement)o.@Dose), false, false, namespace269, @"");
            string namespace270 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write62_ApproxMeasurement(@"strength", namespace270, ((global::HealthVault.Types.ApproxMeasurement)o.@Strength), false, false, namespace270, @"");
            string namespace271 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write62_ApproxMeasurement(@"frequency", namespace271, ((global::HealthVault.Types.ApproxMeasurement)o.@Frequency), false, false, namespace271, @"");
            string namespace272 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"route", namespace272, ((global::HealthVault.Types.CodableValue)o.@Route), false, false, namespace272, @"");
            string namespace273 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"indication", namespace273, ((global::HealthVault.Types.CodableValue)o.@Indication), false, false, namespace273, @"");
            string namespace274 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"date-started", namespace274, ((global::HealthVault.Types.ApproxDateTime)o.@StartDate), false, false, namespace274, @"");
            string namespace275 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"date-discontinued", namespace275, ((global::HealthVault.Types.ApproxDateTime)o.@StopDate), false, false, namespace275, @"");
            string namespace276 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"prescribed", namespace276, ((global::HealthVault.Types.CodableValue)o.@Prescribed), false, false, namespace276, @"");
            string namespace277 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write64_Prescription(@"prescription", namespace277, ((global::HealthVault.Types.Prescription)o.@Prescription), false, false, namespace277, @"");
            WriteEndElement(o);
        }

        void Write66_Personal(string n, string ns, global::HealthVault.ItemTypes.Personal o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Personal)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"personal", defaultNamespace);
            string namespace278 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write19_Name(@"name", namespace278, ((global::HealthVault.Types.Name)o.@Name), false, false, namespace278, @"");
            string namespace279 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"birthdate", namespace279, ((global::HealthVault.Types.StructuredDateTime)o.@BirthDate), false, false, namespace279, @"");
            string namespace280 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"blood-type", namespace280, ((global::HealthVault.Types.CodableValue)o.@BloodType), false, false, namespace280, @"");
            string namespace281 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"ethnicity", namespace281, ((global::HealthVault.Types.CodableValue)o.@Ethnicity), false, false, namespace281, @"");
            if (o.@ShouldSerializeNationalIdentifier()) {
                string namespace282 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"ssn", namespace282, ((global::System.String)o.@NationalIdentifier));
            }
            string namespace283 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"marital-status", namespace283, ((global::HealthVault.Types.CodableValue)o.@MaritalStatus), false, false, namespace283, @"");
            if (o.@ShouldSerializeEmploymentStatus()) {
                string namespace284 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"employment-status", namespace284, ((global::System.String)o.@EmploymentStatus));
            }
            string namespace285 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-deceased", namespace285, ((global::HealthVault.Types.BooleanValue)o.@IsDeceased), false, false, namespace285, @"");
            string namespace286 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"date-of-death", namespace286, ((global::HealthVault.Types.ApproxDateTime)o.@DateOfDeath), false, false, namespace286, @"");
            string namespace287 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"religion", namespace287, ((global::HealthVault.Types.CodableValue)o.@Religion), false, false, namespace287, @"");
            string namespace288 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-veteran", namespace288, ((global::HealthVault.Types.BooleanValue)o.@IsVeteran), false, false, namespace288, @"");
            string namespace289 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"highest-education-level", namespace289, ((global::HealthVault.Types.CodableValue)o.@EducationLevel), false, false, namespace289, @"");
            string namespace290 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_BooleanValue(@"is-disabled", namespace290, ((global::HealthVault.Types.BooleanValue)o.@IsDisabled), false, false, namespace290, @"");
            if (o.@ShouldSerializeOrganDonor()) {
                string namespace291 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"organ-donor", namespace291, ((global::System.String)o.@OrganDonor));
            }
            WriteEndElement(o);
        }

        void Write67_PersonalImage(string n, string ns, global::HealthVault.ItemTypes.PersonalImage o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.PersonalImage)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PersonalImage", defaultNamespace);
            WriteEndElement(o);
        }

        void Write68_Procedure(string n, string ns, global::HealthVault.ItemTypes.Procedure o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Procedure)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"procedure", defaultNamespace);
            string namespace292 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_ApproxDateTime(@"when", namespace292, ((global::HealthVault.Types.ApproxDateTime)o.@When), false, false, namespace292, @"");
            string namespace293 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace293, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace293, @"");
            string namespace294 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"anatomic-location", namespace294, ((global::HealthVault.Types.CodableValue)o.@AnatomicLocation), false, false, namespace294, @"");
            string namespace295 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write26_Person(@"primary-provider", namespace295, ((global::HealthVault.Types.Person)o.@PrimaryProvider), false, false, namespace295, @"");
            string namespace296 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write26_Person(@"secondary-provider", namespace296, ((global::HealthVault.Types.Person)o.@SecondaryProvider), false, false, namespace296, @"");
            WriteEndElement(o);
        }

        void Write69_Weight(string n, string ns, global::HealthVault.ItemTypes.Weight o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.Weight)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"weight", defaultNamespace);
            string namespace297 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_StructuredDateTime(@"when", namespace297, ((global::HealthVault.Types.StructuredDateTime)o.@When), false, false, namespace297, @"");
            string namespace298 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write44_WeightMeasurement(@"value", namespace298, ((global::HealthVault.Types.WeightMeasurement)o.@Value), false, false, namespace298, @"");
            WriteEndElement(o);
        }

        void Write71_MealDefinition(string n, string ns, global::HealthVault.ItemTypes.MealDefinition o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.ItemTypes.MealDefinition)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"meal-definition", defaultNamespace);
            string namespace299 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"name", namespace299, ((global::HealthVault.Types.CodableValue)o.@Name), false, false, namespace299, @"");
            string namespace300 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_CodableValue(@"meal-type", namespace300, ((global::HealthVault.Types.CodableValue)o.@MealType), false, false, namespace300, @"");
            string namespace301 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"description", namespace301, ((global::System.String)o.@Description));
            string namespace302 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::HealthVault.Types.DietaryIntakeItem[] a = (global::HealthVault.Types.DietaryIntakeItem[])((global::HealthVault.Types.DietaryIntakeItem[])o.@DietaryIntakeItems);
                if (a != null){
                    WriteStartElement(@"dietary-items", namespace302, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace303 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write70_DietaryIntakeItem(@"dietary-item", namespace303, ((global::HealthVault.Types.DietaryIntakeItem)a[ia]), true, false, namespace303, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write72_ItemExtension(string n, string ns, global::HealthVault.Types.ItemExtension o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemExtension)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ItemExtension", defaultNamespace);
            if (o.@ShouldSerializeSource()) {
                WriteAttribute(@"source", @"", ((global::System.String)o.@Source));
            }
            if (o.@ShouldSerializeVer()) {
                WriteAttribute(@"ver", @"", ((global::System.String)o.@Ver));
            }
            if (o.@ShouldSerializeLogo()) {
                WriteAttribute(@"logo", @"", ((global::System.String)o.@Logo));
            }
            if (o.@ShouldSerializeXsl()) {
                WriteAttribute(@"xsl", @"", ((global::System.String)o.@Xsl));
            }
            WriteEndElement(o);
        }

        void Write73_RelatedItem(string n, string ns, global::HealthVault.Types.RelatedItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.RelatedItem)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"RelatedItem", defaultNamespace);
            if (o.@ShouldSerializeItemID()) {
                string namespace304 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"thing-id", namespace304, ((global::System.String)o.@ItemID));
            }
            if (o.@ShouldSerializeVersion()) {
                string namespace305 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"version-stamp", namespace305, ((global::System.String)o.@Version));
            }
            if (o.@ShouldSerializeClientID()) {
                string namespace306 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"client-thing-id", namespace306, ((global::System.String)o.@ClientID));
            }
            if (o.@ShouldSerializeRelationshipType()) {
                string namespace307 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"relationship-type", namespace307, ((global::System.String)o.@RelationshipType));
            }
            WriteEndElement(o);
        }

        void Write74_ItemDataCommon(string n, string ns, global::HealthVault.Types.ItemDataCommon o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemDataCommon)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ItemDataCommon", defaultNamespace);
            if (o.@ShouldSerializeSource()) {
                string namespace308 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"source", namespace308, ((global::System.String)o.@Source));
            }
            if (o.@ShouldSerializeNote()) {
                string namespace309 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"note", namespace309, ((global::System.String)o.@Note));
            }
            if (o.@ShouldSerializeTags()) {
                string namespace310 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"tags", namespace310, ((global::System.String)o.@Tags));
            }
            {
                global::HealthVault.Types.ItemExtension[] a = (global::HealthVault.Types.ItemExtension[])o.@Extensions;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace311 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write72_ItemExtension(@"extension", namespace311, ((global::HealthVault.Types.ItemExtension)a[ia]), false, false, namespace311, @"");
                    }
                }
            }
            {
                global::HealthVault.Types.RelatedItem[] a = (global::HealthVault.Types.RelatedItem[])o.@RelatedItems;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace312 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write73_RelatedItem(@"related-thing", namespace312, ((global::HealthVault.Types.RelatedItem)a[ia]), false, false, namespace312, @"");
                    }
                }
            }
            if (o.@ShouldSerializeClientId()) {
                string namespace313 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"client-thing-id", namespace313, ((global::System.String)o.@ClientId));
            }
            WriteEndElement(o);
        }

        void Write75_ItemData(string n, string ns, global::HealthVault.Types.ItemData o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemData)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ItemData", defaultNamespace);
            if ((object)(o.@Typed) != null){
                if (o.@Typed is global::HealthVault.ItemTypes.Insurance) {
                    string namespace314 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write61_Insurance(@"payer", namespace314, ((global::HealthVault.ItemTypes.Insurance)o.@Typed), false, false, namespace314, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Medication) {
                    string namespace315 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write65_Medication(@"medication", namespace315, ((global::HealthVault.ItemTypes.Medication)o.@Typed), false, false, namespace315, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Immunization) {
                    string namespace316 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write60_Immunization(@"immunization", namespace316, ((global::HealthVault.ItemTypes.Immunization)o.@Typed), false, false, namespace316, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.HealthGoal) {
                    string namespace317 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write57_HealthGoal(@"health-goal", namespace317, ((global::HealthVault.ItemTypes.HealthGoal)o.@Typed), false, false, namespace317, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Height) {
                    string namespace318 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write58_Height(@"height", namespace318, ((global::HealthVault.ItemTypes.Height)o.@Typed), false, false, namespace318, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Weight) {
                    string namespace319 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write69_Weight(@"weight", namespace319, ((global::HealthVault.ItemTypes.Weight)o.@Typed), false, false, namespace319, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.MealDefinition) {
                    string namespace320 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write71_MealDefinition(@"meal-definition", namespace320, ((global::HealthVault.ItemTypes.MealDefinition)o.@Typed), false, false, namespace320, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Procedure) {
                    string namespace321 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write68_Procedure(@"procedure", namespace321, ((global::HealthVault.ItemTypes.Procedure)o.@Typed), false, false, namespace321, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Personal) {
                    string namespace322 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write66_Personal(@"personal", namespace322, ((global::HealthVault.ItemTypes.Personal)o.@Typed), false, false, namespace322, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.PersonalImage) {
                    string namespace323 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write67_PersonalImage(@"personal-image", namespace323, ((global::HealthVault.ItemTypes.PersonalImage)o.@Typed), false, false, namespace323, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.BloodPressure) {
                    string namespace324 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write37_BloodPressure(@"blood-pressure", namespace324, ((global::HealthVault.ItemTypes.BloodPressure)o.@Typed), false, false, namespace324, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Cholesterol) {
                    string namespace325 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write40_Cholesterol(@"cholesterol-profile", namespace325, ((global::HealthVault.ItemTypes.Cholesterol)o.@Typed), false, false, namespace325, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.BloodGlucose) {
                    string namespace326 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write35_BloodGlucose(@"blood-glucose", namespace326, ((global::HealthVault.ItemTypes.BloodGlucose)o.@Typed), false, false, namespace326, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Allergy) {
                    string namespace327 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write27_Allergy(@"allergy", namespace327, ((global::HealthVault.ItemTypes.Allergy)o.@Typed), false, false, namespace327, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.BasicV2) {
                    string namespace328 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write30_BasicV2(@"basic", namespace328, ((global::HealthVault.ItemTypes.BasicV2)o.@Typed), false, false, namespace328, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Exercise) {
                    string namespace329 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write52_Exercise(@"exercise", namespace329, ((global::HealthVault.ItemTypes.Exercise)o.@Typed), false, false, namespace329, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.File) {
                    string namespace330 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write53_File(@"file", namespace330, ((global::HealthVault.ItemTypes.File)o.@Typed), false, false, namespace330, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.DietaryIntake) {
                    string namespace331 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write48_DietaryIntake(@"dietary-intake", namespace331, ((global::HealthVault.ItemTypes.DietaryIntake)o.@Typed), false, false, namespace331, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Condition) {
                    string namespace332 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write41_Condition(@"condition", namespace332, ((global::HealthVault.ItemTypes.Condition)o.@Typed), false, false, namespace332, @"");
                }
                else if (o.@Typed is global::HealthVault.ItemTypes.Contact) {
                    string namespace333 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                    Write42_Contact(@"person", namespace333, ((global::HealthVault.ItemTypes.Contact)o.@Typed), false, false, namespace333, @"");
                }
                else  if ((object)(o.@Typed) != null){
                    throw CreateUnknownTypeException(o.@Typed);
                }
            }
            string namespace334 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write74_ItemDataCommon(@"common", namespace334, ((global::HealthVault.Types.ItemDataCommon)o.@Common), false, false, namespace334, @"");
            WriteEndElement(o);
        }

        void Write76_BlobInfo(string n, string ns, global::HealthVault.Types.BlobInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.BlobInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BlobInfo", defaultNamespace);
            if (o.@ShouldSerializeName()) {
                string namespace335 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"name", namespace335, ((global::System.String)o.@Name));
            }
            if (o.@ShouldSerializeContentType()) {
                string namespace336 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"content-type", namespace336, ((global::System.String)o.@ContentType));
            }
            WriteEndElement(o);
        }

        void Write77_Blob(string n, string ns, global::HealthVault.Types.Blob o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.Blob)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Blob", defaultNamespace);
            string namespace337 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write76_BlobInfo(@"blob-info", namespace337, ((global::HealthVault.Types.BlobInfo)o.@Info), false, false, namespace337, @"");
            string namespace338 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"content-length", namespace338, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Length)));
            if (o.@ShouldSerializeUrl()) {
                string namespace339 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"blob-ref-url", namespace339, ((global::System.String)o.@Url));
            }
            if (o.@ShouldSerializeLegacyEncoding()) {
                string namespace340 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"legacy-content-encoding", namespace340, ((global::System.String)o.@LegacyEncoding));
            }
            if (o.@ShouldSerializeEncoding()) {
                string namespace341 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"current-content-encoding", namespace341, ((global::System.String)o.@Encoding));
            }
            WriteEndElement(o);
        }

        void Write78_ItemDataBlob(string n, string ns, global::HealthVault.Types.ItemDataBlob o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemDataBlob)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ItemDataBlob", defaultNamespace);
            {
                global::HealthVault.Types.BlobCollection a = (global::HealthVault.Types.BlobCollection)o.@Blobs;
                if (a != null) {
                    System.Collections.IEnumerator e = a.@GetEnumerator();
                    if (e != null)
                    while (e.MoveNext()) {
                        global::HealthVault.Types.Blob ai = (global::HealthVault.Types.Blob)e.Current;
                        string namespace342 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write77_Blob(@"blob", namespace342, ((global::HealthVault.Types.Blob)ai), false, false, namespace342, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write79_RecordItem(string n, string ns, global::HealthVault.Types.RecordItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.RecordItem)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"thing", defaultNamespace);
            string namespace343 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_ItemKey(@"thing-id", namespace343, ((global::HealthVault.Types.ItemKey)o.@Key), false, false, namespace343, @"");
            string namespace344 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write3_ItemType(@"type-id", namespace344, ((global::HealthVault.Types.ItemType)o.@Type), false, false, namespace344, @"");
            if (o.@ShouldSerializeState()) {
                string namespace345 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                WriteElementString(@"thing-state", namespace345, ((global::System.String)o.@State));
            }
            string namespace346 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"flags", namespace346, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Flags)));
            string namespace347 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write4_DateTime(@"eff-date", namespace347, ((global::HealthVault.Types.DateTime)o.@EffectiveDate), false, false, namespace347, @"");
            string namespace348 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write17_Audit(@"created", namespace348, ((global::HealthVault.Types.Audit)o.@Created), false, false, namespace348, @"");
            string namespace349 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write17_Audit(@"updated", namespace349, ((global::HealthVault.Types.Audit)o.@Updated), false, false, namespace349, @"");
            string namespace350 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write75_ItemData(@"data-xml", namespace350, ((global::HealthVault.Types.ItemData)o.@Data), false, false, namespace350, @"");
            string namespace351 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write78_ItemDataBlob(@"blob-payload", namespace351, ((global::HealthVault.Types.ItemDataBlob)o.@BlobData), false, false, namespace351, @"");
            string namespace352 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write4_DateTime(@"updated-end-date", namespace352, ((global::HealthVault.Types.DateTime)o.@UpdatedEndDate), false, false, namespace352, @"");
            WriteEndElement(o);
        }

        void Write80_PendingItem(string n, string ns, global::HealthVault.Types.PendingItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.PendingItem)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PendingItem", defaultNamespace);
            string namespace353 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_ItemKey(@"thing-id", namespace353, ((global::HealthVault.Types.ItemKey)o.@Key), false, false, namespace353, @"");
            string namespace354 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write3_ItemType(@"type-id", namespace354, ((global::HealthVault.Types.ItemType)o.@TypeID), false, false, namespace354, @"");
            string namespace355 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write4_DateTime(@"eff-date", namespace355, ((global::HealthVault.Types.DateTime)o.@EffectiveDate), false, false, namespace355, @"");
            WriteEndElement(o);
        }

        void Write81_ItemQueryResult(string n, string ns, global::HealthVault.Types.ItemQueryResult o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.ItemQueryResult)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ItemQueryResult", defaultNamespace);
            if (o.@ShouldSerializeName()) {
                WriteAttribute(@"name", @"", ((global::System.String)o.@Name));
            }
            {
                global::HealthVault.Types.RecordItem[] a = (global::HealthVault.Types.RecordItem[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace356 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write79_RecordItem(@"thing", namespace356, ((global::HealthVault.Types.RecordItem)a[ia]), false, false, namespace356, @"");
                    }
                }
            }
            {
                global::HealthVault.Types.PendingItem[] a = (global::HealthVault.Types.PendingItem[])o.@PendingItems;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace357 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write80_PendingItem(@"unprocessed-thing-key-info", namespace357, ((global::HealthVault.Types.PendingItem)a[ia]), false, false, namespace357, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write82_RecordQueryResponse(string n, string ns, global::HealthVault.Types.RecordQueryResponse o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::HealthVault.Types.RecordQueryResponse)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"RecordQueryResponse", defaultNamespace);
            {
                global::HealthVault.Types.ItemQueryResult[] a = (global::HealthVault.Types.ItemQueryResult[])o.@Results;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace358 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write81_ItemQueryResult(@"group", namespace358, ((global::HealthVault.Types.ItemQueryResult)a[ia]), false, false, namespace358, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read83_thing(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_thing && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read79_RecordItem(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":thing");
            }
            return (object)o;
        }

        public object Read84_ItemData(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_ItemData && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read75_ItemData(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ItemData");
            }
            return (object)o;
        }

        public object Read85_RecordQueryResponse(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id4_RecordQueryResponse && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read82_RecordQueryResponse(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":RecordQueryResponse");
            }
            return (object)o;
        }

        public object Read86_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        public object Read87_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        global::System.Object Read1_Object(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
                if (isNull) {
                    if (xsiType != null) return (global::System.Object)ReadTypedNull(xsiType);
                    else return null;
                }
                if (xsiType == null) {
                    return ReadTypedPrimitive(new System.Xml.XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema"));
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_RecordQueryResponse && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read82_RecordQueryResponse(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_ItemQueryResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read81_ItemQueryResult(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_PendingItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read80_PendingItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_thing && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read79_RecordItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_ItemDataBlob && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read78_ItemDataBlob(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_Blob && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read77_Blob(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_BlobInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read76_BlobInfo(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_ItemData && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read75_ItemData(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_ItemDataCommon && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read74_ItemDataCommon(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_RelatedItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read73_RelatedItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_ItemExtension && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read72_ItemExtension(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_mealdefinition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read71_MealDefinition(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_DietaryIntakeItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read70_DietaryIntakeItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_weight && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read69_Weight(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_procedure && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read68_Procedure(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_PersonalImage && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read67_PersonalImage(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_personal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read66_Personal(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_medication && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read65_Medication(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Prescription && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read64_Prescription(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_PositiveInt && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read63_PositiveInt(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_ApproxMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read62_ApproxMeasurement(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_payer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read61_Insurance(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Immunization && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read60_Immunization(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_ApproxDate && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read59_ApproxDate(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_height && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read58_Height(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_healthgoal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read57_HealthGoal(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_GoalRecurrence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read56_GoalRecurrence(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_GoalRange && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read55_GoalRange(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_GoalAssociatedTypeInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read54_GoalAssociatedTypeInfo(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_File && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read53_File(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_exercise && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read52_Exercise(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_ExerciseSegment && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read51_ExerciseSegment(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_StructuredNameValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read50_StructuredNameValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_LengthMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read49_LengthMeasurement(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_DietaryIntake && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read48_DietaryIntake(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_NutritionFact && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read47_NutritionFact(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_GeneralMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read46_GeneralMeasurement(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_StructuredMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read45_StructuredMeasurement(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_WeightMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read44_WeightMeasurement(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_FoodEnergyValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read43_FoodEnergyValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_person && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read42_Contact(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_condition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read41_Condition(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_cholesterolprofile && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read40_Cholesterol(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_ConcentrationValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read39_ConcentrationValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_NonNegativeDouble && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read38_NonNegativeDouble(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_bloodpressure && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read37_BloodPressure(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_NonNegativeInt && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read36_NonNegativeInt(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_bloodglucose && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read35_BloodGlucose(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_OneToFive && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read34_OneToFive(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_BloodGlucoseMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read33_BloodGlucoseMeasurement(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_DisplayValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read32_DisplayValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_PositiveDouble && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read31_PositiveDouble(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_basic && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read30_BasicV2(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_Language && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read29_Language(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_DayOfWeek && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read28_DayOfWeek(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id58_allergy && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read27_Allergy(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id59_Person && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read26_Person(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id60_Contact && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read25_Contact(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id61_Email && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read24_Email(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_EmailAddress && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read23_EmailAddress(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id63_Phone && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read22_Phone(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id64_Address && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read21_Address(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id65_BooleanValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read20_BooleanValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id66_Name && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read19_Name(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id67_ApproxDateTime && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read18_ApproxDateTime(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id68_Audit && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read17_Audit(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id69_StructuredDateTime && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read16_StructuredDateTime(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id70_CodableValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read15_CodableValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id71_CodedValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read14_CodedValue(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id72_Time && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read13_Time(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id73_Millisecond && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read12_Millisecond(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id74_Second && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read11_Second(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id75_Minute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read10_Minute(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id76_Hour && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read9_Hour(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id77_Date && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read8_Date(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id78_Day && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read7_Day(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id79_Month && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read6_Month(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id80_Year && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read5_Year(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id81_DateTime && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read4_DateTime(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id82_ItemType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read3_ItemType(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id83_thingid && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read2_ItemKey(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id84_ArrayOfNutritionFact && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::HealthVault.Types.NutritionFact[] a = null;
                    if (!ReadNull()) {
                        global::HealthVault.Types.NutritionFact[] z_0_0 = null;
                        int cz_0_0 = 0;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations0 = 0;
                            int readerCount0 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id85_nutritionfact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        z_0_0 = (global::HealthVault.Types.NutritionFact[])EnsureArrayIndex(z_0_0, cz_0_0, typeof(global::HealthVault.Types.NutritionFact));z_0_0[cz_0_0++] = Read47_NutritionFact(true, true, defaultNamespace);
                                    }
                                    else {
                                        UnknownNode(null, @":nutrition-fact");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":nutrition-fact");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations0, ref readerCount0);
                            }
                        ReadEndElement();
                        }
                        a = (global::HealthVault.Types.NutritionFact[])ShrinkArray(z_0_0, cz_0_0, typeof(global::HealthVault.Types.NutritionFact), false);
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id86_ArrayOfDietaryIntakeItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::HealthVault.Types.DietaryIntakeItem[] a = null;
                    if (!ReadNull()) {
                        global::HealthVault.Types.DietaryIntakeItem[] z_0_0 = null;
                        int cz_0_0 = 0;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations1 = 0;
                            int readerCount1 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id87_dietaryitem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        z_0_0 = (global::HealthVault.Types.DietaryIntakeItem[])EnsureArrayIndex(z_0_0, cz_0_0, typeof(global::HealthVault.Types.DietaryIntakeItem));z_0_0[cz_0_0++] = Read70_DietaryIntakeItem(true, true, defaultNamespace);
                                    }
                                    else {
                                        UnknownNode(null, @":dietary-item");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":dietary-item");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations1, ref readerCount1);
                            }
                        ReadEndElement();
                        }
                        a = (global::HealthVault.Types.DietaryIntakeItem[])ShrinkArray(z_0_0, cz_0_0, typeof(global::HealthVault.Types.DietaryIntakeItem), false);
                    }
                    return a;
                }
                else
                    return ReadTypedPrimitive((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::System.Object o;
                o = new global::System.Object();
                bool[] paramsRead = new bool[0];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations2 = 0;
                int readerCount2 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations2, ref readerCount2);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.DietaryIntakeItem Read70_DietaryIntakeItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_DietaryIntakeItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.DietaryIntakeItem o;
                o = new global::HealthVault.Types.DietaryIntakeItem();
                global::HealthVault.Types.NutritionFact[] a_35 = null;
                int ca_35 = 0;
                bool[] paramsRead = new bool[36];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations3 = 0;
                int readerCount3 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id88_fooditem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@FoodItem = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id89_servingsize && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ServingSize = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id90_servingsconsumed && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ServingsConsumed = Read38_NonNegativeDouble(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id91_meal && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Meal = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id93_energy && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Calories = Read43_FoodEnergyValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id94_energyfromfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@CaloriesFromFat = Read43_FoodEnergyValue(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id95_totalfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TotalFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id96_saturatedfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@SaturatedFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id97_transfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TransFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 10;
                            break;
                        case 10:
                            if (((object) Reader.LocalName == (object)id98_monounsaturatedfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@MonounsaturatedFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 11;
                            break;
                        case 11:
                            if (((object) Reader.LocalName == (object)id99_polyunsaturatedfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@PolyunsaturatedFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 12;
                            break;
                        case 12:
                            if (((object) Reader.LocalName == (object)id100_protein && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Protein = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 13;
                            break;
                        case 13:
                            if (((object) Reader.LocalName == (object)id101_carbohydrates && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Carbohydrates = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 14;
                            break;
                        case 14:
                            if (((object) Reader.LocalName == (object)id102_dietaryfiber && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Fiber = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 15;
                            break;
                        case 15:
                            if (((object) Reader.LocalName == (object)id103_sugars && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Sugars = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 16;
                            break;
                        case 16:
                            if (((object) Reader.LocalName == (object)id104_sodium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Sodium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 17;
                            break;
                        case 17:
                            if (((object) Reader.LocalName == (object)id105_cholesterol && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Cholesterol = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 18;
                            break;
                        case 18:
                            if (((object) Reader.LocalName == (object)id106_calcium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Calcium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 19;
                            break;
                        case 19:
                            if (((object) Reader.LocalName == (object)id107_iron && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Iron = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 20;
                            break;
                        case 20:
                            if (((object) Reader.LocalName == (object)id108_magnesium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Magnesium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 21;
                            break;
                        case 21:
                            if (((object) Reader.LocalName == (object)id109_phosphorus && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Phosphorus = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 22;
                            break;
                        case 22:
                            if (((object) Reader.LocalName == (object)id110_potassium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Potassium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 23;
                            break;
                        case 23:
                            if (((object) Reader.LocalName == (object)id111_zinc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Zinc = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 24;
                            break;
                        case 24:
                            if (((object) Reader.LocalName == (object)id112_vitaminARAE && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminA = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 25;
                            break;
                        case 25:
                            if (((object) Reader.LocalName == (object)id113_vitaminE && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminE = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 26;
                            break;
                        case 26:
                            if (((object) Reader.LocalName == (object)id114_vitaminD && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminD = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 27;
                            break;
                        case 27:
                            if (((object) Reader.LocalName == (object)id115_vitaminC && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminC = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 28;
                            break;
                        case 28:
                            if (((object) Reader.LocalName == (object)id116_thiamin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Thiamin = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 29;
                            break;
                        case 29:
                            if (((object) Reader.LocalName == (object)id117_riboflavin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Riboflavin = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 30;
                            break;
                        case 30:
                            if (((object) Reader.LocalName == (object)id118_niacin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Niacin = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 31;
                            break;
                        case 31:
                            if (((object) Reader.LocalName == (object)id119_vitaminB6 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminB6 = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 32;
                            break;
                        case 32:
                            if (((object) Reader.LocalName == (object)id120_folateDFE && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Folate = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 33;
                            break;
                        case 33:
                            if (((object) Reader.LocalName == (object)id121_vitaminB12 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminB12 = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 34;
                            break;
                        case 34:
                            if (((object) Reader.LocalName == (object)id122_vitaminK && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminK = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 35;
                            break;
                        case 35:
                            if (((object) Reader.LocalName == (object)id123_additionalnutritionfacts && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if (!ReadNull()) {
                                    global::HealthVault.Types.NutritionFact[] a_35_0 = null;
                                    int ca_35_0 = 0;
                                    if ((Reader.IsEmptyElement)) {
                                        Reader.Skip();
                                    }
                                    else {
                                        Reader.ReadStartElement();
                                        Reader.MoveToContent();
                                        int whileIterations4 = 0;
                                        int readerCount4 = ReaderCount;
                                        while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                                if (((object) Reader.LocalName == (object)id85_nutritionfact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                    a_35_0 = (global::HealthVault.Types.NutritionFact[])EnsureArrayIndex(a_35_0, ca_35_0, typeof(global::HealthVault.Types.NutritionFact));a_35_0[ca_35_0++] = Read47_NutritionFact(true, true, defaultNamespace);
                                                }
                                                else {
                                                    UnknownNode(null, @":nutrition-fact");
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":nutrition-fact");
                                            }
                                            Reader.MoveToContent();
                                            CheckReaderCount(ref whileIterations4, ref readerCount4);
                                        }
                                    ReadEndElement();
                                    }
                                    o.@AdditionalNutritionFacts = (global::HealthVault.Types.NutritionFact[])ShrinkArray(a_35_0, ca_35_0, typeof(global::HealthVault.Types.NutritionFact), false);
                                }
                            }
                            else {
                                state = 36;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations3, ref readerCount3);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.NutritionFact Read47_NutritionFact(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_NutritionFact && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.NutritionFact o;
                o = new global::HealthVault.Types.NutritionFact();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations5 = 0;
                int readerCount5 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id125_fact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Fact = Read46_GeneralMeasurement(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations5, ref readerCount5);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.GeneralMeasurement Read46_GeneralMeasurement(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_GeneralMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.GeneralMeasurement o;
                o = new global::HealthVault.Types.GeneralMeasurement();
                global::HealthVault.Types.StructuredMeasurement[] a_1 = null;
                int ca_1 = 0;
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Structured = (global::HealthVault.Types.StructuredMeasurement[])ShrinkArray(a_1, ca_1, typeof(global::HealthVault.Types.StructuredMeasurement), true);
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations6 = 0;
                int readerCount6 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Display = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id127_structured && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_1 = (global::HealthVault.Types.StructuredMeasurement[])EnsureArrayIndex(a_1, ca_1, typeof(global::HealthVault.Types.StructuredMeasurement));a_1[ca_1++] = Read45_StructuredMeasurement(false, true, defaultNamespace);
                            }
                            else {
                                state = 2;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations6, ref readerCount6);
                }
                o.@Structured = (global::HealthVault.Types.StructuredMeasurement[])ShrinkArray(a_1, ca_1, typeof(global::HealthVault.Types.StructuredMeasurement), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.StructuredMeasurement Read45_StructuredMeasurement(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_StructuredMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.StructuredMeasurement o;
                o = new global::HealthVault.Types.StructuredMeasurement();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations7 = 0;
                int readerCount7 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id128_value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Value = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id129_units && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Units = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations7, ref readerCount7);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.CodableValue Read15_CodableValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id70_CodableValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.CodableValue o;
                o = new global::HealthVault.Types.CodableValue();
                if ((object)(o.@Codes) == null) o.@Codes = new global::HealthVault.Types.CodedValueCollection();
                global::HealthVault.Types.CodedValueCollection a_1 = (global::HealthVault.Types.CodedValueCollection)o.@Codes;
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations8 = 0;
                int readerCount8 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id130_text && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Text = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id131_code && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if ((object)(a_1) == null) Reader.Skip(); else a_1.Add(Read14_CodedValue(false, true, defaultNamespace));
                            }
                            else {
                                state = 2;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations8, ref readerCount8);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.CodedValue Read14_CodedValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id71_CodedValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.CodedValue o;
                o = new global::HealthVault.Types.CodedValue();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations9 = 0;
                int readerCount9 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id128_value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Code = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id132_family && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@VocabFamily = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id133_type && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@VocabName = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id134_version && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@VocabVersion = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations9, ref readerCount9);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.WeightMeasurement Read44_WeightMeasurement(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_WeightMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.WeightMeasurement o;
                o = new global::HealthVault.Types.WeightMeasurement();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations10 = 0;
                int readerCount10 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id135_kg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Value = Read31_PositiveDouble(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@DisplayValue = Read32_DisplayValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations10, ref readerCount10);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.DisplayValue Read32_DisplayValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_DisplayValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.DisplayValue o;
                o = new global::HealthVault.Types.DisplayValue();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id129_units && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Units = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id136_unitscode && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Code = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id130_text && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Text = Reader.Value;
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":units, :units-code, :text");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations11 = 0;
                int readerCount11 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToDouble(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations11, ref readerCount11);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.PositiveDouble Read31_PositiveDouble(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_PositiveDouble && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.PositiveDouble o;
                o = new global::HealthVault.Types.PositiveDouble();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations12 = 0;
                int readerCount12 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToDouble(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations12, ref readerCount12);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.FoodEnergyValue Read43_FoodEnergyValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_FoodEnergyValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.FoodEnergyValue o;
                o = new global::HealthVault.Types.FoodEnergyValue();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations13 = 0;
                int readerCount13 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id137_calories && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Calories = Read38_NonNegativeDouble(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Display = Read32_DisplayValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations13, ref readerCount13);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.NonNegativeDouble Read38_NonNegativeDouble(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_NonNegativeDouble && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.NonNegativeDouble o;
                o = new global::HealthVault.Types.NonNegativeDouble();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations14 = 0;
                int readerCount14 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToDouble(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations14, ref readerCount14);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.StructuredDateTime Read16_StructuredDateTime(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id69_StructuredDateTime && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.StructuredDateTime o;
                o = new global::HealthVault.Types.StructuredDateTime();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations15 = 0;
                int readerCount15 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id138_date && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Date = Read8_Date(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id139_time && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Time = Read13_Time(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id140_tz && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Timezone = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations15, ref readerCount15);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Time Read13_Time(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id72_Time && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Time o;
                o = new global::HealthVault.Types.Time();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations16 = 0;
                int readerCount16 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id141_h && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Hour = Read9_Hour(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id142_m && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Minute = Read10_Minute(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id143_s && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Second = Read11_Second(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id144_f && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Millisecond = Read12_Millisecond(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations16, ref readerCount16);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Millisecond Read12_Millisecond(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id73_Millisecond && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Millisecond o;
                o = new global::HealthVault.Types.Millisecond();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations17 = 0;
                int readerCount17 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations17, ref readerCount17);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Second Read11_Second(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id74_Second && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Second o;
                o = new global::HealthVault.Types.Second();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations18 = 0;
                int readerCount18 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations18, ref readerCount18);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Minute Read10_Minute(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id75_Minute && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Minute o;
                o = new global::HealthVault.Types.Minute();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations19 = 0;
                int readerCount19 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations19, ref readerCount19);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Hour Read9_Hour(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id76_Hour && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Hour o;
                o = new global::HealthVault.Types.Hour();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations20 = 0;
                int readerCount20 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations20, ref readerCount20);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Date Read8_Date(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id77_Date && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Date o;
                o = new global::HealthVault.Types.Date();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations21 = 0;
                int readerCount21 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id145_y && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Year = Read5_Year(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id142_m && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Month = Read6_Month(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id146_d && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Day = Read7_Day(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations21, ref readerCount21);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Day Read7_Day(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id78_Day && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Day o;
                o = new global::HealthVault.Types.Day();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations22 = 0;
                int readerCount22 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations22, ref readerCount22);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Month Read6_Month(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id79_Month && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Month o;
                o = new global::HealthVault.Types.Month();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations23 = 0;
                int readerCount23 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations23, ref readerCount23);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Year Read5_Year(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id80_Year && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Year o;
                o = new global::HealthVault.Types.Year();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations24 = 0;
                int readerCount24 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations24, ref readerCount24);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemKey Read2_ItemKey(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id83_thingid && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemKey o;
                o = new global::HealthVault.Types.ItemKey();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[1] && ((object) Reader.LocalName == (object)id147_versionstamp && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Version = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":version-stamp");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations25 = 0;
                int readerCount25 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        tmp = ReadString(tmp, false);
                        o.@ID = tmp;
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations25, ref readerCount25);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemType Read3_ItemType(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id82_ItemType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemType o;
                o = new global::HealthVault.Types.ItemType();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":name");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations26 = 0;
                int readerCount26 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        tmp = ReadString(tmp, false);
                        o.@ID = tmp;
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations26, ref readerCount26);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.DateTime Read4_DateTime(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id81_DateTime && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.DateTime o;
                o = new global::HealthVault.Types.DateTime();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations27 = 0;
                int readerCount27 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        tmp = ReadString(tmp, false);
                        o.@TextValue = tmp;
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations27, ref readerCount27);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Audit Read17_Audit(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id68_Audit && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Audit o;
                o = new global::HealthVault.Types.Audit();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations28 = 0;
                int readerCount28 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id148_timestamp && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id149_appid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@AppID = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id150_auditaction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Action = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations28, ref readerCount28);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ApproxDateTime Read18_ApproxDateTime(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id67_ApproxDateTime && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ApproxDateTime o;
                o = new global::HealthVault.Types.ApproxDateTime();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations29 = 0;
                int readerCount29 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id151_descriptive && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Description = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id127_structured && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@DateTime = Read16_StructuredDateTime(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":descriptive, :structured");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":descriptive, :structured");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations29, ref readerCount29);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Name Read19_Name(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id66_Name && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Name o;
                o = new global::HealthVault.Types.Name();
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations30 = 0;
                int readerCount30 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id152_full && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Full = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id153_title && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Title = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id154_first && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@First = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id155_middle && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Middle = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id156_last && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Last = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id157_suffix && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Suffix = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations30, ref readerCount30);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.BooleanValue Read20_BooleanValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id65_BooleanValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.BooleanValue o;
                o = new global::HealthVault.Types.BooleanValue();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations31 = 0;
                int readerCount31 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToBoolean(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations31, ref readerCount31);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Address Read21_Address(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id64_Address && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Address o;
                o = new global::HealthVault.Types.Address();
                global::System.String[] a_2 = null;
                int ca_2 = 0;
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Street = (global::System.String[])ShrinkArray(a_2, ca_2, typeof(global::System.String), true);
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations32 = 0;
                int readerCount32 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id158_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Description = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id159_isprimary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsPrimary = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id160_street && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    a_2 = (global::System.String[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.String));a_2[ca_2++] = Reader.ReadElementContentAsString();
                                }
                            }
                            else {
                                state = 3;
                            }
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id161_city && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@City = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id162_state && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@State = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id163_postcode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@PostalCode = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id164_country && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Country = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id165_county && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@County = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 8;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations32, ref readerCount32);
                }
                o.@Street = (global::System.String[])ShrinkArray(a_2, ca_2, typeof(global::System.String), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Phone Read22_Phone(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id63_Phone && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Phone o;
                o = new global::HealthVault.Types.Phone();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations33 = 0;
                int readerCount33 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id158_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Description = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id159_isprimary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsPrimary = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id166_number && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Number = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations33, ref readerCount33);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.EmailAddress Read23_EmailAddress(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_EmailAddress && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.EmailAddress o;
                o = new global::HealthVault.Types.EmailAddress();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations34 = 0;
                int readerCount34 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        tmp = ReadString(tmp, false);
                        o.@Value = tmp;
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations34, ref readerCount34);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Email Read24_Email(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id61_Email && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Email o;
                o = new global::HealthVault.Types.Email();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations35 = 0;
                int readerCount35 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id158_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Description = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id159_isprimary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsPrimary = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id167_address && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Address = Read23_EmailAddress(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations35, ref readerCount35);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Contact Read25_Contact(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id60_Contact && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Contact o;
                o = new global::HealthVault.Types.Contact();
                global::HealthVault.Types.Address[] a_0 = null;
                int ca_0 = 0;
                global::HealthVault.Types.Phone[] a_1 = null;
                int ca_1 = 0;
                global::HealthVault.Types.Email[] a_2 = null;
                int ca_2 = 0;
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Address = (global::HealthVault.Types.Address[])ShrinkArray(a_0, ca_0, typeof(global::HealthVault.Types.Address), true);
                    o.@Phone = (global::HealthVault.Types.Phone[])ShrinkArray(a_1, ca_1, typeof(global::HealthVault.Types.Phone), true);
                    o.@Email = (global::HealthVault.Types.Email[])ShrinkArray(a_2, ca_2, typeof(global::HealthVault.Types.Email), true);
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations36 = 0;
                int readerCount36 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id167_address && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_0 = (global::HealthVault.Types.Address[])EnsureArrayIndex(a_0, ca_0, typeof(global::HealthVault.Types.Address));a_0[ca_0++] = Read21_Address(false, true, defaultNamespace);
                            }
                            else {
                                state = 1;
                            }
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id168_phone && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_1 = (global::HealthVault.Types.Phone[])EnsureArrayIndex(a_1, ca_1, typeof(global::HealthVault.Types.Phone));a_1[ca_1++] = Read22_Phone(false, true, defaultNamespace);
                            }
                            else {
                                state = 2;
                            }
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id169_email && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_2 = (global::HealthVault.Types.Email[])EnsureArrayIndex(a_2, ca_2, typeof(global::HealthVault.Types.Email));a_2[ca_2++] = Read24_Email(false, true, defaultNamespace);
                            }
                            else {
                                state = 3;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations36, ref readerCount36);
                }
                o.@Address = (global::HealthVault.Types.Address[])ShrinkArray(a_0, ca_0, typeof(global::HealthVault.Types.Address), true);
                o.@Phone = (global::HealthVault.Types.Phone[])ShrinkArray(a_1, ca_1, typeof(global::HealthVault.Types.Phone), true);
                o.@Email = (global::HealthVault.Types.Email[])ShrinkArray(a_2, ca_2, typeof(global::HealthVault.Types.Email), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Person Read26_Person(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id59_Person && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Person o;
                o = new global::HealthVault.Types.Person();
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations37 = 0;
                int readerCount37 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read19_Name(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id170_organization && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Organization = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id171_professionaltraining && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Training = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id172_id && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@IdentificationNumber = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id173_contact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Contact = Read25_Contact(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id133_type && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Type = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations37, ref readerCount37);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Allergy Read27_Allergy(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id58_allergy && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Allergy o;
                o = new global::HealthVault.ItemTypes.Allergy();
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations38 = 0;
                int readerCount38 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id174_reaction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Reaction = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id175_firstobserved && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@FirstObserved = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id176_allergentype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@AllergenType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id177_allergencode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@AllergenCode = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id178_treatmentprovider && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TreatmentProvider = Read26_Person(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id179_treatment && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Treatment = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id180_isnegated && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsNegated = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations38, ref readerCount38);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.DayOfWeek Read28_DayOfWeek(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_DayOfWeek && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.DayOfWeek o;
                o = new global::HealthVault.Types.DayOfWeek();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations39 = 0;
                int readerCount39 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations39, ref readerCount39);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Language Read29_Language(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_Language && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Language o;
                o = new global::HealthVault.Types.Language();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations40 = 0;
                int readerCount40 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id181_language && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@LanguageValue = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id159_isprimary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsPrimary = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations40, ref readerCount40);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.BasicV2 Read30_BasicV2(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_basic && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.BasicV2 o;
                o = new global::HealthVault.ItemTypes.BasicV2();
                global::HealthVault.Types.Language[] a_7 = null;
                int ca_7 = 0;
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Languages = (global::HealthVault.Types.Language[])ShrinkArray(a_7, ca_7, typeof(global::HealthVault.Types.Language), true);
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations41 = 0;
                int readerCount41 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id182_gender && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Gender = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id183_birthyear && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@BirthYear = Read5_Year(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id164_country && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Country = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id163_postcode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@PostalCode = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id161_city && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@City = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id162_state && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@State = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id184_firstdow && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@FirstDayOfWeek = Read28_DayOfWeek(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id181_language && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_7 = (global::HealthVault.Types.Language[])EnsureArrayIndex(a_7, ca_7, typeof(global::HealthVault.Types.Language));a_7[ca_7++] = Read29_Language(false, true, defaultNamespace);
                            }
                            else {
                                state = 8;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations41, ref readerCount41);
                }
                o.@Languages = (global::HealthVault.Types.Language[])ShrinkArray(a_7, ca_7, typeof(global::HealthVault.Types.Language), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.BloodGlucoseMeasurement Read33_BloodGlucoseMeasurement(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_BloodGlucoseMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.BloodGlucoseMeasurement o;
                o = new global::HealthVault.Types.BloodGlucoseMeasurement();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations42 = 0;
                int readerCount42 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id185_mmolPerL && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Value = Read31_PositiveDouble(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Display = Read32_DisplayValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations42, ref readerCount42);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.OneToFive Read34_OneToFive(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_OneToFive && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.OneToFive o;
                o = new global::HealthVault.Types.OneToFive();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations43 = 0;
                int readerCount43 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations43, ref readerCount43);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.BloodGlucose Read35_BloodGlucose(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_bloodglucose && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.BloodGlucose o;
                o = new global::HealthVault.ItemTypes.BloodGlucose();
                bool[] paramsRead = new bool[7];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations44 = 0;
                int readerCount44 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id128_value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Value = Read33_BloodGlucoseMeasurement(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id186_glucosemeasurementtype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@MeasurementType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id187_outsideoperatingtemp && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@OutsideOperatingTemperature = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id188_iscontroltest && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsControlTest = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id189_normalcy && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Normalcy = Read34_OneToFive(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id190_measurementcontext && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@MeasurementContext = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations44, ref readerCount44);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.NonNegativeInt Read36_NonNegativeInt(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_NonNegativeInt && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.NonNegativeInt o;
                o = new global::HealthVault.Types.NonNegativeInt();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations45 = 0;
                int readerCount45 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations45, ref readerCount45);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.BloodPressure Read37_BloodPressure(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_bloodpressure && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.BloodPressure o;
                o = new global::HealthVault.ItemTypes.BloodPressure();
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations46 = 0;
                int readerCount46 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id191_systolic && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Systolic = Read36_NonNegativeInt(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id192_diastolic && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Diastolic = Read36_NonNegativeInt(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id193_pulse && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Pulse = Read36_NonNegativeInt(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id194_irregularheartbeat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IrregularHeartbeat = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations46, ref readerCount46);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ConcentrationValue Read39_ConcentrationValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_ConcentrationValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ConcentrationValue o;
                o = new global::HealthVault.Types.ConcentrationValue();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations47 = 0;
                int readerCount47 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id185_mmolPerL && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Value = Read38_NonNegativeDouble(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@DisplayValue = Read32_DisplayValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations47, ref readerCount47);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Cholesterol Read40_Cholesterol(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_cholesterolprofile && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Cholesterol o;
                o = new global::HealthVault.ItemTypes.Cholesterol();
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations48 = 0;
                int readerCount48 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id195_ldl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Ldl = Read39_ConcentrationValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id196_hdl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Hdl = Read39_ConcentrationValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id197_totalcholesterol && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Total = Read39_ConcentrationValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id198_triglyceride && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Triglycerides = Read39_ConcentrationValue(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations48, ref readerCount48);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Condition Read41_Condition(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_condition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Condition o;
                o = new global::HealthVault.ItemTypes.Condition();
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations49 = 0;
                int readerCount49 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id199_onsetdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@OnsetDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id200_status && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Status = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id201_stopdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@StopDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id202_stopreason && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@StopReason = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations49, ref readerCount49);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Contact Read42_Contact(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_person && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Contact o;
                o = new global::HealthVault.ItemTypes.Contact();
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations50 = 0;
                int readerCount50 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read19_Name(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id170_organization && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Organization = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id171_professionaltraining && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Training = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id172_id && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@IdentificationNumber = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id173_contact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ContactInformation = Read25_Contact(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id133_type && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ContactType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations50, ref readerCount50);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.DietaryIntake Read48_DietaryIntake(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_DietaryIntake && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.DietaryIntake o;
                o = new global::HealthVault.ItemTypes.DietaryIntake();
                global::HealthVault.Types.NutritionFact[] a_35 = null;
                int ca_35 = 0;
                bool[] paramsRead = new bool[36];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations51 = 0;
                int readerCount51 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id88_fooditem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@FoodItem = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id89_servingsize && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ServingSize = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id90_servingsconsumed && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ServingsConsumed = Read38_NonNegativeDouble(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id91_meal && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Meal = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id93_energy && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Calories = Read43_FoodEnergyValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id94_energyfromfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@CaloriesFromFat = Read43_FoodEnergyValue(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id95_totalfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TotalFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id96_saturatedfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@SaturatedFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id97_transfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TransFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 10;
                            break;
                        case 10:
                            if (((object) Reader.LocalName == (object)id98_monounsaturatedfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@MonounsaturatedFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 11;
                            break;
                        case 11:
                            if (((object) Reader.LocalName == (object)id99_polyunsaturatedfat && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@PolyunsaturatedFat = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 12;
                            break;
                        case 12:
                            if (((object) Reader.LocalName == (object)id100_protein && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Protein = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 13;
                            break;
                        case 13:
                            if (((object) Reader.LocalName == (object)id101_carbohydrates && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Carbohydrates = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 14;
                            break;
                        case 14:
                            if (((object) Reader.LocalName == (object)id102_dietaryfiber && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Fiber = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 15;
                            break;
                        case 15:
                            if (((object) Reader.LocalName == (object)id103_sugars && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Sugars = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 16;
                            break;
                        case 16:
                            if (((object) Reader.LocalName == (object)id104_sodium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Sodium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 17;
                            break;
                        case 17:
                            if (((object) Reader.LocalName == (object)id105_cholesterol && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Cholesterol = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 18;
                            break;
                        case 18:
                            if (((object) Reader.LocalName == (object)id106_calcium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Calcium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 19;
                            break;
                        case 19:
                            if (((object) Reader.LocalName == (object)id107_iron && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Iron = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 20;
                            break;
                        case 20:
                            if (((object) Reader.LocalName == (object)id108_magnesium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Magnesium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 21;
                            break;
                        case 21:
                            if (((object) Reader.LocalName == (object)id109_phosphorus && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Phosphorus = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 22;
                            break;
                        case 22:
                            if (((object) Reader.LocalName == (object)id110_potassium && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Potassium = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 23;
                            break;
                        case 23:
                            if (((object) Reader.LocalName == (object)id111_zinc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Zinc = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 24;
                            break;
                        case 24:
                            if (((object) Reader.LocalName == (object)id112_vitaminARAE && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminA = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 25;
                            break;
                        case 25:
                            if (((object) Reader.LocalName == (object)id113_vitaminE && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminE = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 26;
                            break;
                        case 26:
                            if (((object) Reader.LocalName == (object)id114_vitaminD && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminD = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 27;
                            break;
                        case 27:
                            if (((object) Reader.LocalName == (object)id115_vitaminC && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminC = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 28;
                            break;
                        case 28:
                            if (((object) Reader.LocalName == (object)id116_thiamin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Thiamin = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 29;
                            break;
                        case 29:
                            if (((object) Reader.LocalName == (object)id117_riboflavin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Riboflavin = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 30;
                            break;
                        case 30:
                            if (((object) Reader.LocalName == (object)id118_niacin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Niacin = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 31;
                            break;
                        case 31:
                            if (((object) Reader.LocalName == (object)id119_vitaminB6 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminB6 = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 32;
                            break;
                        case 32:
                            if (((object) Reader.LocalName == (object)id120_folateDFE && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Folate = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 33;
                            break;
                        case 33:
                            if (((object) Reader.LocalName == (object)id121_vitaminB12 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminB12 = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 34;
                            break;
                        case 34:
                            if (((object) Reader.LocalName == (object)id122_vitaminK && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@VitaminK = Read44_WeightMeasurement(false, true, defaultNamespace);
                            }
                            state = 35;
                            break;
                        case 35:
                            if (((object) Reader.LocalName == (object)id123_additionalnutritionfacts && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if (!ReadNull()) {
                                    global::HealthVault.Types.NutritionFact[] a_35_0 = null;
                                    int ca_35_0 = 0;
                                    if ((Reader.IsEmptyElement)) {
                                        Reader.Skip();
                                    }
                                    else {
                                        Reader.ReadStartElement();
                                        Reader.MoveToContent();
                                        int whileIterations52 = 0;
                                        int readerCount52 = ReaderCount;
                                        while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                                if (((object) Reader.LocalName == (object)id85_nutritionfact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                    a_35_0 = (global::HealthVault.Types.NutritionFact[])EnsureArrayIndex(a_35_0, ca_35_0, typeof(global::HealthVault.Types.NutritionFact));a_35_0[ca_35_0++] = Read47_NutritionFact(true, true, defaultNamespace);
                                                }
                                                else {
                                                    UnknownNode(null, @":nutrition-fact");
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":nutrition-fact");
                                            }
                                            Reader.MoveToContent();
                                            CheckReaderCount(ref whileIterations52, ref readerCount52);
                                        }
                                    ReadEndElement();
                                    }
                                    o.@AdditionalNutritionFacts = (global::HealthVault.Types.NutritionFact[])ShrinkArray(a_35_0, ca_35_0, typeof(global::HealthVault.Types.NutritionFact), false);
                                }
                            }
                            else {
                                state = 36;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations51, ref readerCount51);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.LengthMeasurement Read49_LengthMeasurement(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_LengthMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.LengthMeasurement o;
                o = new global::HealthVault.Types.LengthMeasurement();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations53 = 0;
                int readerCount53 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id142_m && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Value = Read31_PositiveDouble(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@DisplayValue = Read32_DisplayValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations53, ref readerCount53);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.StructuredNameValue Read50_StructuredNameValue(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_StructuredNameValue && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.StructuredNameValue o;
                o = new global::HealthVault.Types.StructuredNameValue();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations54 = 0;
                int readerCount54 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read14_CodedValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id128_value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Value = Read45_StructuredMeasurement(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations54, ref readerCount54);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ExerciseSegment Read51_ExerciseSegment(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_ExerciseSegment && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ExerciseSegment o;
                o = new global::HealthVault.Types.ExerciseSegment();
                if ((object)(o.@Details) == null) o.@Details = new global::HealthVault.Types.StructuredNameValueCollection();
                global::HealthVault.Types.StructuredNameValueCollection a_5 = (global::HealthVault.Types.StructuredNameValueCollection)o.@Details;
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations55 = 0;
                int readerCount55 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id203_activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Activity = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id153_title && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Title = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id204_distance && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Distance = Read49_LengthMeasurement(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id205_duration && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Duration = Read31_PositiveDouble(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id206_offset && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Offset = Read38_NonNegativeDouble(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id207_detail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if ((object)(a_5) == null) Reader.Skip(); else a_5.Add(Read50_StructuredNameValue(false, true, defaultNamespace));
                            }
                            else {
                                state = 6;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations55, ref readerCount55);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Exercise Read52_Exercise(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_exercise && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Exercise o;
                o = new global::HealthVault.ItemTypes.Exercise();
                if ((object)(o.@Details) == null) o.@Details = new global::HealthVault.Types.StructuredNameValueCollection();
                global::HealthVault.Types.StructuredNameValueCollection a_5 = (global::HealthVault.Types.StructuredNameValueCollection)o.@Details;
                if ((object)(o.@Segments) == null) o.@Segments = new global::HealthVault.Types.ExerciseSegmentCollection();
                global::HealthVault.Types.ExerciseSegmentCollection a_6 = (global::HealthVault.Types.ExerciseSegmentCollection)o.@Segments;
                bool[] paramsRead = new bool[7];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations56 = 0;
                int readerCount56 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id203_activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Activity = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id153_title && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Title = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id204_distance && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Distance = Read49_LengthMeasurement(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id205_duration && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Duration = Read31_PositiveDouble(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id207_detail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if ((object)(a_5) == null) Reader.Skip(); else a_5.Add(Read50_StructuredNameValue(false, true, defaultNamespace));
                            }
                            else {
                                state = 6;
                            }
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id208_segment && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if ((object)(a_6) == null) Reader.Skip(); else a_6.Add(Read51_ExerciseSegment(false, true, defaultNamespace));
                            }
                            else {
                                state = 7;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations56, ref readerCount56);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.File Read53_File(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_File && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.File o;
                o = new global::HealthVault.ItemTypes.File();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations57 = 0;
                int readerCount57 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Name = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id209_size && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Size = System.Xml.XmlConvert.ToInt64(Reader.ReadElementContentAsString());
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id210_contenttype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ContentType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations57, ref readerCount57);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.GoalAssociatedTypeInfo Read54_GoalAssociatedTypeInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_GoalAssociatedTypeInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.GoalAssociatedTypeInfo o;
                o = new global::HealthVault.Types.GoalAssociatedTypeInfo();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations58 = 0;
                int readerCount58 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id211_thingtypeversionid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@ThingTypeVersionId = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id212_thingtypevaluexpath && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@ThingTypeValueXpath = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id213_thingtypedisplayxpath && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@ThingTypeDisplayXpath = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations58, ref readerCount58);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.GoalRange Read55_GoalRange(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_GoalRange && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.GoalRange o;
                o = new global::HealthVault.Types.GoalRange();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations59 = 0;
                int readerCount59 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id158_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Description = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id214_minimum && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Minimum = Read46_GeneralMeasurement(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id215_maximum && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Maximum = Read46_GeneralMeasurement(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations59, ref readerCount59);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.GoalRecurrence Read56_GoalRecurrence(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_GoalRecurrence && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.GoalRecurrence o;
                o = new global::HealthVault.Types.GoalRecurrence();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations60 = 0;
                int readerCount60 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id216_interval && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Interval = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id217_timesininterval && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@TimesInInterval = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                }
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations60, ref readerCount60);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.HealthGoal Read57_HealthGoal(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_healthgoal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.HealthGoal o;
                o = new global::HealthVault.ItemTypes.HealthGoal();
                global::HealthVault.Types.GoalRange[] a_6 = null;
                int ca_6 = 0;
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@GoalAdditionalRanges = (global::HealthVault.Types.GoalRange[])ShrinkArray(a_6, ca_6, typeof(global::HealthVault.Types.GoalRange), true);
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations61 = 0;
                int readerCount61 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id158_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Description = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id218_startdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@StartDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id219_enddate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@EndDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id220_associatedtypeinfo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@AssociatedTypeInfo = Read54_GoalAssociatedTypeInfo(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id221_targetrange && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TargetRange = Read55_GoalRange(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id222_goaladditionalranges && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_6 = (global::HealthVault.Types.GoalRange[])EnsureArrayIndex(a_6, ca_6, typeof(global::HealthVault.Types.GoalRange));a_6[ca_6++] = Read55_GoalRange(false, true, defaultNamespace);
                            }
                            else {
                                state = 7;
                            }
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id223_recurrence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Recurrence = Read56_GoalRecurrence(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations61, ref readerCount61);
                }
                o.@GoalAdditionalRanges = (global::HealthVault.Types.GoalRange[])ShrinkArray(a_6, ca_6, typeof(global::HealthVault.Types.GoalRange), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Height Read58_Height(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_height && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Height o;
                o = new global::HealthVault.ItemTypes.Height();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations62 = 0;
                int readerCount62 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id128_value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Value = Read49_LengthMeasurement(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":when, :value");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":when, :value");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations62, ref readerCount62);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ApproxDate Read59_ApproxDate(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_ApproxDate && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ApproxDate o;
                o = new global::HealthVault.Types.ApproxDate();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations63 = 0;
                int readerCount63 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id145_y && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Year = Read5_Year(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id142_m && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Month = Read6_Month(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id146_d && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Day = Read7_Day(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations63, ref readerCount63);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Immunization Read60_Immunization(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Immunization && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Immunization o;
                o = new global::HealthVault.ItemTypes.Immunization();
                bool[] paramsRead = new bool[11];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations64 = 0;
                int readerCount64 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id224_administrationdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@AdministrationDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id225_administrator && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Administrator = Read26_Person(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id226_manufacturer && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Manufacturer = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id227_lot && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Lot = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id228_route && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Route = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id229_expirationdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ExpirationDate = Read59_ApproxDate(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id230_sequence && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Sequence = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id231_anatomicsurface && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@AnatomicSurface = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id232_adverseevent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@AdverseEvent = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 10;
                            break;
                        case 10:
                            if (((object) Reader.LocalName == (object)id233_consent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Consent = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 11;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations64, ref readerCount64);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Insurance Read61_Insurance(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_payer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Insurance o;
                o = new global::HealthVault.ItemTypes.Insurance();
                bool[] paramsRead = new bool[12];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations65 = 0;
                int readerCount65 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id234_planname && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@PlanName = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id235_coveragetype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@CoverageType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id236_carrierid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@CarrierId = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id237_groupnum && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@GroupNumber = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id238_plancode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@PlanCode = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id239_subscriberid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@SubscriberId = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id240_personcode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@PersonCode = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id241_subscribername && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@SubscriberName = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id242_subscriberdob && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@SubscriberDob = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id159_isprimary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsPrimary = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 10;
                            break;
                        case 10:
                            if (((object) Reader.LocalName == (object)id229_expirationdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@ExpirationDate = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 11;
                            break;
                        case 11:
                            if (((object) Reader.LocalName == (object)id173_contact && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Contact = Read25_Contact(false, true, defaultNamespace);
                            }
                            state = 12;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations65, ref readerCount65);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ApproxMeasurement Read62_ApproxMeasurement(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_ApproxMeasurement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ApproxMeasurement o;
                o = new global::HealthVault.Types.ApproxMeasurement();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations66 = 0;
                int readerCount66 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id126_display && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Display = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id127_structured && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Measurement = Read45_StructuredMeasurement(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations66, ref readerCount66);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.PositiveInt Read63_PositiveInt(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_PositiveInt && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.PositiveInt o;
                o = new global::HealthVault.Types.PositiveInt();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations67 = 0;
                int readerCount67 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    string tmp = null;
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                    Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                    Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                    Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                        o.@Value = System.Xml.XmlConvert.ToInt32(this.ReadString());
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations67, ref readerCount67);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Prescription Read64_Prescription(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Prescription && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Prescription o;
                o = new global::HealthVault.Types.Prescription();
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations68 = 0;
                int readerCount68 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id243_prescribedby && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@PrescribedBy = Read26_Person(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id244_dateprescribed && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@DatePrescribed = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id245_amountprescribed && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Amount = Read62_ApproxMeasurement(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id246_substitution && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Substitution = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id247_refills && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Refills = Read36_NonNegativeInt(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id248_dayssupply && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@DaysSupply = Read63_PositiveInt(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id249_prescriptionexpiration && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Expiration = Read8_Date(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id250_instructions && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Instructions = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations68, ref readerCount68);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Medication Read65_Medication(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_medication && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Medication o;
                o = new global::HealthVault.ItemTypes.Medication();
                bool[] paramsRead = new bool[11];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations69 = 0;
                int readerCount69 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id251_genericname && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@GenericName = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id252_dose && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Dose = Read62_ApproxMeasurement(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id253_strength && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Strength = Read62_ApproxMeasurement(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id254_frequency && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Frequency = Read62_ApproxMeasurement(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id228_route && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Route = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id255_indication && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Indication = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id256_datestarted && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@StartDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id257_datediscontinued && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@StopDate = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id258_prescribed && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Prescribed = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 10;
                            break;
                        case 10:
                            if (((object) Reader.LocalName == (object)id259_prescription && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Prescription = Read64_Prescription(false, true, defaultNamespace);
                            }
                            state = 11;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations69, ref readerCount69);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Personal Read66_Personal(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_personal && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Personal o;
                o = new global::HealthVault.ItemTypes.Personal();
                bool[] paramsRead = new bool[14];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations70 = 0;
                int readerCount70 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read19_Name(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id260_birthdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@BirthDate = Read16_StructuredDateTime(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id261_bloodtype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@BloodType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id262_ethnicity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Ethnicity = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id263_ssn && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@NationalIdentifier = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id264_maritalstatus && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@MaritalStatus = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id265_employmentstatus && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@EmploymentStatus = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id266_isdeceased && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsDeceased = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id267_dateofdeath && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@DateOfDeath = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id268_religion && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Religion = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 10;
                            break;
                        case 10:
                            if (((object) Reader.LocalName == (object)id269_isveteran && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsVeteran = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 11;
                            break;
                        case 11:
                            if (((object) Reader.LocalName == (object)id270_highesteducationlevel && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@EducationLevel = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 12;
                            break;
                        case 12:
                            if (((object) Reader.LocalName == (object)id271_isdisabled && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@IsDisabled = Read20_BooleanValue(false, true, defaultNamespace);
                            }
                            state = 13;
                            break;
                        case 13:
                            if (((object) Reader.LocalName == (object)id272_organdonor && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@OrganDonor = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 14;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations70, ref readerCount70);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.PersonalImage Read67_PersonalImage(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_PersonalImage && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.PersonalImage o;
                o = new global::HealthVault.ItemTypes.PersonalImage();
                bool[] paramsRead = new bool[0];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations71 = 0;
                int readerCount71 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations71, ref readerCount71);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Procedure Read68_Procedure(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_procedure && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Procedure o;
                o = new global::HealthVault.ItemTypes.Procedure();
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations72 = 0;
                int readerCount72 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@When = Read18_ApproxDateTime(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id273_anatomiclocation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@AnatomicLocation = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id274_primaryprovider && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@PrimaryProvider = Read26_Person(false, true, defaultNamespace);
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id275_secondaryprovider && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@SecondaryProvider = Read26_Person(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations72, ref readerCount72);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.Weight Read69_Weight(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_weight && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.Weight o;
                o = new global::HealthVault.ItemTypes.Weight();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations73 = 0;
                int readerCount73 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id92_when && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@When = Read16_StructuredDateTime(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id128_value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Value = Read44_WeightMeasurement(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":when, :value");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":when, :value");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations73, ref readerCount73);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.ItemTypes.MealDefinition Read71_MealDefinition(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_mealdefinition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.ItemTypes.MealDefinition o;
                o = new global::HealthVault.ItemTypes.MealDefinition();
                global::HealthVault.Types.DietaryIntakeItem[] a_3 = null;
                int ca_3 = 0;
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations74 = 0;
                int readerCount74 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Name = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id276_mealtype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@MealType = Read15_CodableValue(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id158_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Description = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id277_dietaryitems && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                if (!ReadNull()) {
                                    global::HealthVault.Types.DietaryIntakeItem[] a_3_0 = null;
                                    int ca_3_0 = 0;
                                    if ((Reader.IsEmptyElement)) {
                                        Reader.Skip();
                                    }
                                    else {
                                        Reader.ReadStartElement();
                                        Reader.MoveToContent();
                                        int whileIterations75 = 0;
                                        int readerCount75 = ReaderCount;
                                        while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                                if (((object) Reader.LocalName == (object)id87_dietaryitem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                    a_3_0 = (global::HealthVault.Types.DietaryIntakeItem[])EnsureArrayIndex(a_3_0, ca_3_0, typeof(global::HealthVault.Types.DietaryIntakeItem));a_3_0[ca_3_0++] = Read70_DietaryIntakeItem(true, true, defaultNamespace);
                                                }
                                                else {
                                                    UnknownNode(null, @":dietary-item");
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":dietary-item");
                                            }
                                            Reader.MoveToContent();
                                            CheckReaderCount(ref whileIterations75, ref readerCount75);
                                        }
                                    ReadEndElement();
                                    }
                                    o.@DietaryIntakeItems = (global::HealthVault.Types.DietaryIntakeItem[])ShrinkArray(a_3_0, ca_3_0, typeof(global::HealthVault.Types.DietaryIntakeItem), false);
                                }
                            }
                            else {
                                state = 4;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations74, ref readerCount74);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemExtension Read72_ItemExtension(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_ItemExtension && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemExtension o;
                o = new global::HealthVault.Types.ItemExtension();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id278_source && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Source = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id279_ver && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Ver = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id280_logo && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Logo = Reader.Value;
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id281_xsl && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Xsl = Reader.Value;
                        paramsRead[3] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":source, :ver, :logo, :xsl");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations76 = 0;
                int readerCount76 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations76, ref readerCount76);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.RelatedItem Read73_RelatedItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_RelatedItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.RelatedItem o;
                o = new global::HealthVault.Types.RelatedItem();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations77 = 0;
                int readerCount77 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id83_thingid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@ItemID = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id147_versionstamp && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Version = Reader.ReadElementContentAsString();
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id282_clientthingid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@ClientID = Reader.ReadElementContentAsString();
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id283_relationshiptype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@RelationshipType = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else {
                            UnknownNode((object)o, @":thing-id, :version-stamp, :client-thing-id, :relationship-type");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":thing-id, :version-stamp, :client-thing-id, :relationship-type");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations77, ref readerCount77);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemDataCommon Read74_ItemDataCommon(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_ItemDataCommon && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemDataCommon o;
                o = new global::HealthVault.Types.ItemDataCommon();
                global::HealthVault.Types.ItemExtension[] a_3 = null;
                int ca_3 = 0;
                global::HealthVault.Types.RelatedItem[] a_4 = null;
                int ca_4 = 0;
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Extensions = (global::HealthVault.Types.ItemExtension[])ShrinkArray(a_3, ca_3, typeof(global::HealthVault.Types.ItemExtension), true);
                    o.@RelatedItems = (global::HealthVault.Types.RelatedItem[])ShrinkArray(a_4, ca_4, typeof(global::HealthVault.Types.RelatedItem), true);
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations78 = 0;
                int readerCount78 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id278_source && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Source = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id284_note && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Note = Reader.ReadElementContentAsString();
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id285_tags && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Tags = Reader.ReadElementContentAsString();
                            }
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id286_extension && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            a_3 = (global::HealthVault.Types.ItemExtension[])EnsureArrayIndex(a_3, ca_3, typeof(global::HealthVault.Types.ItemExtension));a_3[ca_3++] = Read72_ItemExtension(false, true, defaultNamespace);
                        }
                        else if (((object) Reader.LocalName == (object)id287_relatedthing && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            a_4 = (global::HealthVault.Types.RelatedItem[])EnsureArrayIndex(a_4, ca_4, typeof(global::HealthVault.Types.RelatedItem));a_4[ca_4++] = Read73_RelatedItem(false, true, defaultNamespace);
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id282_clientthingid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@ClientId = Reader.ReadElementContentAsString();
                            }
                            paramsRead[5] = true;
                        }
                        else {
                            UnknownNode((object)o, @":source, :note, :tags, :extension, :related-thing, :client-thing-id");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":source, :note, :tags, :extension, :related-thing, :client-thing-id");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations78, ref readerCount78);
                }
                o.@Extensions = (global::HealthVault.Types.ItemExtension[])ShrinkArray(a_3, ca_3, typeof(global::HealthVault.Types.ItemExtension), true);
                o.@RelatedItems = (global::HealthVault.Types.RelatedItem[])ShrinkArray(a_4, ca_4, typeof(global::HealthVault.Types.RelatedItem), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemData Read75_ItemData(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_ItemData && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemData o;
                o = new global::HealthVault.Types.ItemData();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations79 = 0;
                int readerCount79 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id58_allergy && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read27_Allergy(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id55_basic && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read30_BasicV2(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id50_bloodglucose && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read35_BloodGlucose(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id48_bloodpressure && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read37_BloodPressure(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id45_cholesterolprofile && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read40_Cholesterol(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id44_condition && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read41_Condition(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id43_person && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read42_Contact(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id288_dietaryintake && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read48_DietaryIntake(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id33_exercise && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read52_Exercise(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id289_file && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read53_File(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id28_healthgoal && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read57_HealthGoal(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id27_height && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read58_Height(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id290_immunization && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read60_Immunization(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id24_payer && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read61_Insurance(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id20_medication && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read65_Medication(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id19_personal && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read66_Personal(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id291_personalimage && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read67_PersonalImage(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id17_procedure && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read68_Procedure(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id16_weight && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read69_Weight(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[0] && ((object) Reader.LocalName == (object)id14_mealdefinition && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Typed = Read71_MealDefinition(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id292_common && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Common = Read74_ItemDataCommon(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":allergy, :basic, :blood-glucose, :blood-pressure, :cholesterol-profile, :condition, :person, :dietary-intake, :exercise, :file, :health-goal, :height, :immunization, :payer, :medication, :personal, :personal-image, :procedure, :weight, :meal-definition, :common");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":allergy, :basic, :blood-glucose, :blood-pressure, :cholesterol-profile, :condition, :person, :dietary-intake, :exercise, :file, :health-goal, :height, :immunization, :payer, :medication, :personal, :personal-image, :procedure, :weight, :meal-definition, :common");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations79, ref readerCount79);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.BlobInfo Read76_BlobInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_BlobInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.BlobInfo o;
                o = new global::HealthVault.Types.BlobInfo();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations80 = 0;
                int readerCount80 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Name = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id210_contenttype && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@ContentType = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 2;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations80, ref readerCount80);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.Blob Read77_Blob(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_Blob && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.Blob o;
                o = new global::HealthVault.Types.Blob();
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations81 = 0;
                int readerCount81 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id293_blobinfo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Info = Read76_BlobInfo(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id294_contentlength && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Length = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                }
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id295_blobrefurl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Url = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id296_legacycontentencoding && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@LegacyEncoding = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id297_currentcontentencoding && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Encoding = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 5;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations81, ref readerCount81);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemDataBlob Read78_ItemDataBlob(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_ItemDataBlob && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemDataBlob o;
                o = new global::HealthVault.Types.ItemDataBlob();
                if ((object)(o.@Blobs) == null) o.@Blobs = new global::HealthVault.Types.BlobCollection();
                global::HealthVault.Types.BlobCollection a_0 = (global::HealthVault.Types.BlobCollection)o.@Blobs;
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations82 = 0;
                int readerCount82 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id298_blob && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if ((object)(a_0) == null) Reader.Skip(); else a_0.Add(Read77_Blob(false, true, defaultNamespace));
                        }
                        else {
                            UnknownNode((object)o, @":blob");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":blob");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations82, ref readerCount82);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.RecordItem Read79_RecordItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_thing && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.RecordItem o;
                o = new global::HealthVault.Types.RecordItem();
                bool[] paramsRead = new bool[10];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations83 = 0;
                int readerCount83 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id83_thingid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Key = Read2_ItemKey(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id299_typeid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Type = Read3_ItemType(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id300_thingstate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@State = Reader.ReadElementContentAsString();
                                }
                            }
                            state = 3;
                            break;
                        case 3:
                            if (((object) Reader.LocalName == (object)id301_flags && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                {
                                    o.@Flags = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                }
                            }
                            state = 4;
                            break;
                        case 4:
                            if (((object) Reader.LocalName == (object)id302_effdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@EffectiveDate = Read4_DateTime(false, true, defaultNamespace);
                            }
                            state = 5;
                            break;
                        case 5:
                            if (((object) Reader.LocalName == (object)id303_created && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Created = Read17_Audit(false, true, defaultNamespace);
                            }
                            state = 6;
                            break;
                        case 6:
                            if (((object) Reader.LocalName == (object)id304_updated && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Updated = Read17_Audit(false, true, defaultNamespace);
                            }
                            state = 7;
                            break;
                        case 7:
                            if (((object) Reader.LocalName == (object)id305_dataxml && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Data = Read75_ItemData(false, true, defaultNamespace);
                            }
                            state = 8;
                            break;
                        case 8:
                            if (((object) Reader.LocalName == (object)id306_blobpayload && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@BlobData = Read78_ItemDataBlob(false, true, defaultNamespace);
                            }
                            state = 9;
                            break;
                        case 9:
                            if (((object) Reader.LocalName == (object)id307_updatedenddate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@UpdatedEndDate = Read4_DateTime(false, true, defaultNamespace);
                            }
                            state = 10;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations83, ref readerCount83);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.PendingItem Read80_PendingItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_PendingItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.PendingItem o;
                o = new global::HealthVault.Types.PendingItem();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations84 = 0;
                int readerCount84 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id83_thingid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@Key = Read2_ItemKey(false, true, defaultNamespace);
                            }
                            state = 1;
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id299_typeid && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@TypeID = Read3_ItemType(false, true, defaultNamespace);
                            }
                            state = 2;
                            break;
                        case 2:
                            if (((object) Reader.LocalName == (object)id302_effdate && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                o.@EffectiveDate = Read4_DateTime(false, true, defaultNamespace);
                            }
                            state = 3;
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations84, ref readerCount84);
                }
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.ItemQueryResult Read81_ItemQueryResult(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_ItemQueryResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.ItemQueryResult o;
                o = new global::HealthVault.Types.ItemQueryResult();
                global::HealthVault.Types.RecordItem[] a_0 = null;
                int ca_0 = 0;
                global::HealthVault.Types.PendingItem[] a_1 = null;
                int ca_1 = 0;
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id124_name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":name");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Items = (global::HealthVault.Types.RecordItem[])ShrinkArray(a_0, ca_0, typeof(global::HealthVault.Types.RecordItem), true);
                    o.@PendingItems = (global::HealthVault.Types.PendingItem[])ShrinkArray(a_1, ca_1, typeof(global::HealthVault.Types.PendingItem), true);
                    return o;
                }
                Reader.ReadStartElement();
                int state = 0;
                Reader.MoveToContent();
                int whileIterations85 = 0;
                int readerCount85 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        switch (state) {
                        case 0:
                            if (((object) Reader.LocalName == (object)id1_thing && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_0 = (global::HealthVault.Types.RecordItem[])EnsureArrayIndex(a_0, ca_0, typeof(global::HealthVault.Types.RecordItem));a_0[ca_0++] = Read79_RecordItem(false, true, defaultNamespace);
                            }
                            else {
                                state = 1;
                            }
                            break;
                        case 1:
                            if (((object) Reader.LocalName == (object)id308_unprocessedthingkeyinfo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                a_1 = (global::HealthVault.Types.PendingItem[])EnsureArrayIndex(a_1, ca_1, typeof(global::HealthVault.Types.PendingItem));a_1[ca_1++] = Read80_PendingItem(false, true, defaultNamespace);
                            }
                            else {
                                state = 2;
                            }
                            break;
                        default:
                            UnknownNode((object)o, null);
                            break;
                        }
                    }
                    else {
                        UnknownNode((object)o, null);
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations85, ref readerCount85);
                }
                o.@Items = (global::HealthVault.Types.RecordItem[])ShrinkArray(a_0, ca_0, typeof(global::HealthVault.Types.RecordItem), true);
                o.@PendingItems = (global::HealthVault.Types.PendingItem[])ShrinkArray(a_1, ca_1, typeof(global::HealthVault.Types.PendingItem), true);
                ReadEndElement();
                return o;
            }

            global::HealthVault.Types.RecordQueryResponse Read82_RecordQueryResponse(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_RecordQueryResponse && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::HealthVault.Types.RecordQueryResponse o;
                o = new global::HealthVault.Types.RecordQueryResponse();
                global::HealthVault.Types.ItemQueryResult[] a_0 = null;
                int ca_0 = 0;
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    o.@Results = (global::HealthVault.Types.ItemQueryResult[])ShrinkArray(a_0, ca_0, typeof(global::HealthVault.Types.ItemQueryResult), true);
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations86 = 0;
                int readerCount86 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id309_group && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            a_0 = (global::HealthVault.Types.ItemQueryResult[])EnsureArrayIndex(a_0, ca_0, typeof(global::HealthVault.Types.ItemQueryResult));a_0[ca_0++] = Read81_ItemQueryResult(false, true, defaultNamespace);
                        }
                        else {
                            UnknownNode((object)o, @":group");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":group");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations86, ref readerCount86);
                }
                o.@Results = (global::HealthVault.Types.ItemQueryResult[])ShrinkArray(a_0, ca_0, typeof(global::HealthVault.Types.ItemQueryResult), true);
                ReadEndElement();
                return o;
            }

            protected override void InitCallbacks() {
            }

            string id247_refills;
            string id257_datediscontinued;
            string id245_amountprescribed;
            string id134_version;
            string id153_title;
            string id159_isprimary;
            string id171_professionaltraining;
            string id165_county;
            string id264_maritalstatus;
            string id223_recurrence;
            string id22_PositiveInt;
            string id302_effdate;
            string id304_updated;
            string id90_servingsconsumed;
            string id288_dietaryintake;
            string id57_DayOfWeek;
            string id81_DateTime;
            string id252_dose;
            string id125_fact;
            string id164_country;
            string id144_f;
            string id292_common;
            string id306_blobpayload;
            string id56_Language;
            string id80_Year;
            string id204_distance;
            string id299_typeid;
            string id116_thiamin;
            string id301_flags;
            string id212_thingtypevaluexpath;
            string id244_dateprescribed;
            string id297_currentcontentencoding;
            string id227_lot;
            string id149_appid;
            string id300_thingstate;
            string id79_Month;
            string id23_ApproxMeasurement;
            string id201_stopdate;
            string id250_instructions;
            string id151_descriptive;
            string id41_WeightMeasurement;
            string id20_medication;
            string id259_prescription;
            string id102_dietaryfiber;
            string id53_DisplayValue;
            string id71_CodedValue;
            string id228_route;
            string id275_secondaryprovider;
            string id179_treatment;
            string id184_firstdow;
            string id203_activity;
            string id132_family;
            string id191_systolic;
            string id30_GoalRange;
            string id26_ApproxDate;
            string id145_y;
            string id268_religion;
            string id199_onsetdate;
            string id111_zinc;
            string id187_outsideoperatingtemp;
            string id174_reaction;
            string id50_bloodglucose;
            string id253_strength;
            string id126_display;
            string id239_subscriberid;
            string id97_transfat;
            string id3_ItemData;
            string id176_allergentype;
            string id96_saturatedfat;
            string id34_ExerciseSegment;
            string id258_prescribed;
            string id210_contenttype;
            string id54_PositiveDouble;
            string id160_street;
            string id72_Time;
            string id83_thingid;
            string id225_administrator;
            string id157_suffix;
            string id226_manufacturer;
            string id243_prescribedby;
            string id18_PersonalImage;
            string id128_value;
            string id266_isdeceased;
            string id249_prescriptionexpiration;
            string id110_potassium;
            string id305_dataxml;
            string id207_detail;
            string id130_text;
            string id17_procedure;
            string id60_Contact;
            string id231_anatomicsurface;
            string id185_mmolPerL;
            string id120_folateDFE;
            string id285_tags;
            string id273_anatomiclocation;
            string id12_RelatedItem;
            string id272_organdonor;
            string id291_personalimage;
            string id205_duration;
            string id206_offset;
            string id158_description;
            string id148_timestamp;
            string id233_consent;
            string id237_groupnum;
            string id218_startdate;
            string id127_structured;
            string id155_middle;
            string id123_additionalnutritionfacts;
            string id68_Audit;
            string id287_relatedthing;
            string id181_language;
            string id87_dietaryitem;
            string id61_Email;
            string id182_gender;
            string id112_vitaminARAE;
            string id303_created;
            string id51_OneToFive;
            string id279_ver;
            string id99_polyunsaturatedfat;
            string id161_city;
            string id82_ItemType;
            string id246_substitution;
            string id234_planname;
            string id238_plancode;
            string id101_carbohydrates;
            string id44_condition;
            string id7_PendingItem;
            string id122_vitaminK;
            string id14_mealdefinition;
            string id251_genericname;
            string id202_stopreason;
            string id115_vitaminC;
            string id114_vitaminD;
            string id113_vitaminE;
            string id248_dayssupply;
            string id49_NonNegativeInt;
            string id211_thingtypeversionid;
            string id70_CodableValue;
            string id192_diastolic;
            string id150_auditaction;
            string id106_calcium;
            string id156_last;
            string id11_ItemDataCommon;
            string id188_iscontroltest;
            string id152_full;
            string id208_segment;
            string id283_relationshiptype;
            string id37_DietaryIntake;
            string id178_treatmentprovider;
            string id180_isnegated;
            string id59_Person;
            string id84_ArrayOfNutritionFact;
            string id281_xsl;
            string id65_BooleanValue;
            string id267_dateofdeath;
            string id67_ApproxDateTime;
            string id213_thingtypedisplayxpath;
            string id6_ItemQueryResult;
            string id232_adverseevent;
            string id168_phone;
            string id1_thing;
            string id58_allergy;
            string id235_coveragetype;
            string id241_subscribername;
            string id135_kg;
            string id254_frequency;
            string id105_cholesterol;
            string id177_allergencode;
            string id147_versionstamp;
            string id36_LengthMeasurement;
            string id186_glucosemeasurementtype;
            string id107_iron;
            string id217_timesininterval;
            string id216_interval;
            string id39_GeneralMeasurement;
            string id270_highesteducationlevel;
            string id95_totalfat;
            string id271_isdisabled;
            string id98_monounsaturatedfat;
            string id262_ethnicity;
            string id173_contact;
            string id166_number;
            string id42_FoodEnergyValue;
            string id31_GoalAssociatedTypeInfo;
            string id200_status;
            string id117_riboflavin;
            string id47_NonNegativeDouble;
            string id76_Hour;
            string id255_indication;
            string id45_cholesterolprofile;
            string id295_blobrefurl;
            string id269_isveteran;
            string id2_Item;
            string id162_state;
            string id193_pulse;
            string id277_dietaryitems;
            string id25_Immunization;
            string id278_source;
            string id86_ArrayOfDietaryIntakeItem;
            string id198_triglyceride;
            string id222_goaladditionalranges;
            string id263_ssn;
            string id69_StructuredDateTime;
            string id85_nutritionfact;
            string id121_vitaminB12;
            string id137_calories;
            string id219_enddate;
            string id89_servingsize;
            string id190_measurementcontext;
            string id175_firstobserved;
            string id9_Blob;
            string id13_ItemExtension;
            string id197_totalcholesterol;
            string id293_blobinfo;
            string id309_group;
            string id92_when;
            string id74_Second;
            string id131_code;
            string id230_sequence;
            string id286_extension;
            string id10_BlobInfo;
            string id119_vitaminB6;
            string id66_Name;
            string id93_energy;
            string id28_healthgoal;
            string id280_logo;
            string id260_birthdate;
            string id167_address;
            string id183_birthyear;
            string id62_EmailAddress;
            string id290_immunization;
            string id215_maximum;
            string id265_employmentstatus;
            string id170_organization;
            string id229_expirationdate;
            string id296_legacycontentencoding;
            string id261_bloodtype;
            string id256_datestarted;
            string id78_Day;
            string id73_Millisecond;
            string id189_normalcy;
            string id52_BloodGlucoseMeasurement;
            string id118_niacin;
            string id221_targetrange;
            string id129_units;
            string id124_name;
            string id308_unprocessedthingkeyinfo;
            string id274_primaryprovider;
            string id46_ConcentrationValue;
            string id298_blob;
            string id40_StructuredMeasurement;
            string id209_size;
            string id43_person;
            string id276_mealtype;
            string id307_updatedenddate;
            string id64_Address;
            string id139_time;
            string id88_fooditem;
            string id100_protein;
            string id196_hdl;
            string id104_sodium;
            string id109_phosphorus;
            string id133_type;
            string id195_ldl;
            string id48_bloodpressure;
            string id146_d;
            string id63_Phone;
            string id91_meal;
            string id38_NutritionFact;
            string id220_associatedtypeinfo;
            string id77_Date;
            string id32_File;
            string id21_Prescription;
            string id24_payer;
            string id240_personcode;
            string id214_minimum;
            string id55_basic;
            string id5_anyType;
            string id282_clientthingid;
            string id19_personal;
            string id136_unitscode;
            string id27_height;
            string id242_subscriberdob;
            string id172_id;
            string id94_energyfromfat;
            string id140_tz;
            string id143_s;
            string id138_date;
            string id289_file;
            string id141_h;
            string id163_postcode;
            string id15_DietaryIntakeItem;
            string id4_RecordQueryResponse;
            string id142_m;
            string id224_administrationdate;
            string id236_carrierid;
            string id294_contentlength;
            string id169_email;
            string id154_first;
            string id33_exercise;
            string id194_irregularheartbeat;
            string id108_magnesium;
            string id284_note;
            string id103_sugars;
            string id16_weight;
            string id8_ItemDataBlob;
            string id29_GoalRecurrence;
            string id75_Minute;
            string id35_StructuredNameValue;

            protected override void InitIDs() {
                id247_refills = Reader.NameTable.Add(@"refills");
                id257_datediscontinued = Reader.NameTable.Add(@"date-discontinued");
                id245_amountprescribed = Reader.NameTable.Add(@"amount-prescribed");
                id134_version = Reader.NameTable.Add(@"version");
                id153_title = Reader.NameTable.Add(@"title");
                id159_isprimary = Reader.NameTable.Add(@"is-primary");
                id171_professionaltraining = Reader.NameTable.Add(@"professional-training");
                id165_county = Reader.NameTable.Add(@"county");
                id264_maritalstatus = Reader.NameTable.Add(@"marital-status");
                id223_recurrence = Reader.NameTable.Add(@"recurrence");
                id22_PositiveInt = Reader.NameTable.Add(@"PositiveInt");
                id302_effdate = Reader.NameTable.Add(@"eff-date");
                id304_updated = Reader.NameTable.Add(@"updated");
                id90_servingsconsumed = Reader.NameTable.Add(@"servings-consumed");
                id288_dietaryintake = Reader.NameTable.Add(@"dietary-intake");
                id57_DayOfWeek = Reader.NameTable.Add(@"DayOfWeek");
                id81_DateTime = Reader.NameTable.Add(@"DateTime");
                id252_dose = Reader.NameTable.Add(@"dose");
                id125_fact = Reader.NameTable.Add(@"fact");
                id164_country = Reader.NameTable.Add(@"country");
                id144_f = Reader.NameTable.Add(@"f");
                id292_common = Reader.NameTable.Add(@"common");
                id306_blobpayload = Reader.NameTable.Add(@"blob-payload");
                id56_Language = Reader.NameTable.Add(@"Language");
                id80_Year = Reader.NameTable.Add(@"Year");
                id204_distance = Reader.NameTable.Add(@"distance");
                id299_typeid = Reader.NameTable.Add(@"type-id");
                id116_thiamin = Reader.NameTable.Add(@"thiamin");
                id301_flags = Reader.NameTable.Add(@"flags");
                id212_thingtypevaluexpath = Reader.NameTable.Add(@"thing-type-value-xpath");
                id244_dateprescribed = Reader.NameTable.Add(@"date-prescribed");
                id297_currentcontentencoding = Reader.NameTable.Add(@"current-content-encoding");
                id227_lot = Reader.NameTable.Add(@"lot");
                id149_appid = Reader.NameTable.Add(@"app-id");
                id300_thingstate = Reader.NameTable.Add(@"thing-state");
                id79_Month = Reader.NameTable.Add(@"Month");
                id23_ApproxMeasurement = Reader.NameTable.Add(@"ApproxMeasurement");
                id201_stopdate = Reader.NameTable.Add(@"stop-date");
                id250_instructions = Reader.NameTable.Add(@"instructions");
                id151_descriptive = Reader.NameTable.Add(@"descriptive");
                id41_WeightMeasurement = Reader.NameTable.Add(@"WeightMeasurement");
                id20_medication = Reader.NameTable.Add(@"medication");
                id259_prescription = Reader.NameTable.Add(@"prescription");
                id102_dietaryfiber = Reader.NameTable.Add(@"dietary-fiber");
                id53_DisplayValue = Reader.NameTable.Add(@"DisplayValue");
                id71_CodedValue = Reader.NameTable.Add(@"CodedValue");
                id228_route = Reader.NameTable.Add(@"route");
                id275_secondaryprovider = Reader.NameTable.Add(@"secondary-provider");
                id179_treatment = Reader.NameTable.Add(@"treatment");
                id184_firstdow = Reader.NameTable.Add(@"firstdow");
                id203_activity = Reader.NameTable.Add(@"activity");
                id132_family = Reader.NameTable.Add(@"family");
                id191_systolic = Reader.NameTable.Add(@"systolic");
                id30_GoalRange = Reader.NameTable.Add(@"GoalRange");
                id26_ApproxDate = Reader.NameTable.Add(@"ApproxDate");
                id145_y = Reader.NameTable.Add(@"y");
                id268_religion = Reader.NameTable.Add(@"religion");
                id199_onsetdate = Reader.NameTable.Add(@"onset-date");
                id111_zinc = Reader.NameTable.Add(@"zinc");
                id187_outsideoperatingtemp = Reader.NameTable.Add(@"outside-operating-temp");
                id174_reaction = Reader.NameTable.Add(@"reaction");
                id50_bloodglucose = Reader.NameTable.Add(@"blood-glucose");
                id253_strength = Reader.NameTable.Add(@"strength");
                id126_display = Reader.NameTable.Add(@"display");
                id239_subscriberid = Reader.NameTable.Add(@"subscriber-id");
                id97_transfat = Reader.NameTable.Add(@"trans-fat");
                id3_ItemData = Reader.NameTable.Add(@"ItemData");
                id176_allergentype = Reader.NameTable.Add(@"allergen-type");
                id96_saturatedfat = Reader.NameTable.Add(@"saturated-fat");
                id34_ExerciseSegment = Reader.NameTable.Add(@"ExerciseSegment");
                id258_prescribed = Reader.NameTable.Add(@"prescribed");
                id210_contenttype = Reader.NameTable.Add(@"content-type");
                id54_PositiveDouble = Reader.NameTable.Add(@"PositiveDouble");
                id160_street = Reader.NameTable.Add(@"street");
                id72_Time = Reader.NameTable.Add(@"Time");
                id83_thingid = Reader.NameTable.Add(@"thing-id");
                id225_administrator = Reader.NameTable.Add(@"administrator");
                id157_suffix = Reader.NameTable.Add(@"suffix");
                id226_manufacturer = Reader.NameTable.Add(@"manufacturer");
                id243_prescribedby = Reader.NameTable.Add(@"prescribed-by");
                id18_PersonalImage = Reader.NameTable.Add(@"PersonalImage");
                id128_value = Reader.NameTable.Add(@"value");
                id266_isdeceased = Reader.NameTable.Add(@"is-deceased");
                id249_prescriptionexpiration = Reader.NameTable.Add(@"prescription-expiration");
                id110_potassium = Reader.NameTable.Add(@"potassium");
                id305_dataxml = Reader.NameTable.Add(@"data-xml");
                id207_detail = Reader.NameTable.Add(@"detail");
                id130_text = Reader.NameTable.Add(@"text");
                id17_procedure = Reader.NameTable.Add(@"procedure");
                id60_Contact = Reader.NameTable.Add(@"Contact");
                id231_anatomicsurface = Reader.NameTable.Add(@"anatomic-surface");
                id185_mmolPerL = Reader.NameTable.Add(@"mmolPerL");
                id120_folateDFE = Reader.NameTable.Add(@"folate-DFE");
                id285_tags = Reader.NameTable.Add(@"tags");
                id273_anatomiclocation = Reader.NameTable.Add(@"anatomic-location");
                id12_RelatedItem = Reader.NameTable.Add(@"RelatedItem");
                id272_organdonor = Reader.NameTable.Add(@"organ-donor");
                id291_personalimage = Reader.NameTable.Add(@"personal-image");
                id205_duration = Reader.NameTable.Add(@"duration");
                id206_offset = Reader.NameTable.Add(@"offset");
                id158_description = Reader.NameTable.Add(@"description");
                id148_timestamp = Reader.NameTable.Add(@"timestamp");
                id233_consent = Reader.NameTable.Add(@"consent");
                id237_groupnum = Reader.NameTable.Add(@"group-num");
                id218_startdate = Reader.NameTable.Add(@"start-date");
                id127_structured = Reader.NameTable.Add(@"structured");
                id155_middle = Reader.NameTable.Add(@"middle");
                id123_additionalnutritionfacts = Reader.NameTable.Add(@"additional-nutrition-facts");
                id68_Audit = Reader.NameTable.Add(@"Audit");
                id287_relatedthing = Reader.NameTable.Add(@"related-thing");
                id181_language = Reader.NameTable.Add(@"language");
                id87_dietaryitem = Reader.NameTable.Add(@"dietary-item");
                id61_Email = Reader.NameTable.Add(@"Email");
                id182_gender = Reader.NameTable.Add(@"gender");
                id112_vitaminARAE = Reader.NameTable.Add(@"vitamin-A-RAE");
                id303_created = Reader.NameTable.Add(@"created");
                id51_OneToFive = Reader.NameTable.Add(@"OneToFive");
                id279_ver = Reader.NameTable.Add(@"ver");
                id99_polyunsaturatedfat = Reader.NameTable.Add(@"polyunsaturated-fat");
                id161_city = Reader.NameTable.Add(@"city");
                id82_ItemType = Reader.NameTable.Add(@"ItemType");
                id246_substitution = Reader.NameTable.Add(@"substitution");
                id234_planname = Reader.NameTable.Add(@"plan-name");
                id238_plancode = Reader.NameTable.Add(@"plan-code");
                id101_carbohydrates = Reader.NameTable.Add(@"carbohydrates");
                id44_condition = Reader.NameTable.Add(@"condition");
                id7_PendingItem = Reader.NameTable.Add(@"PendingItem");
                id122_vitaminK = Reader.NameTable.Add(@"vitamin-K");
                id14_mealdefinition = Reader.NameTable.Add(@"meal-definition");
                id251_genericname = Reader.NameTable.Add(@"generic-name");
                id202_stopreason = Reader.NameTable.Add(@"stop-reason");
                id115_vitaminC = Reader.NameTable.Add(@"vitamin-C");
                id114_vitaminD = Reader.NameTable.Add(@"vitamin-D");
                id113_vitaminE = Reader.NameTable.Add(@"vitamin-E");
                id248_dayssupply = Reader.NameTable.Add(@"days-supply");
                id49_NonNegativeInt = Reader.NameTable.Add(@"NonNegativeInt");
                id211_thingtypeversionid = Reader.NameTable.Add(@"thing-type-version-id");
                id70_CodableValue = Reader.NameTable.Add(@"CodableValue");
                id192_diastolic = Reader.NameTable.Add(@"diastolic");
                id150_auditaction = Reader.NameTable.Add(@"audit-action");
                id106_calcium = Reader.NameTable.Add(@"calcium");
                id156_last = Reader.NameTable.Add(@"last");
                id11_ItemDataCommon = Reader.NameTable.Add(@"ItemDataCommon");
                id188_iscontroltest = Reader.NameTable.Add(@"is-control-test");
                id152_full = Reader.NameTable.Add(@"full");
                id208_segment = Reader.NameTable.Add(@"segment");
                id283_relationshiptype = Reader.NameTable.Add(@"relationship-type");
                id37_DietaryIntake = Reader.NameTable.Add(@"DietaryIntake");
                id178_treatmentprovider = Reader.NameTable.Add(@"treatment-provider");
                id180_isnegated = Reader.NameTable.Add(@"is-negated");
                id59_Person = Reader.NameTable.Add(@"Person");
                id84_ArrayOfNutritionFact = Reader.NameTable.Add(@"ArrayOfNutritionFact");
                id281_xsl = Reader.NameTable.Add(@"xsl");
                id65_BooleanValue = Reader.NameTable.Add(@"BooleanValue");
                id267_dateofdeath = Reader.NameTable.Add(@"date-of-death");
                id67_ApproxDateTime = Reader.NameTable.Add(@"ApproxDateTime");
                id213_thingtypedisplayxpath = Reader.NameTable.Add(@"thing-type-display-xpath");
                id6_ItemQueryResult = Reader.NameTable.Add(@"ItemQueryResult");
                id232_adverseevent = Reader.NameTable.Add(@"adverse-event");
                id168_phone = Reader.NameTable.Add(@"phone");
                id1_thing = Reader.NameTable.Add(@"thing");
                id58_allergy = Reader.NameTable.Add(@"allergy");
                id235_coveragetype = Reader.NameTable.Add(@"coverage-type");
                id241_subscribername = Reader.NameTable.Add(@"subscriber-name");
                id135_kg = Reader.NameTable.Add(@"kg");
                id254_frequency = Reader.NameTable.Add(@"frequency");
                id105_cholesterol = Reader.NameTable.Add(@"cholesterol");
                id177_allergencode = Reader.NameTable.Add(@"allergen-code");
                id147_versionstamp = Reader.NameTable.Add(@"version-stamp");
                id36_LengthMeasurement = Reader.NameTable.Add(@"LengthMeasurement");
                id186_glucosemeasurementtype = Reader.NameTable.Add(@"glucose-measurement-type");
                id107_iron = Reader.NameTable.Add(@"iron");
                id217_timesininterval = Reader.NameTable.Add(@"times-in-interval");
                id216_interval = Reader.NameTable.Add(@"interval");
                id39_GeneralMeasurement = Reader.NameTable.Add(@"GeneralMeasurement");
                id270_highesteducationlevel = Reader.NameTable.Add(@"highest-education-level");
                id95_totalfat = Reader.NameTable.Add(@"total-fat");
                id271_isdisabled = Reader.NameTable.Add(@"is-disabled");
                id98_monounsaturatedfat = Reader.NameTable.Add(@"monounsaturated-fat");
                id262_ethnicity = Reader.NameTable.Add(@"ethnicity");
                id173_contact = Reader.NameTable.Add(@"contact");
                id166_number = Reader.NameTable.Add(@"number");
                id42_FoodEnergyValue = Reader.NameTable.Add(@"FoodEnergyValue");
                id31_GoalAssociatedTypeInfo = Reader.NameTable.Add(@"GoalAssociatedTypeInfo");
                id200_status = Reader.NameTable.Add(@"status");
                id117_riboflavin = Reader.NameTable.Add(@"riboflavin");
                id47_NonNegativeDouble = Reader.NameTable.Add(@"NonNegativeDouble");
                id76_Hour = Reader.NameTable.Add(@"Hour");
                id255_indication = Reader.NameTable.Add(@"indication");
                id45_cholesterolprofile = Reader.NameTable.Add(@"cholesterol-profile");
                id295_blobrefurl = Reader.NameTable.Add(@"blob-ref-url");
                id269_isveteran = Reader.NameTable.Add(@"is-veteran");
                id2_Item = Reader.NameTable.Add(@"");
                id162_state = Reader.NameTable.Add(@"state");
                id193_pulse = Reader.NameTable.Add(@"pulse");
                id277_dietaryitems = Reader.NameTable.Add(@"dietary-items");
                id25_Immunization = Reader.NameTable.Add(@"Immunization");
                id278_source = Reader.NameTable.Add(@"source");
                id86_ArrayOfDietaryIntakeItem = Reader.NameTable.Add(@"ArrayOfDietaryIntakeItem");
                id198_triglyceride = Reader.NameTable.Add(@"triglyceride");
                id222_goaladditionalranges = Reader.NameTable.Add(@"goal-additional-ranges");
                id263_ssn = Reader.NameTable.Add(@"ssn");
                id69_StructuredDateTime = Reader.NameTable.Add(@"StructuredDateTime");
                id85_nutritionfact = Reader.NameTable.Add(@"nutrition-fact");
                id121_vitaminB12 = Reader.NameTable.Add(@"vitamin-B-12");
                id137_calories = Reader.NameTable.Add(@"calories");
                id219_enddate = Reader.NameTable.Add(@"end-date");
                id89_servingsize = Reader.NameTable.Add(@"serving-size");
                id190_measurementcontext = Reader.NameTable.Add(@"measurement-context");
                id175_firstobserved = Reader.NameTable.Add(@"first-observed");
                id9_Blob = Reader.NameTable.Add(@"Blob");
                id13_ItemExtension = Reader.NameTable.Add(@"ItemExtension");
                id197_totalcholesterol = Reader.NameTable.Add(@"total-cholesterol");
                id293_blobinfo = Reader.NameTable.Add(@"blob-info");
                id309_group = Reader.NameTable.Add(@"group");
                id92_when = Reader.NameTable.Add(@"when");
                id74_Second = Reader.NameTable.Add(@"Second");
                id131_code = Reader.NameTable.Add(@"code");
                id230_sequence = Reader.NameTable.Add(@"sequence");
                id286_extension = Reader.NameTable.Add(@"extension");
                id10_BlobInfo = Reader.NameTable.Add(@"BlobInfo");
                id119_vitaminB6 = Reader.NameTable.Add(@"vitamin-B-6");
                id66_Name = Reader.NameTable.Add(@"Name");
                id93_energy = Reader.NameTable.Add(@"energy");
                id28_healthgoal = Reader.NameTable.Add(@"health-goal");
                id280_logo = Reader.NameTable.Add(@"logo");
                id260_birthdate = Reader.NameTable.Add(@"birthdate");
                id167_address = Reader.NameTable.Add(@"address");
                id183_birthyear = Reader.NameTable.Add(@"birthyear");
                id62_EmailAddress = Reader.NameTable.Add(@"EmailAddress");
                id290_immunization = Reader.NameTable.Add(@"immunization");
                id215_maximum = Reader.NameTable.Add(@"maximum");
                id265_employmentstatus = Reader.NameTable.Add(@"employment-status");
                id170_organization = Reader.NameTable.Add(@"organization");
                id229_expirationdate = Reader.NameTable.Add(@"expiration-date");
                id296_legacycontentencoding = Reader.NameTable.Add(@"legacy-content-encoding");
                id261_bloodtype = Reader.NameTable.Add(@"blood-type");
                id256_datestarted = Reader.NameTable.Add(@"date-started");
                id78_Day = Reader.NameTable.Add(@"Day");
                id73_Millisecond = Reader.NameTable.Add(@"Millisecond");
                id189_normalcy = Reader.NameTable.Add(@"normalcy");
                id52_BloodGlucoseMeasurement = Reader.NameTable.Add(@"BloodGlucoseMeasurement");
                id118_niacin = Reader.NameTable.Add(@"niacin");
                id221_targetrange = Reader.NameTable.Add(@"target-range");
                id129_units = Reader.NameTable.Add(@"units");
                id124_name = Reader.NameTable.Add(@"name");
                id308_unprocessedthingkeyinfo = Reader.NameTable.Add(@"unprocessed-thing-key-info");
                id274_primaryprovider = Reader.NameTable.Add(@"primary-provider");
                id46_ConcentrationValue = Reader.NameTable.Add(@"ConcentrationValue");
                id298_blob = Reader.NameTable.Add(@"blob");
                id40_StructuredMeasurement = Reader.NameTable.Add(@"StructuredMeasurement");
                id209_size = Reader.NameTable.Add(@"size");
                id43_person = Reader.NameTable.Add(@"person");
                id276_mealtype = Reader.NameTable.Add(@"meal-type");
                id307_updatedenddate = Reader.NameTable.Add(@"updated-end-date");
                id64_Address = Reader.NameTable.Add(@"Address");
                id139_time = Reader.NameTable.Add(@"time");
                id88_fooditem = Reader.NameTable.Add(@"food-item");
                id100_protein = Reader.NameTable.Add(@"protein");
                id196_hdl = Reader.NameTable.Add(@"hdl");
                id104_sodium = Reader.NameTable.Add(@"sodium");
                id109_phosphorus = Reader.NameTable.Add(@"phosphorus");
                id133_type = Reader.NameTable.Add(@"type");
                id195_ldl = Reader.NameTable.Add(@"ldl");
                id48_bloodpressure = Reader.NameTable.Add(@"blood-pressure");
                id146_d = Reader.NameTable.Add(@"d");
                id63_Phone = Reader.NameTable.Add(@"Phone");
                id91_meal = Reader.NameTable.Add(@"meal");
                id38_NutritionFact = Reader.NameTable.Add(@"NutritionFact");
                id220_associatedtypeinfo = Reader.NameTable.Add(@"associated-type-info");
                id77_Date = Reader.NameTable.Add(@"Date");
                id32_File = Reader.NameTable.Add(@"File");
                id21_Prescription = Reader.NameTable.Add(@"Prescription");
                id24_payer = Reader.NameTable.Add(@"payer");
                id240_personcode = Reader.NameTable.Add(@"person-code");
                id214_minimum = Reader.NameTable.Add(@"minimum");
                id55_basic = Reader.NameTable.Add(@"basic");
                id5_anyType = Reader.NameTable.Add(@"anyType");
                id282_clientthingid = Reader.NameTable.Add(@"client-thing-id");
                id19_personal = Reader.NameTable.Add(@"personal");
                id136_unitscode = Reader.NameTable.Add(@"units-code");
                id27_height = Reader.NameTable.Add(@"height");
                id242_subscriberdob = Reader.NameTable.Add(@"subscriber-dob");
                id172_id = Reader.NameTable.Add(@"id");
                id94_energyfromfat = Reader.NameTable.Add(@"energy-from-fat");
                id140_tz = Reader.NameTable.Add(@"tz");
                id143_s = Reader.NameTable.Add(@"s");
                id138_date = Reader.NameTable.Add(@"date");
                id289_file = Reader.NameTable.Add(@"file");
                id141_h = Reader.NameTable.Add(@"h");
                id163_postcode = Reader.NameTable.Add(@"postcode");
                id15_DietaryIntakeItem = Reader.NameTable.Add(@"DietaryIntakeItem");
                id4_RecordQueryResponse = Reader.NameTable.Add(@"RecordQueryResponse");
                id142_m = Reader.NameTable.Add(@"m");
                id224_administrationdate = Reader.NameTable.Add(@"administration-date");
                id236_carrierid = Reader.NameTable.Add(@"carrier-id");
                id294_contentlength = Reader.NameTable.Add(@"content-length");
                id169_email = Reader.NameTable.Add(@"email");
                id154_first = Reader.NameTable.Add(@"first");
                id33_exercise = Reader.NameTable.Add(@"exercise");
                id194_irregularheartbeat = Reader.NameTable.Add(@"irregular-heartbeat");
                id108_magnesium = Reader.NameTable.Add(@"magnesium");
                id284_note = Reader.NameTable.Add(@"note");
                id103_sugars = Reader.NameTable.Add(@"sugars");
                id16_weight = Reader.NameTable.Add(@"weight");
                id8_ItemDataBlob = Reader.NameTable.Add(@"ItemDataBlob");
                id29_GoalRecurrence = Reader.NameTable.Add(@"GoalRecurrence");
                id75_Minute = Reader.NameTable.Add(@"Minute");
                id35_StructuredNameValue = Reader.NameTable.Add(@"StructuredNameValue");
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
            protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
                return new XmlSerializationReader1();
            }
            protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
                return new XmlSerializationWriter1();
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class RecordItemSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"thing", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write83_thing(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read83_thing(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ItemDataSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ItemData", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write84_ItemData(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read84_ItemData(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class RecordQueryResponseSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"RecordQueryResponse", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write85_RecordQueryResponse(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read85_RecordQueryResponse(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"anyType", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write86_anyType(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read86_anyType(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
            public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
            public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
            System.Collections.IDictionary readMethods = null;
            public override System.Collections.IDictionary ReadMethods {
                get {
                    if (readMethods == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                        _tmp[@"HealthVault.Types.RecordItem::"] = @"Read83_thing";
                        _tmp[@"HealthVault.Types.ItemData::"] = @"Read84_ItemData";
                        _tmp[@"HealthVault.Types.RecordQueryResponse::"] = @"Read85_RecordQueryResponse";
                        _tmp[@"System.Object::"] = @"Read86_anyType";
                        _tmp[@"System.Object::"] = @"Read87_anyType";
                        if (readMethods == null) readMethods = _tmp;
                    }
                    return readMethods;
                }
            }
            System.Collections.IDictionary writeMethods = null;
            public override System.Collections.IDictionary WriteMethods {
                get {
                    if (writeMethods == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                        _tmp[@"HealthVault.Types.RecordItem::"] = @"Write83_thing";
                        _tmp[@"HealthVault.Types.ItemData::"] = @"Write84_ItemData";
                        _tmp[@"HealthVault.Types.RecordQueryResponse::"] = @"Write85_RecordQueryResponse";
                        _tmp[@"System.Object::"] = @"Write86_anyType";
                        _tmp[@"System.Object::"] = @"Write87_anyType";
                        if (writeMethods == null) writeMethods = _tmp;
                    }
                    return writeMethods;
                }
            }
            System.Collections.IDictionary typedSerializers = null;
            public override System.Collections.IDictionary TypedSerializers {
                get {
                    if (typedSerializers == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                        _tmp.Add(@"System.Object::", new ObjectSerializer());
                        _tmp.Add(@"HealthVault.Types.RecordQueryResponse::", new RecordQueryResponseSerializer());
                        _tmp.Add(@"HealthVault.Types.RecordItem::", new RecordItemSerializer());
                        _tmp.Add(@"HealthVault.Types.ItemData::", new ItemDataSerializer());
                        if (typedSerializers == null) typedSerializers = _tmp;
                    }
                    return typedSerializers;
                }
            }
            public override System.Boolean CanSerialize(System.Type type) {
                if (type == typeof(global::HealthVault.Types.RecordItem)) return true;
                if (type == typeof(global::HealthVault.Types.ItemData)) return true;
                if (type == typeof(global::HealthVault.Types.RecordQueryResponse)) return true;
                if (type == typeof(global::System.Object)) return true;
                if (type == typeof(global::System.Reflection.TypeInfo)) return true;
                return false;
            }
            public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
                if (type == typeof(global::HealthVault.Types.RecordItem)) return new RecordItemSerializer();
                if (type == typeof(global::HealthVault.Types.ItemData)) return new ItemDataSerializer();
                if (type == typeof(global::HealthVault.Types.RecordQueryResponse)) return new RecordQueryResponseSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                return null;
            }
            public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public static class ActivatorHelper {
            public static object CreateInstance(System.Type type) {
                System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
                foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                    if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                        return ci.Invoke(null);
                    }
                }
                return System.Activator.CreateInstance(type);
            }
        }
    }
