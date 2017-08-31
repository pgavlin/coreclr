using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_refTypesdynamic_refTypesdynamic_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_refTypesdynamic_refTypesdynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\refTypesdynamic\\refTypesdynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
