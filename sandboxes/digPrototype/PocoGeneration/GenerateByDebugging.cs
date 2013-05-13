



using System;

namespace Entities 
{
    
        class Addresses 
        {
                                public int AddressesId { get; set; }
                                    public string Description { get; set; }
                                    public string AddressLine1 { get; set; }
                                    public string AddressLine2 { get; set; }
                                    public string AddressLine3 { get; set; }
                                    public string City { get; set; }
                                    public string State { get; set; }
                                    public string PostalCode { get; set; }
                                    public string Zip { get; set; }
                                    public string Country { get; set; }
                                    public string Geocode { get; set; }
                                    public DateTime CreatedDate { get; set; }
                                    public int CreatedById { get; set; }
                                    public DateTime ModifiedDate { get; set; }
                                    public int ModifiedById { get; set; }
                                    public bool IsActive { get; set; }
                        }
        
        class Divisions 
        {
                                public int DivisionsID { get; set; }
                                    public int refCompositionId { get; set; }
                        }
        
        class Events 
        {
                                public int EventsId { get; set; }
                                    public int refEventTypeId { get; set; }
                                    public int LocationsId { get; set; }
                                    public string Name { get; set; }
                                    public DateTime DateStart { get; set; }
                                    public DateTime DateEnd { get; set; }
                                    public string Host { get; set; }
                                    public string Manager { get; set; }
                                    public string Sponsors { get; set; }
                                    public string Description { get; set; }
                                    public DateTime CreatedDate { get; set; }
                                    public int CreatedById { get; set; }
                                    public DateTime ModifiedDate { get; set; }
                                    public int ModifiedById { get; set; }
                                    public bool IsActive { get; set; }
                        }
        
        class Leagues 
        {
                                public int LeaguesId { get; set; }
                                    public int refSportsId { get; set; }
                                    public int EventsId { get; set; }
                                    public int refCompositionsId { get; set; }
                                    public int refSurfacesId { get; set; }
                                    public string Name { get; set; }
                        }
        
        class Locations 
        {
                                public int LocationsId { get; set; }
                                    public string Name { get; set; }
                                    public string Nickname { get; set; }
                                    public int AddressesId { get; set; }
                                    public string Phone1 { get; set; }
                                    public string Phone2 { get; set; }
                                    public string Url { get; set; }
                                    public string Email1 { get; set; }
                                    public string Email2 { get; set; }
                                    public string Logo { get; set; }
                                    public string Manager { get; set; }
                                    public string Description { get; set; }
                                    public string Notes { get; set; }
                                    public string Geocode { get; set; }
                                    public int refLocationTypesId { get; set; }
                                    public DateTime CreatedDate { get; set; }
                                    public int CreatedById { get; set; }
                                    public DateTime ModifiedDate { get; set; }
                                    public int ModifiedById { get; set; }
                                    public bool IsActive { get; set; }
                        }
        
        class People 
        {
                                public int PlayersId { get; set; }
                                    public int UsersId { get; set; }
                                    public string Name { get; set; }
                                    public string Url { get; set; }
                                    public string Phone1 { get; set; }
                                    public string Phone2 { get; set; }
                                    public string Email1 { get; set; }
                                    public string Email2 { get; set; }
                        }
        
        class Players 
        {
                                public int PlayersId { get; set; }
                                    public int UsersId { get; set; }
                                    public string Name { get; set; }
                                    public string Url { get; set; }
                                    public string Phone1 { get; set; }
                                    public string Phone2 { get; set; }
                                    public string Email1 { get; set; }
                                    public string Email2 { get; set; }
                        }
        
        class refCompositions 
        {
                                public int refCompositionsId { get; set; }
                                    public string Name { get; set; }
                                    public string LongName { get; set; }
                                    public bool IsCoed { get; set; }
                                    public int MaximumPlayers { get; set; }
                                    public int MinimumPlayers { get; set; }
                                    public int PlayersPerTeam { get; set; }
                                    public int MinimumMen { get; set; }
                                    public int MinimumWomen { get; set; }
                                    public int MaximumMen { get; set; }
                                    public int MaximumWomen { get; set; }
                        }
        
        class refEventTypes 
        {
                                public int refEventTypesId { get; set; }
                                    public string Name { get; set; }
                                    public string Description { get; set; }
                                    public bool Active { get; set; }
                        }
        
        class refLocationTypes 
        {
                                public int refLocationTypesId { get; set; }
                                    public string Description { get; set; }
                        }
        
        class refSkillLevels 
        {
                                public int refSkillLevels { get; set; }
                                    public int refSportsId { get; set; }
                                    public string Name { get; set; }
                                    public string AlternateName { get; set; }
                                    public string Description { get; set; }
                        }
        
        class refSports 
        {
                                public int refSportsId { get; set; }
                                    public string Name { get; set; }
                        }
        
        class refSurfaces 
        {
                                public int refSurfacesId { get; set; }
                                    public string Name { get; set; }
                        }
        
        class refUserTypes 
        {
                                public int refUserTypesId { get; set; }
                                    public string Name { get; set; }
                        }
        
        class Secures 
        {
                                public int Id { get; set; }
                                    public int user_Id { get; set; }
                        }
        
        class sysdiagrams 
        {
                                public  name { get; set; }
                                    public int principal_id { get; set; }
                                    public int diagram_id { get; set; }
                                    public int version { get; set; }
                                    public Byte[] definition { get; set; }
                        }
        
        class Teams 
        {
                                public int TeamsId { get; set; }
                                    public int sport_id { get; set; }
                                    public string Name { get; set; }
                                    public string Logo { get; set; }
                        }
        
        class Tournaments 
        {
                                public int TournamentsId { get; set; }
                                    public int EventsId { get; set; }
                                    public int refCompositionsId { get; set; }
                                    public int refSportsId { get; set; }
                                    public int refSkillLevelsId { get; set; }
                                    public bool CashPrize { get; set; }
                                    public bool OtherPrize { get; set; }
                                    public string PrizeDescription { get; set; }
                                    public string Name { get; set; }
                                    public string Description { get; set; }
                                    public DateTime DateStart { get; set; }
                                    public DateTime DateEnd { get; set; }
                                    public int Priority { get; set; }
                                    public DateTime CreatedDate { get; set; }
                                    public int CreatedById { get; set; }
                                    public DateTime ModifiedDate { get; set; }
                                    public int ModifiedById { get; set; }
                                    public bool IsActive { get; set; }
                                    public Decimal EntranceFee { get; set; }
                        }
        
        class Users 
        {
                                public int UsersId { get; set; }
                                    public int refUserTypeId { get; set; }
                                    public string Name { get; set; }
                                    public string Password { get; set; }
                                    public string Email1 { get; set; }
                                    public string Email2 { get; set; }
                                    public DateTime Created { get; set; }
                                    public DateTime LastLogin { get; set; }
                                    public bool LoginLocked { get; set; }
                                    public DateTime LoginLockedDate { get; set; }
                                    public  LoginGuid { get; set; }
                        }
        
}



