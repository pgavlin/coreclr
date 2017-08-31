using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Reference_gentogen01_gentogen01_
    {
        [Fact]
        public void _Conversions_Reference_gentogen01_gentogen01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Reference\\gentogen01\\gentogen01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
