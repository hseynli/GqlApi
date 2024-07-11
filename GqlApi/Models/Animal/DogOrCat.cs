namespace GqlApi.Models.Animal;

[OneOf]
public record DogOrCat(Dog? Dog, Cat? Cat);