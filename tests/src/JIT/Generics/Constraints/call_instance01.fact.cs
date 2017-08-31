using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_call_instance01_call_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_call_instance01_call_instance01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\call_instance01\\call_instance01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
