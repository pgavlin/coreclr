using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Serialization_Deserialize_Deserialize_
    {
        [Fact]
        public void _CodeQuality_Serialization_Deserialize_Deserialize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Serialization\\Deserialize\\Deserialize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
