﻿using IPMO_PracticeManagementWebApp.Model;
using System.Data;

namespace IPMO_PracticeManagementWebApp.DataLayer
{
    public class DatabaseQueryManager
    {
        DatabaseManager databaseManager;
        public DatabaseQueryManager()
        {
            databaseManager = new DatabaseManager();
        }

        public DataTable QueryToGetDatabaseFieldsForPupil()
        {
            string query = @"SELECT COLUMN_NAME
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = N'PupilInformation' 
                            AND COLUMN_NAME != 'UniqueId'";

            return databaseManager.GetInformationHeaders(query);

        }
        public DataTable QueryToGetDatabaseFieldsForRiskFactors()
        {
            string query = @"SELECT COLUMN_NAME
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = N'RiskFactors' 
                            AND COLUMN_NAME != 'UniqueId'";

            return databaseManager.GetInformationHeaders(query);
        }
        public DataTable QueryToGetDatabaseFieldsForSchoolResults()
        {
            string query = @"SELECT COLUMN_NAME
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = N'SchoolResults' 
                            AND COLUMN_NAME != 'UniqueId'";

            return databaseManager.GetInformationHeaders(query);
        }

        public string QueryToAddUpdateDeleteDataForPupil(PupilInformation pupilInfo, string operation = "")
        {
            string query = string.Empty;

            switch (operation)
            {
                case "Add":
                    query = "insert into PupilInformation values('" + pupilInfo.FirstName + "','" + pupilInfo.SecondName + "','" + pupilInfo.Surname + "','" + pupilInfo.AddressStreet + "','" + pupilInfo.HouseNumber + "','" + pupilInfo.Zip + "','" + pupilInfo.City + "','" + pupilInfo.Mobile + "','" + pupilInfo.Email + "','" + pupilInfo.Id + "','" + pupilInfo.PassportNumber + "','" + pupilInfo.FirstNameParent1 + "','" + pupilInfo.SurnameParent1 + "','" + pupilInfo.AddressStreetParent1 + "','" + pupilInfo.HouseNumberParent1 + "','" + pupilInfo.ZipParent1 + "','" + pupilInfo.CityParent1 + "','" + pupilInfo.MobileParent1 + "','" + pupilInfo.LandlineParent1 + "','" + pupilInfo.IdParent1 + "','" + pupilInfo.EmailParent1 + "','" + pupilInfo.PassportNumberParent1 + "','" + pupilInfo.ParentalAuthorityParent1 + "','" + pupilInfo.FirstNameParent2 + "','" + pupilInfo.SurnameParent2 + "','" + pupilInfo.AddressStreetParent2 + "','" + pupilInfo.HouseNumberParent2 + "','" + pupilInfo.ZipParent2 + "','" + pupilInfo.CityParent2 + "','" + pupilInfo.MobileParent2 + "','" + pupilInfo.LandlineParent2 + "','" + pupilInfo.IdParent2 + "','" + pupilInfo.EmailParent2 + "','" + pupilInfo.PassportNumberParent2 + "','" + pupilInfo.ParentalAuthorityParent2 + "','" + pupilInfo.FamilyGuardian + "','" + pupilInfo.NameFamilyGuardian + "','" + pupilInfo.OrganizationFamilyGuardian + "','" + pupilInfo.EmailFamilyGuardian + "','" + pupilInfo.MobilePhoneFamilyGuardian + "','" + pupilInfo.YouthProtector + "','" + pupilInfo.NameYouthProtector + "','" + pupilInfo.OrganizationYouthProtector + "','" + pupilInfo.EmailAddressYouthProtector + "','" + pupilInfo.MobileYouthProtector + "','" + pupilInfo.ImportantInformationOthers + "')";
                    break;
                case "Update":
                    break;
                case "Delete":
                    query = "delete from PupilInformation where Id = '" + pupilInfo.Id + "'";
                    break;
            }

            return databaseManager.AddUpdateDeleteData(query).Equals("Success") ? "Data for Pupil Registration added successfully." : "Error while adding data for Pupil Registration."; ;
        }

