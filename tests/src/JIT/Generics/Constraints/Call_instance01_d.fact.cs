using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_Call_instance01_d_Call_instance01_d_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_Call_instance01_d_Call_instance01_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\Call_instance01_d\\Call_instance01_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
