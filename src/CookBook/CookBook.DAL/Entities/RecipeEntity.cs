﻿using CookBook.Common.Enums;
using System;
using System.Collections.Generic;

namespace CookBook.DAL.Entities;

public record RecipeEntity : IEntity
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required TimeSpan Duration { get; set; }
    public FoodType FoodType { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<IngredientAmountEntity> Ingredients { get; init; } = new List<IngredientAmountEntity>();
}
