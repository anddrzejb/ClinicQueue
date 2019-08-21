using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicQueue.Auth
{
    public static class Policies
    {
        public const string CanUpdateQueue = "CanUpdateQueue";
        public const string CanMoveQueue = "CanMoveQueue";
        public const string IsDoctor = "IsDoctor";

        public static AuthorizationPolicy CanUpdateQueuePolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                                                   .RequireRole("Admin", "Clerk", "Doctor")
                                                   .Build();
        }

        public static AuthorizationPolicy CanMoveQueuePolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                                                   .RequireRole("Admin", "Doctor")
                                                   .Build();
        }

        public static AuthorizationPolicy IsDoctorPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                                                   .RequireRole("Doctor")
                                                   .Build();
        }
    }
}
