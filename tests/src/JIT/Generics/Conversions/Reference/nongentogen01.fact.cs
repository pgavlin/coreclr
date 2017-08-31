using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Reference_nongentogen01_nongentogen01_
    {
        [Fact]
        public void _Conversions_Reference_nongentogen01_nongentogen01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Reference\\nongentogen01\\nongentogen01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
