using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Reference_gentonongen03_gentonongen03_
    {
        [OuterLoop]
        [Fact]
        public void _Conversions_Reference_gentonongen03_gentonongen03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Reference\\gentonongen03\\gentonongen03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