        public string QueryToAddUpdateDeleteDataForRiskFactors(RiskFactors riskFactors, string operation = "")
        {
            string query = string.Empty;

            switch (operation)
            {
                case "Add":
                    query = "insert into RiskFactors values('" + riskFactors.PupilUniqueId + "','" + riskFactors.Cognitive_strength_1 + "','" + riskFactors.Cognitive_strength_2 + "','" + riskFactors.Cognitive_strength_3 + "','" + riskFactors.Cognitive_strenght_4 + "','" + riskFactors.Cognitive_weakness_1 + "','" + riskFactors.Cognitive_weakness_2 + "','" + riskFactors.Cognitive_weakness_3 + "','" + riskFactors.Cognitive_weakness_4 + "','" + riskFactors.Positive_learning_attitude_1 + "','" + riskFactors.Positive_learning_attitude_2 + "','" + riskFactors.Negative_learning_attitude_1 + "','" + riskFactors.Negative_learning_attitude_2 + "','" + riskFactors.Social_strength_1 + "','" + riskFactors.Socia_strenght_2 + "','" + riskFactors.Social_weakness_1 + "','" + riskFactors.Social_weakness_2 + "','" + riskFactors.Communicatie_strength_1 + "','" + riskFactors.Communicatie_strength_2 + "','" + riskFactors.Communicative_weakness_1 + "','" + riskFactors.Communicative_weakness_2 + "','" + riskFactors.Behavioral_strengths_1 + "','" + riskFactors.Behavioral_strength_2 + "','" + riskFactors.Behavioral_strengths_3 + "','" + riskFactors.Behavioral_weakness_1 + "','" + riskFactors.Behavioral_weakness_2 + "','" + riskFactors.Behavioral_weakness_3 + "','" + riskFactors.Emotional_strength_1 + "','" + riskFactors.Emotional_strength_2 + "','" + riskFactors.Emotional_strength_3 + "','" + riskFactors.Emotional_weakness_1 + "','" + riskFactors.Emotional_weakness_2 + "','" + riskFactors.Emotional_weakness_3 + "','" + riskFactors.Moral_strength_1 + "','" + riskFactors.Moral_strength_2 + "','" + riskFactors.Moral_risk_factor_1 + "','" + riskFactors.Moral_risk_factor_2 + "','" + riskFactors.Motor_or_sportive_strength_1 + "','" + riskFactors.Mottor_or_sportive_strength_2 + "','" + riskFactors.Motor_or_sportive_weakness_1 + "','" + riskFactors.Motor_or_sportive_weakness_2 + "','" + riskFactors.CREATIVE_or_ART_STRENGTHS + "','" + riskFactors.CREATIVE_or_ART_WEAKNESSES + "','" + riskFactors.LEISURE_ACTVITIY_PRESENT + "','" + riskFactors.LEISURE_ACTIVITY_NOT_PRESENT + "','" + riskFactors.DAILY_STRUCTURE_PRESENT + "','" + riskFactors.DAILY_STRUCTURE_NOT_PRESENT + "','" + riskFactors.PROTECTIVE_FAMILY_FACTORS + "','" + riskFactors.RISK_FAMILY_FACTORS + "','" + riskFactors.Integrative_summary_of_the_pupil + "')";
                    break;
                case "Update":
                    break;
                case "Delete":
                    query = "delete from RiskFactors where PupilId = '" + riskFactors.PupilUniqueId + "'";
                    break;
            }

            return databaseManager.AddUpdateDeleteData(query).Equals("Success") ? "Data for Risk Factors added successfully." : "Error while adding data for Risk Factors.";
        }

