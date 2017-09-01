using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_Serialization_Deserialize_Deserialize_
    {
        [Fact]
        public void _CodeQuality_Serialization_Deserialize_Deserialize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Serialization\\Deserialize\\Deserialize.cmd");
        }
    }
}
