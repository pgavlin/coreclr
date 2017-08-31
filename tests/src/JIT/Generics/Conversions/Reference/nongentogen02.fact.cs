using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Reference_nongentogen02_nongentogen02_
    {
        [Fact]
        public void _Conversions_Reference_nongentogen02_nongentogen02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Reference\\nongentogen02\\nongentogen02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
