using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_call_static01_call_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_call_static01_call_static01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\call_static01\\call_static01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
