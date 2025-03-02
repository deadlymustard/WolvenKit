using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public abstract class BaseFundamental<T> : IPrimitive
        where T : struct
    {
        public abstract string Name { get; }
        public T Value { get; set; } = default;

        public abstract void Serialize(BinaryWriter writer);

        public override string ToString() => Value.ToString();
    }
}
