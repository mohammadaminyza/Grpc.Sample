using Ardalis.GuardClauses;
using M.YZ.Basement.Core.Domain.Exceptions;
using M.YZ.Basement.Core.Domain.ValueObjects;

namespace Grpc.Sample.Core.Domain.Common.ValueObjects;

public class Rate : BaseValueObject<Rate>
{
    #region Properties
    public int Value { get; set; }

    private const int MinimumLength = 1;
    private const int MaximumLength = 5;

    #endregion

    #region Ctor

    public Rate(int value)
    {
        Value = Guard.Against.NegativeOrZero(value, nameof(Rate));
        Value = Guard.Against.OutOfRange(value, nameof(Rate), MinimumLength, MaximumLength);
    }

    #endregion


    public static Rate FromInt(int value) => new Rate(value);


    public override bool ObjectIsEqual(Rate otherObject)
    {
        return otherObject.Value == Value;
    }

    public override int ObjectGetHashCode()
    {
        return Value.GetHashCode();
    }


    public static explicit operator int(Rate rate) => rate.Value;

    public static implicit operator Rate(int value) => new Rate(value);
}