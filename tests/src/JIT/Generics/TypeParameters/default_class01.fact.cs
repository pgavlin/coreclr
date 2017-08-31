using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _TypeParameters_default_class01_default_class01_
    {
        [OuterLoop]
        [Fact]
        public void _TypeParameters_default_class01_default_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\TypeParameters\\default_class01\\default_class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
