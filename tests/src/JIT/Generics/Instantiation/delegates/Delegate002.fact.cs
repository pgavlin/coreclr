using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_delegates_Delegate002_Delegate002_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_delegates_Delegate002_Delegate002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\delegates\\Delegate002\\Delegate002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
