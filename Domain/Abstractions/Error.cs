namespace Domain.Abstractions
{
    public sealed record Error(string Code, string? Message = null)
    {
        public static readonly Error None = new(String.Empty);

        public static implicit operator Result(Error error) => Result.Failure(error);
    }
}
