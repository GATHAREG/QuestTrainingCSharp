using ConsoleAppBookMemberGeneric.Data;
using ConsoleAppBookMemberGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookMemberGeneric.Repositories
{
    internal class MemberRepository
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var member = DataStore.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = member,
            };
        }
        public GenericResponse<Member> GetByName(string name)
        {
            var memberr = DataStore.Members.FirstOrDefault(x => x.Name == name);
            if (memberr == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = memberr,
            };

        }
        public GenericResponse<Member> GetByEmail(string email)

        {
            var memb = DataStore.Members.FirstOrDefault(x =>x.Email == email);
            if (memb == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",

                };
            }
            return new GenericResponse<Member>
            {
                Success = true,
                Data = memb,
            };

        }
    }
}
