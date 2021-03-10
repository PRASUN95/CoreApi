using CoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Services
{
    public interface IBookService
    {
        Book GetById(int id);
    }
}
