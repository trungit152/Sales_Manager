﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{
    public class Person : IComparable<Person>
    {
        [JsonProperty("id")]
        public string PersonId { get; set; }
        [JsonProperty("name")]
        public FullName FullName { get; set; }
        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        public Person()
        {

        }

        public Person(string id)
        {
            PersonId = id;
        }

        public Person(string personId, string fullName, DateTime birthDate, 
            string address, string phoneNumber) : this(personId)
        {
            FullName = new FullName(fullName);
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   PersonId == person.PersonId;
        }

        public override int GetHashCode()
        {
            return -1255590651 + EqualityComparer<string>.Default.GetHashCode(PersonId);
        }

        public int CompareTo(Person other)
        {
            return PersonId.CompareTo(other.PersonId);
        }
    }
}
