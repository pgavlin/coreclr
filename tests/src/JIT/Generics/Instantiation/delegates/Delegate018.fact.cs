using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_delegates_Delegate018_Delegate018_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_delegates_Delegate018_Delegate018_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\delegates\\Delegate018\\Delegate018.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
