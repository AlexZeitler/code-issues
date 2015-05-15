using AutoMapper;

namespace AutoMapperObjectReference { 
	public class CustomerProfile : Profile {
		protected override void Configure() {
			
			Mapper.CreateMap<Customer,CustomerDto>();
			base.Configure();
		}
	}
}