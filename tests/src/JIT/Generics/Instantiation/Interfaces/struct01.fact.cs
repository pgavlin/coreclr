using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Interfaces_struct01_struct01_
    {
        [Fact]
        public void _Instantiation_Interfaces_struct01_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Interfaces\\struct01\\struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
