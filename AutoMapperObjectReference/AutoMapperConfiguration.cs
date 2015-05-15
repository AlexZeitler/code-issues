using AutoMapper;

namespace AutoMapperObjectReference {
	public class AutoMapperConfiguration {
		public static void Configure() {
			Mapper.AddProfile<CustomerProfile>();
		}
	}
}