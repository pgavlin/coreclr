using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_delegates_Delegate012_Delegate012_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_delegates_Delegate012_Delegate012_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\delegates\\Delegate012\\Delegate012.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
