﻿using VKSharp.Core.Enums;

namespace VKSharp.Data.Parameters {
    public class UsersSearchParams {
        public UsersSearchParams( string query = "", SearchSortOrder sort = SearchSortOrder.ByRating,
                                  ushort? offset = null, ushort? count = null, UserFields fields = UserFields.None,
                                  uint? cityId = null, uint? countryId = null, string hometown = "", uint? universityCountryId = null,
                                  uint? universityId = null, uint? universityYear = null, Sex? sex = null, Relation? relation = null,
                                  byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null,
                                  ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, uint? schoolCountryId = null,
                                  uint? schoolCityId = null, uint? schoolId = null, uint? schoolYear = null, string religion = "",
                                  string interests = "", string company = "", string position = "", uint? groupId = null ) {
            Query = query;
            Sort = sort;
            Offset = offset;
            Count = count;
            Fields = fields;
            CityId = cityId;
            CountryId = countryId;
            Hometown = hometown;
            UniversityCountryId = universityCountryId;
            UniversityId = universityId;
            UniversityYear = universityYear;
            Sex = sex;
            Relation = relation;
            AgeFrom = ageFrom;
            AgeTo = ageTo;
            BirthDay = birthDay;
            BirthMonth = birthMonth;
            BirthYear = birthYear;
            Online = online;
            HasPhoto = hasPhoto;
            SchoolCountryId = schoolCountryId;
            SchoolCityId = schoolCityId;
            SchoolId = schoolId;
            SchoolYear = schoolYear;
            Religion = religion;
            Interests = interests;
            Company = company;
            Position = position;
            GroupId = groupId;
        }

        public string Query { get; private set; }

        public SearchSortOrder Sort { get; private set; }

        public ushort? Offset { get; private set; }

        public ushort? Count { get; private set; }

        public UserFields Fields { get; private set; }

        public uint? CityId { get; private set; }

        public uint? CountryId { get; private set; }

        public string Hometown { get; private set; }

        public uint? UniversityCountryId { get; private set; }

        public uint? UniversityId { get; private set; }

        public uint? UniversityYear { get; private set; }

        public Sex? Sex { get; private set; }

        public Relation? Relation { get; private set; }

        public byte? AgeFrom { get; private set; }

        public byte? AgeTo { get; private set; }

        public byte? BirthDay { get; private set; }

        public byte? BirthMonth { get; private set; }

        public ushort? BirthYear { get; private set; }

        public bool? Online { get; private set; }

        public bool? HasPhoto { get; private set; }

        public uint? SchoolCountryId { get; private set; }

        public uint? SchoolCityId { get; private set; }

        public uint? SchoolId { get; private set; }

        public uint? SchoolYear { get; private set; }

        public string Religion { get; private set; }

        public string Interests { get; private set; }

        public string Company { get; private set; }

        public string Position { get; private set; }

        public uint? GroupId { get; private set; }
    }
}