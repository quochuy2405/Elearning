﻿using BE_Elearing.Access;
using BE_Elearing.Models;

namespace BE_Elearing.Services
{
    public class LearningService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public LearningService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Learning> GetAll()
        {
            return _context.Learnings.ToList();
        }
    }
}
