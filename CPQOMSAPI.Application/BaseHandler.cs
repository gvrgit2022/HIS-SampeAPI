using AutoMapper;
using SampleAPI.Infrastructure.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI.Application
{
    public class BaseHandler
    {
        
        protected readonly testContext  testContext;
        protected readonly IMapper Mapper;
        protected readonly IConfigurationProvider ConfigurationProvider;
        private testContext context;

        public BaseHandler(testContext context, IMapper mapper)
        {
            testContext = context;
            Mapper = mapper;
            ConfigurationProvider = mapper.ConfigurationProvider;
        }

        
        


    }
}
