using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Reference_gentogen03_gentogen03_
    {
        [Fact]
        public void _Conversions_Reference_gentogen03_gentogen03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Reference\\gentogen03\\gentogen03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
