using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _TypeParameters_default_struct01_default_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _TypeParameters_default_struct01_default_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\TypeParameters\\default_struct01\\default_struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
