﻿using CuratorMagazineWebAPI.Models.Context;
using CuratorMagazineWebAPI.Models.Entities.Repositories.Interfaces;

namespace CuratorMagazineWebAPI.Models.Entities.Repositories.Entities;

/// <summary>
/// Class DivisionRepository.
/// Implements the <see cref="BaseRepository{T}.Models.Entities.Division}" />
/// Implements the <see cref="IDivisionRepository" />
/// </summary>
/// <seealso cref="BaseRepository{T}.Models.Entities.Division}" />
/// <seealso cref="IDivisionRepository" />
public class DivisionRepository : BaseRepository<Division>, IDivisionRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DivisionRepository"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public DivisionRepository(CuratorMagazineContext context) : base(context)
    {
    }
}