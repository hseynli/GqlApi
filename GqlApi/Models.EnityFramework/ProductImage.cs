namespace Models.EnityFramework;

public sealed record ProductImage(string Name, Func<Stream> OpenStream);