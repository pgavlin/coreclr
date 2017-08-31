using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Reference_gentonongen02_gentonongen02_
    {
        [OuterLoop]
        [Fact]
        public void _Conversions_Reference_gentonongen02_gentonongen02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Reference\\gentonongen02\\gentonongen02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
