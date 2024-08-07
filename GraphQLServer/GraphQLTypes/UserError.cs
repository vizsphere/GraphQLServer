﻿using GraphQLServer.Models;

namespace GraphQLServer.GraphQLTypes
{
    internal class UserError : Speaker
    {
        private string v1;
        private string v2;

        public UserError(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}