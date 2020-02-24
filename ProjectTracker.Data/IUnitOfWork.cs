using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data
{
    public interface IUnitOfWork
    {
        IProjectsRepository ProjectsRepository { get; }

        void Save();
    }
}
