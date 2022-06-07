using AutoMapper;

using SampleAPI.Infrastructure.Models.Test;
using SampleAPI.Application.Test.Model; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<TutorialsTbl, TutorialsTblModelcs>();
            //CreateMap<Order, OrderModel>();
            //CreateMap<OrderItem, OrderItemModel>();//.ForMember(dest => dest.FrequencyCodeNavigation, op => op.Ignore());
            //CreateMap<OrderGroup, OrderGroupModel>();

        }
    }
}
