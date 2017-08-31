using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_delegates_Delegate003_Delegate003_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_delegates_Delegate003_Delegate003_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\delegates\\Delegate003\\Delegate003.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
