using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Serialization_Serialize_Serialize_
    {
        [Fact]
        public void _CodeQuality_Serialization_Serialize_Serialize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Serialization\\Serialize\\Serialize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
