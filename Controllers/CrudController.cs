namespace store.Controllers;

using store.Services;
using store.Models;
using store.DTOs;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public abstract class CrudController<TModel, TDTO, TUpdateDTO> : ApiControllerBase 
{
    
} 