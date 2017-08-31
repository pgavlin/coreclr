using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_struct03_struct03_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_struct03_struct03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\struct03\\struct03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