        public string QueryToAddUpdateDeleteDataForSchoolResults(SchoolResults schoolResults, string operation = "")
        {
            string query = string.Empty;

            switch (operation)
            {
                case "Add":
                    query = "insert into SchoolResults values('" + schoolResults.PupilUniqueId + "','" + schoolResults.CITO_group1first_READING + "','" + schoolResults.DLE_group1first_READING + "','" + schoolResults.CITO_group1second_READING + "','" + schoolResults.DLE_group1second_READING + "','" + schoolResults.CITO_group2first_READING + "','" + schoolResults.DLE_group2first_READING + "','" + schoolResults.CITO_group2second_READING + "','" + schoolResults.DLE_group2second_READING + "','" + schoolResults.CITO_group3first_READING + "','" + schoolResults.DLE_group3first_READING + "','" + schoolResults.CITO_group3second_READING + "','" + schoolResults.DLE_group3second_READING + "','" + schoolResults.CITO_group4first_READING + "','" + schoolResults.DLE_group4first_READING + "','" + schoolResults.CITO_group4second_READING + "','" + schoolResults.DLE_group4second_READING + "','" + schoolResults.CITO_group5first_READING + "','" + schoolResults.DLE_group5first_READING + "','" + schoolResults.CITO_group5second_READING + "','" + schoolResults.DLE_group5second_READING + "','" + schoolResults.CITO_group6first_READING + "','" + schoolResults.DLE_group6first_READING + "','" + schoolResults.CITO_group6second_READING + "','" + schoolResults.DLE_group6second_READING + "','" + schoolResults.CITO_group7first_READING + "','" + schoolResults.DLE_group7first_READING + "','" + schoolResults.CITO_group7second_READING + "','" + schoolResults.DLE_group7second_READING + "','" + schoolResults.CITO_group8first_READING + "','" + schoolResults.DLE_group8first_READING + "','" + schoolResults.CITO_group8second_READING + "','" + schoolResults.DLE_group8second_READING + "','" + schoolResults.Summary_cito_or_dle_results_READING + "','" + schoolResults.CITO_group1first_WRITING + "','" + schoolResults.DLE_group1first_WRITING + "','" + schoolResults.CITO_group1second_WRITING + "','" + schoolResults.DLE_group1second_WRITING + "','" + schoolResults.CITO_group2first_WRITING + "','" + schoolResults.DLE_group2first_WRITING + "','" + schoolResults.CITO_group2second_WRITING + "','" + schoolResults.DLE_group2second_WRITING + "','" + schoolResults.CITO_group3first_WRITING + "','" + schoolResults.DLE_group3first_WRITING + "','" + schoolResults.CITO_group3second_WRITING + "','" + schoolResults.DLE_group3second_WRITING + "','" + schoolResults.CITO_group4first_WRITING + "','" + schoolResults.DLE_group4first_WRITING + "','" + schoolResults.CITO_group4second_WRITING + "','" + schoolResults.DLE_group4second_WRITING + "','" + schoolResults.CITO_group5first_WRITING + "','" + schoolResults.DLE_group5first_WRITING + "','" + schoolResults.CITO_group5second_WRITING + "','" + schoolResults.DLE_group5second_WRITING + "','" + schoolResults.CITO_group6first_WRITING + "','" + schoolResults.DLE_group6first_WRITING + "','" + schoolResults.CITO_group6second_WRITING + "','" + schoolResults.DLE_group6second_WRITING + "','" + schoolResults.CITO_group7first_WRITING + "','" + schoolResults.DLE_group7first_WRITING + "','" + schoolResults.CITO_group7second_WRITING + "','" + schoolResults.DLE_group7second_WRITING + "','" + schoolResults.CITO_group8first_WRITING + "','" + schoolResults.DLE_group8first_WRITING + "','" + schoolResults.CITO_group8second_WRITING + "','" + schoolResults.DLE_group8second_WRITING + "','" + schoolResults.Summary_cito_or_dle_results_WRITING + "','" + schoolResults.CITO_group1first_ARITHMETIC + "','" + schoolResults.DLE_group1first_ARITHMETIC + "','" + schoolResults.CITO_group1second_ARITHMETIC + "','" + schoolResults.DLE_group1second_ARITHMETIC + "','" + schoolResults.CITO_group2first_ARITHMETIC + "','" + schoolResults.DLE_group2first_ARITHMETIC + "','" + schoolResults.CITO_group2second_ARITHMETIC + "','" + schoolResults.DLE_group2second_ARITHMETIC + "','" + schoolResults.CITO_group3first_ARITHMETIC + "','" + schoolResults.DLE_group3first_ARITHMETIC + "','" + schoolResults.CITO_group3second_ARITHMETIC + "','" + schoolResults.DLE_group3second_ARITHMETIC + "','" + schoolResults.CITO_group4first_ARITHMETIC + "','" + schoolResults.DLE_group4first_ARITHMETIC + "','" + schoolResults.CITO_group4second_ARITHMETIC + "','" + schoolResults.DLE_group4second_ARITHMETIC + "','" + schoolResults.CITO_group5first_ARITHMETIC + "','" + schoolResults.DLE_group5first_ARITHMETIC + "','" + schoolResults.CITO_group5second_ARITHMETIC + "','" + schoolResults.DLE_group5second_ARITHMETIC + "','" + schoolResults.CITO_group6first_ARITHMETIC + "','" + schoolResults.DLE_group6first_ARITHMETIC + "','" + schoolResults.CITO_group6second_ARITHMETIC + "','" + schoolResults.DLE_group6second_ARITHMETIC + "','" + schoolResults.CITO_group7first_ARITHMETIC + "','" + schoolResults.DLE_group7first_ARITHMETIC + "','" + schoolResults.CITO_group7second_ARITHMETIC + "','" + schoolResults.DLE_group7second_ARITHMETIC + "','" + schoolResults.CITO_group8first_ARITHMETIC + "','" + schoolResults.DLE_group8first_ARITHMETIC + "','" + schoolResults.CITO_group8second_ARITHMETIC + "','" + schoolResults.DLE_group8second_ARITHMETIC + "','" + schoolResults.Summary_cito_or_dle_results_ARITHMETIC + "','" + schoolResults.Integrative_summary_writing_reading_arithmetic + "','" + schoolResults.School_advice_previous_school + "','" + schoolResults.Any_particulars + "')";
                    break;
                case "Update":
                    break;
                case "Delete":
                    query = "delete from SchoolResults where PupilId = '" + schoolResults.PupilUniqueId + "'";
                    break;
            }

            return databaseManager.AddUpdateDeleteData(query).Equals("Success") ? "Data for School Results added successfully." : "Error while adding data for School Results."; ;
        }

