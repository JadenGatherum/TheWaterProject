﻿using TheWaterProject.Models.ViewModels;

namespace TheWaterProject.Models
{
    public class ProjectsListViewModel
    {
        public IQueryable<Project> Projects { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
