namespace Business.Profiles
{
    internal class InstructorMappingProfile : Profile
    {

        public InstructorMappingProfile()
        {
            //Requests
            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();


            //Responses
            CreateMap<Instructor, GetInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();
        }

    }
}
