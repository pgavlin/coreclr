using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_struct02_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_struct02_struct02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\struct02\\struct02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
