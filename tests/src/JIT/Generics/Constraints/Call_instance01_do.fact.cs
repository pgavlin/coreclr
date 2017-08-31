using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_Call_instance01_do_Call_instance01_do_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_Call_instance01_do_Call_instance01_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\Call_instance01_do\\Call_instance01_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
