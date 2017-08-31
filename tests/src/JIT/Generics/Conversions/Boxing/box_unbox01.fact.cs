using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Conversions_Boxing_box_unbox01_box_unbox01_
    {
        [OuterLoop]
        [Fact]
        public void _Conversions_Boxing_box_unbox01_box_unbox01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Conversions\\Boxing\\box_unbox01\\box_unbox01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
