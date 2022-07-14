﻿using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Classes
{
    public class GetDetails
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public GetDetails(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }

        public string getJobName(int jobId, int parameter)
        {
            var dbName = _databaseContext.Jobs.Where(x => x.id == jobId).FirstOrDefault();
            if(parameter == 0)
            {
                return dbName.jobTitle.ToString();
            }
            else if(parameter == 1)
            {
                return dbName.jobKeywords.ToString();
            }
            else if(parameter == 2)
            {
                return dbName.jobDescription.ToString();
            }
            else if(parameter == 3)
            {
                return dbName.jobContent.ToString();
            }
            else
            {
                return dbName.jobSlug.ToString();
            }
        }
    }
}
