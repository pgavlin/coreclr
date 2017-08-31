using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_delegates_Delegate021_Delegate021_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_delegates_Delegate021_Delegate021_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\delegates\\Delegate021\\Delegate021.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
