using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_struct01_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_struct01_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\struct01\\struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
