﻿using eTicketsQ.Data.Base;
using eTicketsQ.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsQ.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>,  IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context) { }

    }
}