        public DataTable QueryToRetrieveDataFromPupilRegistration(string pupilUniqueId = "")
        {
            string query = string.Empty;

            if (!string.IsNullOrEmpty(pupilUniqueId))
            {
                query = "select * from PupilInformation where Id= '" + pupilUniqueId + "'";
            }
            else
            {
                query = "select * from PupilInformation";
            }

            return databaseManager.GetInformationHeaders(query);
        }

        public DataTable QueryToRetrieveDataFromRiskFactors(string pupilUniqueId="")
        {
            string query = string.Empty;

            if (!string.IsNullOrEmpty(pupilUniqueId))
            {
                query = "select * from RiskFactors where PupilUniqueId= '" + pupilUniqueId + "'";
            }
            else
            {
                query = "select * from RiskFactors";
            }

            return databaseManager.GetInformationHeaders(query);
        }

        public DataTable QueryToRetrieveDataFromSchoolResults(string pupilUniqueId="")
        {
            string query = string.Empty;

            if (!string.IsNullOrEmpty(pupilUniqueId))
            {
                query = "select * from SchoolResults where PupilUniqueId= '" + pupilUniqueId + "'";
            }
            else
            {
                query = "select * from SchoolResults";
            }

            return databaseManager.GetInformationHeaders(query);
        }
    }
}