using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Interfaces_struct02_struct02_
    {
        [Fact]
        public void _Instantiation_Interfaces_struct02_struct02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Interfaces\\struct02\\struct02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
